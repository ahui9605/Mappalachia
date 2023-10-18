using System;
using System.Collections.Generic;
using System.Linq;

namespace Mappalachia
{
	// Provides data helper methods, data translation and sorting
	public static class DataHelper
	{
		// A list of entities which are often (mis)represented instead by LVLI in the data
		public static readonly List<string> typicalLVLIItems = new List<string> { "FLOR", "ALCH", "WEAP", "ARMO", "BOOK", "AMMO" };

		static readonly Dictionary<string, string> signatureDescription = new Dictionary<string, string>
		{
			{ "STAT", "环境景观，它不会移动且不能与之交互" },
			{ "SCOL", "一组静态对象的集合" },
			{ "ACTI", "定义的触发体积，在游戏中不可见\n" +
				"触发器可以标记出指定区域、触发事件，或作为交互的碰撞盒" },
			{ "LIGH", string.Empty },
			{ "NPC_", "非玩家角色" },
			{ "MISC", "可拆解、垃圾或改装件" },
			{ "MSTT", "能够进行动画播放或响应物理影响的环境景观" },
			{ "BOOK", "笔记、计划或配方" },
			{ "CONT", "任何可以容纳物品的东西" },
			{ "FURN", "任何可以容纳物品的家具\n" +
				"也包括工作台和乐器等可互动" },
			{ "LVLI", "可捡取物品，具有一定的生成几率 (高达100%的概率)\n" +
				"许多不同类别的物品也都包含在这个类别下" },
			{ "TERM", string.Empty },
			{ "TXST", "应用到体积表面的贴图，如喷涂涂鸦或泥土污垢等" },
			{ "DOOR", string.Empty },
			{ "ALCH", "食物、饮料、辅助品等." },
			{ "SOUN", "声效触发" },
			{ "NOTE", string.Empty },
			{ "FLOR", "可收集的自然资源" },
			{ "ARMO", string.Empty },
			{ "ASPC", "设置应用到特定环境声学" },
			{ "WEAP", string.Empty },
			{ "KEYM", string.Empty },
			{ "TACT", "用于播放广播线路的触发/碰撞器" },
			{ "HAZD", "能够伤害玩家的地区（火/辐射）" },
			{ "AMMO", string.Empty },
			{ "IDLM", "npc进入挂机/空闲动画" },
			{ "BNDS", "一种曲线条形状，通常用于建筑物电线装饰" },
			{ "SECH", "游戏回声声效的触发" },
			{ "PROJ", "掷弹类爆炸品，比如地雷和手雷" },
			{ "CNCY", string.Empty },
			{ "REGN", "定义地图区域的边缘" },
		};

		// Provide a user-friendly name for each signature which best represents what a typical player would know them as
		static readonly Dictionary<string, string> signatureToFriendlyName = new Dictionary<string, string>
		{
			{ "STAT", "静态物体" },
			{ "SCOL", "对象集合" },
			{ "ACTI", "触发器" },
			{ "LIGH", "光源" },
			{ "NPC_", "NPC" },
			{ "MISC", "可拆解/垃圾" },
			{ "MSTT", "可互动静态物体" },
			{ "BOOK", "笔记/计划" },
			{ "CONT", "容器" },
			{ "FURN", "家具" },
			{ "LVLI", "战利品" },
			{ "TERM", "终端" },
			{ "TXST", "贴图" },
			{ "DOOR", "门" },
			{ "ALCH", "辅助品" },
			{ "SOUN", "声效" },
			{ "NOTE", "全息磁带" },
			{ "FLOR", "自然资源" },
			{ "ARMO", "护甲/装备" },
			{ "ASPC", "声效应用" },
			{ "WEAP", "武器" },
			{ "KEYM", "钥匙" },
			{ "TACT", "声效触发器" },
			{ "HAZD", "危险区" },
			{ "AMMO", "弹药" },
			{ "IDLM", "NPC挂机标记" },
			{ "BNDS", "曲线装饰物" },
			{ "SECH", "回声声效" },
			{ "PROJ", "掷弹品" },
			{ "CNCY", "货币" },
			{ "REGN", "地区/区域" },
		};

		// Provides a pre-ordered list of each signature in a suggested sort order for the UI
		// This groups often-used items towards the top, and similar items together
		// Items not on this list are added to the bottom
		public static readonly List<string> suggestedSignatureSort = new List<string>
		{
			"LVLI",
			"FLOR",
			"NPC_",
			"MISC",
			"BOOK",
			"ALCH",
			"CONT",
			"STAT",
			"SCOL",
			"MSTT",
			"FURN",
			"NOTE",
			"TERM",
			"ARMO",
			"WEAP",
			"AMMO",
			"PROJ",
			"CNCY",
			"KEYM",
			"ACTI",
			"TACT",
			"DOOR",
			"HAZD",
			"IDLM",
			"LIGH",
			"SOUN",
			"SECH",
			"ASPC",
			"TXST",
			"BNDS",
		};

