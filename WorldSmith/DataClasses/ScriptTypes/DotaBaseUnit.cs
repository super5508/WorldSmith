/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	public partial class DotaBaseUnit : BaseScriptType
	{
		public DotaBaseUnit(KeyValue kv)
			: base(kv)
		{
		}
		public DotaBaseUnit(string className)
			: base(className)
		{
		}
		[Category("General")]
		[Description("Model.")]
		[DefaultValue("models/error.mdl")]
		public string Model
		{
			get
			{
				KeyValue kv = GetSubkey("Model");
				return (kv == null ? "models/error.mdl" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Model");
				if(kv == null)
				{
					kv = new KeyValue("Model");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("General")]
		[Description("Name of sound set.")]
		[DefaultValue("0")]
		public string SoundSet
		{
			get
			{
				KeyValue kv = GetSubkey("SoundSet");
				return (kv == null ? "0" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("SoundSet");
				if(kv == null)
				{
					kv = new KeyValue("SoundSet");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("General")]
		[Description("Starting level.")]
		[DefaultValue(1)]
		public int Level
		{
			get
			{
				KeyValue kv = GetSubkey("Level");
				return (kv == null ? 1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("Level");
				if(kv == null)
				{
					kv = new KeyValue("Level");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Number of abilities.")]
		[DefaultValue(4)]
		public int AbilityLayout
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityLayout");
				return (kv == null ? 4 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AbilityLayout");
				if(kv == null)
				{
					kv = new KeyValue("AbilityLayout");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 1.")]
		[DefaultValue("")]
		public string Ability1
		{
			get
			{
				KeyValue kv = GetSubkey("Ability1");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability1");
				if(kv == null)
				{
					kv = new KeyValue("Ability1");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 2.")]
		[DefaultValue("")]
		public string Ability2
		{
			get
			{
				KeyValue kv = GetSubkey("Ability2");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability2");
				if(kv == null)
				{
					kv = new KeyValue("Ability2");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 3.")]
		[DefaultValue("")]
		public string Ability3
		{
			get
			{
				KeyValue kv = GetSubkey("Ability3");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability3");
				if(kv == null)
				{
					kv = new KeyValue("Ability3");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 4.")]
		[DefaultValue("")]
		public string Ability4
		{
			get
			{
				KeyValue kv = GetSubkey("Ability4");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability4");
				if(kv == null)
				{
					kv = new KeyValue("Ability4");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 5 - Bonuses.")]
		[DefaultValue("")]
		public string Ability5
		{
			get
			{
				KeyValue kv = GetSubkey("Ability5");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability5");
				if(kv == null)
				{
					kv = new KeyValue("Ability5");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 6 - Extra.")]
		[DefaultValue("")]
		public string Ability6
		{
			get
			{
				KeyValue kv = GetSubkey("Ability6");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability6");
				if(kv == null)
				{
					kv = new KeyValue("Ability6");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 7 - Extra.")]
		[DefaultValue("")]
		public string Ability7
		{
			get
			{
				KeyValue kv = GetSubkey("Ability7");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability7");
				if(kv == null)
				{
					kv = new KeyValue("Ability7");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Abilities")]
		[Description("Ability 8 - Extra.")]
		[DefaultValue("")]
		public string Ability8
		{
			get
			{
				KeyValue kv = GetSubkey("Ability8");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("Ability8");
				if(kv == null)
				{
					kv = new KeyValue("Ability8");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Armor")]
		[Description("Physical protection.")]
		[DefaultValue(-1)]
		public int ArmorPhysical
		{
			get
			{
				KeyValue kv = GetSubkey("ArmorPhysical");
				return (kv == null ? -1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("ArmorPhysical");
				if(kv == null)
				{
					kv = new KeyValue("ArmorPhysical");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Armor")]
		[Description("Magical protection (percentage).")]
		[DefaultValue(25)]
		public int MagicalResistance
		{
			get
			{
				KeyValue kv = GetSubkey("MagicalResistance");
				return (kv == null ? 25 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("MagicalResistance");
				if(kv == null)
				{
					kv = new KeyValue("MagicalResistance");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum AttackCapabilitiesEnum
		{
			DOTA_UNIT_CAP_NO_ATTACK,
			DOTA_UNIT_CAP_RANGED_ATTACK,
			DOTA_UNIT_CAP_MELEE_ATTACK,
		}

		[Category("Attack")]
		[Description("Gives the unit melee of ranged attack capability.")]
		[DefaultValue(AttackCapabilitiesEnum.DOTA_UNIT_CAP_RANGED_ATTACK)]
		public AttackCapabilitiesEnum AttackCapabilities
		{
			get
			{
				KeyValue kv = GetSubkey("AttackCapabilities");
				return (kv == null ? AttackCapabilitiesEnum.DOTA_UNIT_CAP_RANGED_ATTACK : kv.GetEnum<AttackCapabilitiesEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackCapabilities");
				if(kv == null)
				{
					kv = new KeyValue("AttackCapabilities");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Damage range min.")]
		[DefaultValue(1)]
		public int AttackDamageMin
		{
			get
			{
				KeyValue kv = GetSubkey("AttackDamageMin");
				return (kv == null ? 1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackDamageMin");
				if(kv == null)
				{
					kv = new KeyValue("AttackDamageMin");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Damage range max.")]
		[DefaultValue(1)]
		public int AttackDamageMax
		{
			get
			{
				KeyValue kv = GetSubkey("AttackDamageMax");
				return (kv == null ? 1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackDamageMax");
				if(kv == null)
				{
					kv = new KeyValue("AttackDamageMax");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum AttackDamageTypeEnum
		{
			DAMAGE_TYPE_ArmorPhysical,
		}

		[Category("Attack")]
		[Description("Type of damage dealt.")]
		[DefaultValue(AttackDamageTypeEnum.DAMAGE_TYPE_ArmorPhysical)]
		public AttackDamageTypeEnum AttackDamageType
		{
			get
			{
				KeyValue kv = GetSubkey("AttackDamageType");
				return (kv == null ? AttackDamageTypeEnum.DAMAGE_TYPE_ArmorPhysical : kv.GetEnum<AttackDamageTypeEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackDamageType");
				if(kv == null)
				{
					kv = new KeyValue("AttackDamageType");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Speed of attack.")]
		[DefaultValue(1.7f)]
		public float AttackRate
		{
			get
			{
				KeyValue kv = GetSubkey("AttackRate");
				return (kv == null ? 1.7f : kv.GetFloat());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackRate");
				if(kv == null)
				{
					kv = new KeyValue("AttackRate");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Normalized time in animation cycle to attack.")]
		[DefaultValue(0.75f)]
		public float AttackAnimationPoint
		{
			get
			{
				KeyValue kv = GetSubkey("AttackAnimationPoint");
				return (kv == null ? 0.75f : kv.GetFloat());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackAnimationPoint");
				if(kv == null)
				{
					kv = new KeyValue("AttackAnimationPoint");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Range within a target can be acquired.")]
		[DefaultValue(true)]
		public bool AttackAcquisitionRange
		{
			get
			{
				KeyValue kv = GetSubkey("AttackAcquisitionRange");
				return (kv == null ? true : kv.GetBool());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackAcquisitionRange");
				if(kv == null)
				{
					kv = new KeyValue("AttackAcquisitionRange");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Range within a target can be attacked.")]
		[DefaultValue(600)]
		public int AttackRange
		{
			get
			{
				KeyValue kv = GetSubkey("AttackRange");
				return (kv == null ? 600 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttackRange");
				if(kv == null)
				{
					kv = new KeyValue("AttackRange");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Particle system model for projectile.")]
		[DefaultValue("ranged_hero")]
		public string ProjectileModel
		{
			get
			{
				KeyValue kv = GetSubkey("ProjectileModel");
				return (kv == null ? "ranged_hero" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("ProjectileModel");
				if(kv == null)
				{
					kv = new KeyValue("ProjectileModel");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attack")]
		[Description("Speed of projectile.")]
		[DefaultValue(900)]
		public int ProjectileSpeed
		{
			get
			{
				KeyValue kv = GetSubkey("ProjectileSpeed");
				return (kv == null ? 900 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("ProjectileSpeed");
				if(kv == null)
				{
					kv = new KeyValue("ProjectileSpeed");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum AttributePrimaryEnum
		{
			DOTA_ATTRIBUTE_STRENGTH,
			DOTA_ATTRIBUTE_AGILITY,
			DOTA_ATTRIBUTE_INTELLECT,
		}

		[Category("Attributes")]
		[Description("Sets the primary attribute of the unit.")]
		[DefaultValue(AttributePrimaryEnum.DOTA_ATTRIBUTE_STRENGTH)]
		public AttributePrimaryEnum AttributePrimary
		{
			get
			{
				KeyValue kv = GetSubkey("AttributePrimary");
				return (kv == null ? AttributePrimaryEnum.DOTA_ATTRIBUTE_STRENGTH : kv.GetEnum<AttributePrimaryEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributePrimary");
				if(kv == null)
				{
					kv = new KeyValue("AttributePrimary");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Base strength")]
		[DefaultValue(0)]
		public int AttributeBaseStrength
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeBaseStrength");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeBaseStrength");
				if(kv == null)
				{
					kv = new KeyValue("AttributeBaseStrength");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Strength bonus per level.")]
		[DefaultValue(0)]
		public int AttributeStrengthGain
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeStrengthGain");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeStrengthGain");
				if(kv == null)
				{
					kv = new KeyValue("AttributeStrengthGain");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Base intelligence")]
		[DefaultValue(0)]
		public int AttributeBaseIntelligence
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeBaseIntelligence");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeBaseIntelligence");
				if(kv == null)
				{
					kv = new KeyValue("AttributeBaseIntelligence");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Intelligence bonus per level.")]
		[DefaultValue(0)]
		public int AttributeIntelligenceGain
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeIntelligenceGain");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeIntelligenceGain");
				if(kv == null)
				{
					kv = new KeyValue("AttributeIntelligenceGain");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Base agility")]
		[DefaultValue(0)]
		public int AttributeBaseAgility
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeBaseAgility");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeBaseAgility");
				if(kv == null)
				{
					kv = new KeyValue("AttributeBaseAgility");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Attributes")]
		[Description("Agility bonus per level.")]
		[DefaultValue(0)]
		public int AttributeAgilityGain
		{
			get
			{
				KeyValue kv = GetSubkey("AttributeAgilityGain");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("AttributeAgilityGain");
				if(kv == null)
				{
					kv = new KeyValue("AttributeAgilityGain");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Bounty")]
		[Description("Experience earned when killing this unit")]
		[DefaultValue(62)]
		public int BountyXP
		{
			get
			{
				KeyValue kv = GetSubkey("BountyXP");
				return (kv == null ? 62 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("BountyXP");
				if(kv == null)
				{
					kv = new KeyValue("BountyXP");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Bounty")]
		[Description("Minimum gold earned when killing this unit.")]
		[DefaultValue(0)]
		public int BountyGoldMin
		{
			get
			{
				KeyValue kv = GetSubkey("BountyGoldMin");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("BountyGoldMin");
				if(kv == null)
				{
					kv = new KeyValue("BountyGoldMin");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Bounty")]
		[Description("Maximum gold earned when killing this unit.")]
		[DefaultValue(0)]
		public int BountyGoldMax
		{
			get
			{
				KeyValue kv = GetSubkey("BountyGoldMax");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("BountyGoldMax");
				if(kv == null)
				{
					kv = new KeyValue("BountyGoldMax");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum BoundsHullNameEnum
		{
			DOTA_HULL_SIZE_HERO,
			DOTA_HULL_SIZE_SMALL,
			DOTA_HULL_SIZE_REGULAR,
			DOTA_HULL_SIZE_TOWER,
			DOTA_HULL_SIZE_FILLER,
			DOTA_HULL_SIZE_BARRACKS,
			DOTA_HULL_SIZE_BUILDING,
			DOTA_HULL_SIZE_SIEGE,
			DOTA_HULL_SIZE_HUGE,
		}

		[Category("Bounds")]
		[Description("Type of bounds hull.(?)")]
		[DefaultValue(BoundsHullNameEnum.DOTA_HULL_SIZE_HERO)]
		public BoundsHullNameEnum BoundsHullName
		{
			get
			{
				KeyValue kv = GetSubkey("BoundsHullName");
				return (kv == null ? BoundsHullNameEnum.DOTA_HULL_SIZE_HERO : kv.GetEnum<BoundsHullNameEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("BoundsHullName");
				if(kv == null)
				{
					kv = new KeyValue("BoundsHullName");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Bounds")]
		[Description("Radius of ring when selecting unit(?)")]
		[DefaultValue(70)]
		public int RingRadius
		{
			get
			{
				KeyValue kv = GetSubkey("RingRadius");
				return (kv == null ? 70 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("RingRadius");
				if(kv == null)
				{
					kv = new KeyValue("RingRadius");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum MovementCapabilitiesEnum
		{
			DOTA_UNIT_CAP_MOVE_NONE,
			DOTA_UNIT_CAP_MOVE_GROUND,
			DOTA_UNIT_CAP_MOVE_FLY,
		}

		[Category("Movement")]
		[Description("Type of movement capabilities for this unit.")]
		[DefaultValue(MovementCapabilitiesEnum.DOTA_UNIT_CAP_MOVE_GROUND)]
		public MovementCapabilitiesEnum MovementCapabilities
		{
			get
			{
				KeyValue kv = GetSubkey("MovementCapabilities");
				return (kv == null ? MovementCapabilitiesEnum.DOTA_UNIT_CAP_MOVE_GROUND : kv.GetEnum<MovementCapabilitiesEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("MovementCapabilities");
				if(kv == null)
				{
					kv = new KeyValue("MovementCapabilities");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Movement")]
		[Description("Speed")]
		[DefaultValue(300)]
		public int MovementSpeed
		{
			get
			{
				KeyValue kv = GetSubkey("MovementSpeed");
				return (kv == null ? 300 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("MovementSpeed");
				if(kv == null)
				{
					kv = new KeyValue("MovementSpeed");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Movement")]
		[Description("Turn rate.")]
		[DefaultValue(0.5f)]
		public float MovementTurnRate
		{
			get
			{
				KeyValue kv = GetSubkey("MovementTurnRate");
				return (kv == null ? 0.5f : kv.GetFloat());
			}
			set
			{
				KeyValue kv = GetSubkey("MovementTurnRate");
				if(kv == null)
				{
					kv = new KeyValue("MovementTurnRate");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Movement")]
		[Description("Plays alternate idle/run animation when near enemies")]
		[DefaultValue(false)]
		public bool HasAggressiveStance
		{
			get
			{
				KeyValue kv = GetSubkey("HasAggressiveStance");
				return (kv == null ? false : kv.GetBool());
			}
			set
			{
				KeyValue kv = GetSubkey("HasAggressiveStance");
				if(kv == null)
				{
					kv = new KeyValue("HasAggressiveStance");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Status")]
		[Description("Base Health")]
		[DefaultValue(150)]
		public int StatusHealth
		{
			get
			{
				KeyValue kv = GetSubkey("StatusHealth");
				return (kv == null ? 150 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("StatusHealth");
				if(kv == null)
				{
					kv = new KeyValue("StatusHealth");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Status")]
		[Description("Health regeneration rate.")]
		[DefaultValue(0.25f)]
		public float StatusHealthRegen
		{
			get
			{
				KeyValue kv = GetSubkey("StatusHealthRegen");
				return (kv == null ? 0.25f : kv.GetFloat());
			}
			set
			{
				KeyValue kv = GetSubkey("StatusHealthRegen");
				if(kv == null)
				{
					kv = new KeyValue("StatusHealthRegen");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Status")]
		[Description("Base mana.")]
		[DefaultValue(0)]
		public int StatusMana
		{
			get
			{
				KeyValue kv = GetSubkey("StatusMana");
				return (kv == null ? 0 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("StatusMana");
				if(kv == null)
				{
					kv = new KeyValue("StatusMana");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Status")]
		[Description("Mana regeneration rate.")]
		[DefaultValue(0.01f)]
		public float StatusManaRegen
		{
			get
			{
				KeyValue kv = GetSubkey("StatusManaRegen");
				return (kv == null ? 0.01f : kv.GetFloat());
			}
			set
			{
				KeyValue kv = GetSubkey("StatusManaRegen");
				if(kv == null)
				{
					kv = new KeyValue("StatusManaRegen");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Status")]
		[Description("Mana regeneration rate.")]
		[DefaultValue(-1)]
		public int StatusStartingMana
		{
			get
			{
				KeyValue kv = GetSubkey("StatusStartingMana");
				return (kv == null ? -1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("StatusStartingMana");
				if(kv == null)
				{
					kv = new KeyValue("StatusStartingMana");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum TeamNameEnum
		{
			DOTA_TEAM_NEUTRALS,
			DOTA_TEAM_BADGUYS,
			DOTA_TEAM_GOODGUYS,
			DOTA_TEAM_NOTEAM,
		}

		[Category("Team")]
		[Description("Decides what team the unit belongs to.")]
		[DefaultValue(TeamNameEnum.DOTA_TEAM_GOODGUYS)]
		public TeamNameEnum TeamName
		{
			get
			{
				KeyValue kv = GetSubkey("TeamName");
				return (kv == null ? TeamNameEnum.DOTA_TEAM_GOODGUYS : kv.GetEnum<TeamNameEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("TeamName");
				if(kv == null)
				{
					kv = new KeyValue("TeamName");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum CombatClassAttackEnum
		{
			DOTA_COMBAT_CLASS_ATTACK_HERO,
			DOTA_COMBAT_CLASS_ATTACK_PIERCE,
			DOTA_COMBAT_CLASS_ATTACK_BASIC,
			DOTA_COMBAT_CLASS_ATTACK_SIEGE,
			DOTA_COMBAT_CLASS_ATTACK_LIGHT,
		}

		[Category("Team")]
		[Description("Damage type")]
		[DefaultValue(CombatClassAttackEnum.DOTA_COMBAT_CLASS_ATTACK_HERO)]
		public CombatClassAttackEnum CombatClassAttack
		{
			get
			{
				KeyValue kv = GetSubkey("CombatClassAttack");
				return (kv == null ? CombatClassAttackEnum.DOTA_COMBAT_CLASS_ATTACK_HERO : kv.GetEnum<CombatClassAttackEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("CombatClassAttack");
				if(kv == null)
				{
					kv = new KeyValue("CombatClassAttack");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum CombatClassDefendEnum
		{
			DOTA_COMBAT_CLASS_DEFEND_HERO,
			DOTA_COMBAT_CLASS_DEFEND_SOFT,
			DOTA_COMBAT_CLASS_DEFEND_STRUCTURE,
			DOTA_COMBAT_CLASS_DEFEND_STRONG,
			DOTA_COMBAT_CLASS_DEFEND_BASIC,
			DOTA_COMBAT_CLASS_DEFEND_WEAK,
		}

		[Category("Team")]
		[Description("Armor type.")]
		[DefaultValue(CombatClassDefendEnum.DOTA_COMBAT_CLASS_DEFEND_HERO)]
		public CombatClassDefendEnum CombatClassDefend
		{
			get
			{
				KeyValue kv = GetSubkey("CombatClassDefend");
				return (kv == null ? CombatClassDefendEnum.DOTA_COMBAT_CLASS_DEFEND_HERO : kv.GetEnum<CombatClassDefendEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("CombatClassDefend");
				if(kv == null)
				{
					kv = new KeyValue("CombatClassDefend");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		public enum UnitRelationshipClassEnum
		{
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_DEFAULT,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_BUILDING,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_BARRACKS,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_SIEGE,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_WARD,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_COURIER,
			DOTA_NPC_UNIT_RELATIONSHIP_TYPE_HERO,
		}

		[Category("Team")]
		[Description("Unit type")]
		[DefaultValue(UnitRelationshipClassEnum.DOTA_NPC_UNIT_RELATIONSHIP_TYPE_HERO)]
		public UnitRelationshipClassEnum UnitRelationshipClass
		{
			get
			{
				KeyValue kv = GetSubkey("UnitRelationshipClass");
				return (kv == null ? UnitRelationshipClassEnum.DOTA_NPC_UNIT_RELATIONSHIP_TYPE_HERO : kv.GetEnum<UnitRelationshipClassEnum>());
			}
			set
			{
				KeyValue kv = GetSubkey("UnitRelationshipClass");
				if(kv == null)
				{
					kv = new KeyValue("UnitRelationshipClass");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Vision")]
		[Description("Range of vision during the day.")]
		[DefaultValue(1800)]
		public int VisionDaytimeRange
		{
			get
			{
				KeyValue kv = GetSubkey("VisionDaytimeRange");
				return (kv == null ? 1800 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("VisionDaytimeRange");
				if(kv == null)
				{
					kv = new KeyValue("VisionDaytimeRange");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Vision")]
		[Description("Range of vision at night time.")]
		[DefaultValue(800)]
		public int VisionNighttimeRange
		{
			get
			{
				KeyValue kv = GetSubkey("VisionNighttimeRange");
				return (kv == null ? 800 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("VisionNighttimeRange");
				if(kv == null)
				{
					kv = new KeyValue("VisionNighttimeRange");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Inventory")]
		[Description("Enables inventory.")]
		[DefaultValue(true)]
		public bool HasInventory
		{
			get
			{
				KeyValue kv = GetSubkey("HasInventory");
				return (kv == null ? true : kv.GetBool());
			}
			set
			{
				KeyValue kv = GetSubkey("HasInventory");
				if(kv == null)
				{
					kv = new KeyValue("HasInventory");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Bounds")]
		[Description("No Description Set")]
		[DefaultValue(-1)]
		public int HealthBarOffset
		{
			get
			{
				KeyValue kv = GetSubkey("HealthBarOffset");
				return (kv == null ? -1 : kv.GetInt());
			}
			set
			{
				KeyValue kv = GetSubkey("HealthBarOffset");
				if(kv == null)
				{
					kv = new KeyValue("HealthBarOffset");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Idle")]
		[Description("Sound played when the unit is idle.")]
		[DefaultValue("")]
		public string IdleSoundLoop
		{
			get
			{
				KeyValue kv = GetSubkey("IdleSoundLoop");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("IdleSoundLoop");
				if(kv == null)
				{
					kv = new KeyValue("IdleSoundLoop");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
