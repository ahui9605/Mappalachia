@echo off

title Mappalachia Database Builder

IF NOT EXIST sqlite3.exe (
	echo sqlite3.exe was not found. Building the Mappalachia database requires sqlite3.exe to be placed in this folder.
	echo Please grab the sqlite-tools Windows binary from the official distribution at https://www.sqlite.org/download.html
	PAUSE
	EXIT
)

IF NOT EXIST "../Preprocessor/Output/Position_Data.csv" (
	echo Preprocessor output data was not found in the expected location. You must run the xEdit export scripts, then the Preprocessor before building the database.
	echo For more info please see development help guides.
	PAUSE
	EXIT
)

for /f "skip=1" %%l in (gameVersion.csv) do set gameVersion=%%l

echo Is %gameVersion% the correct game version?
choice /c YN
if not %errorlevel%==1 (
	echo Please correct the game version string in gameVersion.csv
	PAUSE
	EXIT
)

set databaseFile=mappalachia.db
set summaryFile=summary.txt
set outputFolder=..\Mappalachia\data

echo Cleaning up old database files...
del %databaseFile% >nul 2>&1
del %databaseFile%-journal >nul 2>&1

echo Creating new empty tables...
sqlite3.exe %databaseFile% < sql/createTables.sql

echo Importing CSVs into new tables...
sqlite3.exe %databaseFile% < SQLiteBatchCSVImport.txt

echo Replacing previously escaped characters...
sqlite3.exe %databaseFile% < sql/replaceEscapedChars.sql

echo Building combined tables...
sqlite3.exe %databaseFile% < sql/buildCombinedTables.sql

echo Trimming database...
sqlite3.exe %databaseFile% < sql/trimData.sql

echo Dropping once used tables...
sqlite3.exe %databaseFile% < sql/dropUnused.sql

echo Applying basic compression...
sqlite3.exe %databaseFile% < sql/compress.sql

echo Vacuum packing database...
sqlite3.exe %databaseFile% VACUUM

echo Building indices...
sqlite3.exe %databaseFile% < sql/createIndices.sql

echo Noting required Map Marker images...
sqlite3.exe %databaseFile% < sql/getMapMarkerNames.sql > requiredMarkers.txt

echo Creating new summary with db file info...
echo ==Database name== > %summaryFile%
echo %databaseFile% >> %summaryFile%
echo ==Checksum== >> %summaryFile%
certutil -hashfile %databaseFile% MD5 | findstr /V ":" >> %summaryFile%
echo ==File Size== >> %summaryFile%
for %%f in (%databaseFile%) do echo %%~zf >> %summaryFile%

echo Listing tables and indices...
echo ==Tables== >> %summaryFile%
sqlite3.exe %databaseFile% .tables >> %summaryFile%

echo ==Indices== >> %summaryFile%
sqlite3.exe %databaseFile% .indices >> %summaryFile%

echo Populating main summary report...
sqlite3.exe %databaseFile% < sql/generateSummary.sql >> %summaryFile%

echo Moving database to Mappalachia program...
IF NOT EXIST %outputFolder% (
	mkdir %outputFolder%
)

move %databaseFile% %outputFolder% >nul

echo.
echo Finished!
PAUSE
