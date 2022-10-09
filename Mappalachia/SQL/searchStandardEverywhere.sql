SELECT referenceFormId, editorID, displayName, category, lockLevel, amount, spaceEditorId, spaceDisplayName, label
FROM Standard_Search
JOIN Space_Info ON Standard_Search.spaceFormId = Space_Info.spaceFormID
JOIN Entity_Info ON Standard_Search.referenceFormID = Entity_Info.entityFormID
WHERE
(category IN ($allowedSignatures) AND
lockLevel IN ($allowedLockTypes) AND
(EditorId LIKE $searchTerm ESCAPE '\' OR displayName LIKE $searchTerm ESCAPE '\' OR referenceFormId LIKE $searchTerm ESCAPE '\' OR label LIKE $searchTerm ESCAPE '\'))

ORDER BY Standard_Search.spaceFormId = $spaceFormID DESC, amount DESC
