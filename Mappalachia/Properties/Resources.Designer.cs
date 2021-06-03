﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mappalachia.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mappalachia.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT x, y, z
        ///FROM SeventySix_Interior
        ///WHERE cellFormID = $cellFormID
        ///.
        /// </summary>
        internal static string getAllCoordsCell {
            get {
                return ResourceManager.GetString("getAllCoordsCell", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT cellFormID, cellEditorID, cellDisplayName
        ///FROM SeventySix_Cell
        ///ORDER BY cellDisplayName
        ///.
        /// </summary>
        internal static string getCells {
            get {
                return ResourceManager.GetString("getCells", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT x, y, z, primitiveShape, boundX, boundY, boundZ, rotZ
        ///FROM SeventySix_Interior
        ///WHERE cellFormID = $cellFormID AND referenceFormID = $formID AND lockLevel IN ($allowedLockTypes)
        ///.
        /// </summary>
        internal static string getCoordsCell {
            get {
                return ResourceManager.GetString("getCoordsCell", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT x, y, z, chance*100 AS chance FROM SeventySix_Worldspace
        ///INNER JOIN SeventySix_NPCSpawn ON class = spawnClass AND SeventySix_Worldspace.locationFormID = SeventySix_NPCSpawn.locationFormID
        ///WHERE npc = $npc AND chance &gt;= $minChance
        ///.
        /// </summary>
        internal static string getCoordsNPC {
            get {
                return ResourceManager.GetString("getCoordsNPC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT x, y, z, componentQuantity FROM SeventySix_Worldspace
        ///INNER JOIN SeventySix_Quantified_Scrap ON SeventySix_Worldspace.referenceFormID = SeventySix_Quantified_Scrap.junkFormID
        ///WHERE component = $scrap
        ///.
        /// </summary>
        internal static string getCoordsScrap {
            get {
                return ResourceManager.GetString("getCoordsScrap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT x, y, z, primitiveShape, boundX, boundY, boundZ, rotZ
        ///FROM SeventySix_Worldspace
        ///WHERE referenceFormID = $formID AND lockLevel IN ($allowedLockTypes)
        ///.
        /// </summary>
        internal static string getCoordsStandard {
            get {
                return ResourceManager.GetString("getCoordsStandard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT lockLevel
        ///FROM SeventySix_Worldspace
        ///UNION
        ///SELECT lockLevel
        ///FROM SeventySix_Interior
        ///GROUP BY lockLevel
        ///.
        /// </summary>
        internal static string getLockLevels {
            get {
                return ResourceManager.GetString("getLockLevels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT npc
        ///FROM SeventySix_NPCSpawn
        ///GROUP BY npc
        ///.
        /// </summary>
        internal static string getNPCTypes {
            get {
                return ResourceManager.GetString("getNPCTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT component
        ///FROM SeventySix_Quantified_Scrap
        ///GROUP BY component
        ///.
        /// </summary>
        internal static string getScrapTypes {
            get {
                return ResourceManager.GetString("getScrapTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT signature
        ///FROM SeventySix_FormId
        ///GROUP BY signature
        ///.
        /// </summary>
        internal static string getSignatures {
            get {
                return ResourceManager.GetString("getSignatures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT npc, COUNT(*) AS count, MIN(chance)*100 AS minChance, &apos;Appalachia&apos; AS cellDisplayName, &apos;Appalachia&apos; AS cellEditorID, &apos;0&apos; AS isInterior
        ///FROM SeventySix_Worldspace
        ///INNER JOIN SeventySix_NPCSpawn ON class = spawnClass AND SeventySix_Worldspace.locationFormID = SeventySix_NPCSpawn.locationFormID
        ///WHERE NPC = $searchTerm AND Chance &gt;= $minChance
        ///GROUP BY cellEditorID
        ///
        ///UNION
        ///
        ///SELECT npc, COUNT(*) AS count, MIN(chance)*100 AS minChance, cellDisplayName, cellEditorID, &apos;1&apos; AS isInterior
        ///FROM SeventySi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string searchNPCAll {
            get {
                return ResourceManager.GetString("searchNPCAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT npc, COUNT(*) AS count, MIN(chance)*100 AS minChance, &apos;Appalachia&apos; AS cellDisplayName, &apos;Appalachia&apos; AS cellEditorID
        ///FROM SeventySix_Worldspace
        ///INNER JOIN SeventySix_NPCSpawn ON class = spawnClass AND SeventySix_Worldspace.locationFormID = SeventySix_NPCSpawn.locationFormID
        ///WHERE NPC = $searchTerm AND Chance &gt;= $minChance
        ///GROUP BY cellEditorID
        ///ORDER BY COUNT DESC
        ///.
        /// </summary>
        internal static string searchNPCAppalachia {
            get {
                return ResourceManager.GetString("searchNPCAppalachia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT component, SUM(magnitude) AS total_scrap, cellDisplayName, cellEditorID, &apos;0&apos; AS isInterior
        ///FROM
        ///(
        ///	SELECT referenceFormID, component, componentQuantity*COUNT(*) AS magnitude, &apos;Appalachia&apos; AS cellDisplayName, &apos;Appalachia&apos; AS cellEditorID
        ///	FROM SeventySix_Worldspace
        ///	INNER JOIN SeventySix_Quantified_Scrap ON junkFormID = referenceFormID
        ///	WHERE component = $searchTerm
        ///	GROUP BY referenceFormID
        ///)
        ///
        ///UNION
        ///
        ///SELECT component, SUM(magnitude) AS total_scrap, cellDisplayName, cellEditorID, &apos;1&apos; AS is [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string searchScrapAll {
            get {
                return ResourceManager.GetString("searchScrapAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT component, SUM(magnitude) AS total_scrap, cellDisplayName, cellEditorID
        ///FROM
        ///(
        ///	SELECT referenceFormID, component, componentQuantity*COUNT(*) AS magnitude, &apos;Appalachia&apos; AS cellDisplayName, &apos;Appalachia&apos; AS cellEditorID
        ///	FROM SeventySix_Worldspace
        ///	INNER JOIN SeventySix_Quantified_Scrap ON junkFormID = referenceFormID
        ///	WHERE component = $searchTerm
        ///	GROUP BY referenceFormID
        ///)
        ///GROUP BY cellEditorID
        ///ORDER BY total_scrap DESC
        ///.
        /// </summary>
        internal static string searchScrapAppalachia {
            get {
                return ResourceManager.GetString("searchScrapAppalachia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM
        ///(
        ///	SELECT
        ///		displayName,
        ///		editorID,
        ///		signature,
        ///		COUNT(*) AS amount,
        ///		lockLevel,
        ///		entityFormID,
        ///		&apos;Appalachia&apos; AS cellDisplayName,
        ///		&apos;Appalachia&apos; AS cellEditorID
        ///	FROM SeventySix_FormId
        ///	INNER JOIN SeventySix_Worldspace ON referenceFormID = entityFormID
        ///	WHERE
        ///		(
        ///			(EditorId LIKE $searchTerm ESCAPE &apos;\&apos; or
        ///			displayName LIKE $searchTerm ESCAPE &apos;\&apos; or
        ///			entityFormID LIKE $searchTerm ESCAPE &apos;\&apos;)
        ///			AND signature IN ($allowedSignatures)
        ///			AND lockLevel IN ($allowedLock [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string searchStandardAll {
            get {
                return ResourceManager.GetString("searchStandardAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM
        ///(
        ///	SELECT
        ///		displayName,
        ///		editorID,
        ///		signature,
        ///		COUNT(*) AS amount,
        ///		lockLevel,
        ///		entityFormID,
        ///		&apos;Appalachia&apos; AS cellDisplayName,
        ///		&apos;Appalachia&apos; AS cellEditorID
        ///	FROM SeventySix_FormId
        ///	INNER JOIN SeventySix_Worldspace ON referenceFormID = entityFormID
        ///	WHERE
        ///		(
        ///			(EditorId LIKE $searchTerm ESCAPE &apos;\&apos; OR
        ///			displayName LIKE $searchTerm ESCAPE &apos;\&apos; OR
        ///			entityFormID LIKE $searchTerm ESCAPE &apos;\&apos;)
        ///			AND signature IN ($allowedSignatures)
        ///			AND lockLevel IN ($allowedLock [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string searchStandardAppalachia {
            get {
                return ResourceManager.GetString("searchStandardAppalachia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM
        ///(
        ///	SELECT
        ///		displayName,
        ///		editorID,
        ///		signature,
        ///		COUNT(*) AS amount,
        ///		lockLevel,
        ///		entityFormID
        ///	FROM SeventySix_FormId
        ///	INNER JOIN SeventySix_Interior ON referenceFormID = entityFormID
        ///	WHERE
        ///		(
        ///			(EditorId LIKE $searchTerm ESCAPE &apos;\&apos; OR
        ///			displayName LIKE $searchTerm ESCAPE &apos;\&apos; OR
        ///			entityFormID LIKE $searchTerm ESCAPE &apos;\&apos;)
        ///			AND cellFormID = $cellFormID
        ///			AND signature IN ($allowedSignatures)
        ///			AND lockLevel IN ($allowedLockTypes)
        ///		)
        ///	GROUP BY entityFormID
        ///) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string searchStandardCell {
            get {
                return ResourceManager.GetString("searchStandardCell", resourceCulture);
            }
        }
    }
}
