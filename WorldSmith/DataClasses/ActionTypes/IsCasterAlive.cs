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
	[EditorGrammar("If the caster is alive, do %OnSuccess actions.  Else, do %OnFailure actions")]
	public partial class IsCasterAlive : BaseAction
	{
		public IsCasterAlive(KeyValue kv)
			: base(kv)
		{
		}
		public IsCasterAlive(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "Default")]
		public ActionCollection OnSuccess
		{
			get
			{
				return default(ActionCollection);
			}
			set
			{
				KeyValue kv = GetSubkey("OnSuccess");
				if(kv == null)
				{
					kv = new KeyValue("OnSuccess");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "Default")]
		public ActionCollection OnFailure
		{
			get
			{
				return default(ActionCollection);
			}
			set
			{
				KeyValue kv = GetSubkey("OnFailure");
				if(kv == null)
				{
					kv = new KeyValue("OnFailure");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
