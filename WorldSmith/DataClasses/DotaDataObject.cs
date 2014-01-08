﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVLib;
using System.ComponentModel;
using System.Reflection;

namespace WorldSmith.DataClasses
{
    class DotaDataObject : ICloneable
    {       
        [Category("Base")]
        [Description("Class name for this object")]
        public string ClassName
        {
            get;
            set;
        }

        [Category("Base")]
        [Description("Class name for this object")]
        public string BaseClass
        {
            get;
            set;
        }        

        public virtual void LoadFromKeyValues(KeyValue kv)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            ClassName = kv.Key;

            foreach(PropertyInfo info in properties)
            {
                if (info.Name == "ClassName") continue;
                if (info.Name == "WasModified") continue;

                KeyValue subkey = kv[info.Name];
                if(subkey == null || subkey.HasChildren) continue;

                object data = null;
                if(info.PropertyType == typeof(int))
                {
                    data = subkey.GetInt();
                }
                if(info.PropertyType == typeof(float))
                {
                    data = subkey.GetFloat();
                }
                if(info.PropertyType == typeof(bool))
                {
                    data = subkey.GetBool();
                }
                if(info.PropertyType == typeof(string))
                {
                    data = subkey.GetString();
                }
                if(data != null) info.SetMethod.Invoke(this, new object[] { data });

            } 
        }

        public virtual KeyValue SaveToKV()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            KeyValue kv = new KeyValue(ClassName);

            foreach (PropertyInfo info in properties)
            {
                if (info.Name == "ClassName") continue;
                if (info.Name == "WasModified") continue;

                KeyValue subkey = new KeyValue(info.Name);
                
                object data = null;
                if (info.PropertyType == typeof(int))
                {
                    data = info.GetMethod.Invoke(this, new object[] { });
                    subkey.Set((int)data);
                }
                if (info.PropertyType == typeof(float))
                {
                    data = info.GetMethod.Invoke(this, new object[] { });
                    subkey.Set((float)data);
                }
                if (info.PropertyType == typeof(bool))
                {
                    data = info.GetMethod.Invoke(this, new object[] { });
                    subkey.Set((bool)data);
                }
                if (info.PropertyType == typeof(string))
                {
                    data = info.GetMethod.Invoke(this, new object[] { });
                    subkey.Set((string)data);
                }
                kv += subkey;

            }

            return kv;

        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}