		// Provides a list of the recommended signatures to be selected by the filter by default
		// This helps prevent new users being flooded with less relevant or more technical results.
		public static readonly List<string> recommendedSignatures = new List<string>
		{
			"LVLI",
			"FLOR",
			"NPC_",
			"MISC",
			"BOOK",
			"ALCH",
			"CONT",
			/*"STAT",
			"SCOL",
			"MSTT",*/
			"FURN",
			"NOTE",
			"TERM",
			"ARMO",
			"WEAP",
			"AMMO",
			"PROJ",
			"CNCY",
			"KEYM",
			"ACTI",
			/*"TACT",
			"DOOR",
			"HAZD",
			"IDLM",
			"LIGH",
			"SOUN",
			"SECH",
			"ASPC",
			"TXST",
			"BNDS",*/
		};

		// Inverse the user friendly signature names so we can use the proper signatures in queries
		static readonly Dictionary<string, string> signatureToProperName = signatureToFriendlyName.ToDictionary(x => x.Value, x => x.Key);

		// Provide a user-friendly name to the lock level
		static readonly Dictionary<string, string> lockLevelToFriendlyName = new Dictionary<string, string>
		{
			{ string.Empty,         "未上锁/无锁" },
			{ "Novice (Level 0)",   "级别0" },
			{ "Advanced (Level 1)", "级别1" },
			{ "Expert (Level 2)",   "级别2" },
			{ "Master (Level 3)",   "级别3" },
			{ "Requires Terminal",   "需要终端" },
			{ "Requires Key",   "需要钥匙" },
			{ "Chained",   "反锁" },
			{ "Barred",   "上了门闩" },
			{ "Inaccessible",   "无法使用" },
			{ "Unknown",   "未知" },
		};

		// Inverse the user friendly lock names so we can use the proper lock levels in queries
		static readonly Dictionary<string, string> lockLevelToProperName = lockLevelToFriendlyName.ToDictionary(x => x.Value, x => x.Key);

		// Provides a pre-ordered list of each lock level in a suggested sort order
		// This groups often-used items towards the top, and similar items together
		public static readonly List<string> suggestedLockLevelSort = new List<string>
		{
			string.Empty,
			"Novice (Level 0)",
			"Advanced (Level 1)",
			"Expert (Level 2)",
			"Master (Level 3)",
			"Requires Terminal",
			"Requires Key",
			"Chained",
			"Barred",
			"Inaccessible",
			"Unknown",
		};

		// Signatures which could be affected by a lock level
		public static readonly List<string> lockableTypes = new List<string> { "CONT", "DOOR", "TERM" };

		// Convert a signature to the proper or user-friendly version of itself
		// Works regardless of the current state of the given signature
		public static string ConvertSignature(string signature, bool properName)
		{
			try
			{
				if (properName)
				{
					return signatureToFriendlyName.ContainsKey(signature) ? signature : signatureToProperName[signature];
				}
				else
				{
					return signatureToProperName.ContainsKey(signature) ? signature : signatureToFriendlyName[signature];
				}
			}
			catch (Exception)
			{
				// Unable to convert - just return it unconverted
				return signature;
			}
		}

		// Convert a lockLevel to the proper or user-friendly version of itself
		// Works regardless of the current state of the given lock level
		public static string ConvertLockLevel(string lockLevel, bool properName)
		{
			try
			{
				// We don't convert all lock levels
				if (!lockLevelToFriendlyName.ContainsKey(lockLevel) &&
					!lockLevelToProperName.ContainsKey(lockLevel))
				{
					return lockLevel;
				}

				if (properName)
				{
					return lockLevelToFriendlyName.ContainsKey(lockLevel) ? lockLevel : lockLevelToProperName[lockLevel];
				}
				else
				{
					return lockLevelToProperName.ContainsKey(lockLevel) ? lockLevel : lockLevelToFriendlyName[lockLevel];
				}
			}
			catch (Exception)
			{
				// Unable to convert - just return it unconverted
				return lockLevel;
			}
		}

		// Convert a List of lockLevel to the proper or user-friendly version of itself
		// Works regardless of the current state of the given lock level
		public static List<string> ConvertLockLevel(List<string> lockLevels, bool properName)
		{
			List<string> result = new List<string>();

			foreach (string lockLevel in lockLevels)
			{
				result.Add(ConvertLockLevel(lockLevel, properName));
			}

			return result;
		}

		// Find the description of a given signature, in either long or short form
		public static string GetSignatureDescription(string signature)
		{
			try
			{
				return signatureDescription[ConvertSignature(signature, true)];
			}
			catch (Exception)
			{
				return "Unsupported signature!";
			}
		}

		// Escape functional SQL characters and wildcard on space
		public static string ProcessSearchString(string input)
		{
			return "%" + input.Trim()
				.Replace("_", "\\_")
				.Replace("%", "\\%")
				.Replace(" ", "%") + "%";
		}

		// Indicate the spawn chance of a standard item based on understandings of LVLI
		public static float GetSpawnChance(string signature, string editorID)
		{
			return (signature == "LVLI" || editorID.Contains("ChanceNone")) ? -1 : 100;
		}

		// Returns the nth item in a list as if it were cyclic (supports <0 or >n)
		public static T GetCyclicItem<T>(List<T> collection, int n)
		{
			if (collection.Count == 0)
			{
				return default;
			}

			n %= collection.Count;

			if (n < 0)
			{
				n = collection.Count + n;
			}

			return collection[n];
		}
	}
}
