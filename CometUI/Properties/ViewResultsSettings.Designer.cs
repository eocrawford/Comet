﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CometUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    public sealed partial class ViewResultsSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ViewResultsSettings defaultInstance = ((ViewResultsSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ViewResultsSettings())));
        
        public static ViewResultsSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int DisplayOptionsRowsPerPage {
            get {
                return ((int)(this["DisplayOptionsRowsPerPage"]));
            }
            set {
                this["DisplayOptionsRowsPerPage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("spectrum")]
        public string DisplayOptionsSortByColumn {
            get {
                return ((string)(this["DisplayOptionsSortByColumn"]));
            }
            set {
                this["DisplayOptionsSortByColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayOptionsInlcudeModsWhenHighlightingPeptides {
            get {
                return ((bool)(this["DisplayOptionsInlcudeModsWhenHighlightingPeptides"]));
            }
            set {
                this["DisplayOptionsInlcudeModsWhenHighlightingPeptides"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisplayOptionsCondensedColumnHeaders {
            get {
                return ((bool)(this["DisplayOptionsCondensedColumnHeaders"]));
            }
            set {
                this["DisplayOptionsCondensedColumnHeaders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>probability</string>
  <string>index</string>
  <string>assumed_charge</string>
  <string>precursor_neutral_mass</string>
  <string>MZratio</string>
  <string>protein_descr</string>
  <string>pI</string>
  <string>retention_time_sec</string>
  <string>precursor_intensity</string>
  <string>ppm</string>
  <string>xcorr</string>
  <string>deltacn</string>
  <string>deltacnstar</string>
  <string>spscore</string>
  <string>sprank</string>
  <string>massdiff</string>
  <string>xpress</string>
  <string>q-value</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection PickColumnsHideList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PickColumnsHideList"]));
            }
            set {
                this["PickColumnsHideList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>spectrum</string>
  <string>start_scan</string>
  <string>expect</string>
  <string>ions</string>
  <string>peptide</string>
  <string>protein</string>
  <string>calc_neutral_pep_mass</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection PickColumnsShowList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PickColumnsShowList"]));
            }
            set {
                this["PickColumnsShowList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisplayOptionsSortAscending {
            get {
                return ((bool)(this["DisplayOptionsSortAscending"]));
            }
            set {
                this["DisplayOptionsSortAscending"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowOptions {
            get {
                return ((bool)(this["ShowOptions"]));
            }
            set {
                this["ShowOptions"] = value;
            }
        }
    }
}
