﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerScada.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Kullanici {
            get {
                return ((string)(this["Kullanici"]));
            }
            set {
                this["Kullanici"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Sifre {
            get {
                return ((string)(this["Sifre"]));
            }
            set {
                this["Sifre"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BeniHatirla {
            get {
                return ((bool)(this["BeniHatirla"]));
            }
            set {
                this["BeniHatirla"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Connection {
            get {
                return ((string)(this["Connection"]));
            }
            set {
                this["Connection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Database=PowerScada;Persist Security Info=True;User ID=ahbspass2010;Password=1122" +
            "")]
        public string uzakahbs {
            get {
                return ((string)(this["uzakahbs"]));
            }
            set {
                this["uzakahbs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=.;Initial Catalog=PowerScada;Persist Security Info=True;Integrated Securit" +
            "y=true")]
        public string localahbs {
            get {
                return ((string)(this["localahbs"]));
            }
            set {
                this["localahbs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=.\\SQLEXPRESS;Initial Catalog=PowerScada;Persist Security Info=True;integra" +
            "ted security=true;")]
        public string localahbsexp {
            get {
                return ((string)(this["localahbsexp"]));
            }
            set {
                this["localahbsexp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=master;Persist Security Info=True;integrated securi" +
            "ty=true;")]
        public string localmaster {
            get {
                return ((string)(this["localmaster"]));
            }
            set {
                this["localmaster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;integr" +
            "ated security=true;")]
        public string localmasterexp {
            get {
                return ((string)(this["localmasterexp"]));
            }
            set {
                this["localmasterexp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\SQLEXPRESS")]
        public string anamakina {
            get {
                return ((string)(this["anamakina"]));
            }
            set {
                this["anamakina"] = value;
            }
        }
    }
}