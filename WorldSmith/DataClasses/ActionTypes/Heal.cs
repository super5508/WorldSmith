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
	[DotaAction]
	[EditorGrammar("Heal %Target for %HealAmount hitpoints")]
	public partial class Heal : TargetedAction
	{
		public Heal(KeyValue kv)
			: base(kv)
		{
		}
		public Heal(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string HealAmount
		{
			get
			{
				KeyValue kv = GetSubkey("HealAmount");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("HealAmount");
				if(kv == null)
				{
					kv = new KeyValue("HealAmount");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
