﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrightcoveBulkTranscode {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Brightcove : global::System.Configuration.ApplicationSettingsBase {
        
        private static Brightcove defaultInstance = ((Brightcove)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Brightcove())));
        
        public static Brightcove Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourAccountNumber")]
        public string AccountNumber {
            get {
                return ((string)(this["AccountNumber"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourClientKey")]
        public string Client {
            get {
                return ((string)(this["Client"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourClientSecret")]
        public string ClientSecret {
            get {
                return ((string)(this["ClientSecret"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourTranscodeProfileName")]
        public string TranscodeProfile {
            get {
                return ((string)(this["TranscodeProfile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://oauth.brightcove.com/v3/access_token")]
        public string AccessTokenUrl {
            get {
                return ((string)(this["AccessTokenUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://cms.api.brightcove.com/v1/accounts/{0}/videos")]
        public string IngressVideoUrl {
            get {
                return ((string)(this["IngressVideoUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourIngressToken")]
        public string IngressToken {
            get {
                return ((string)(this["IngressToken"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.brightcove.com/services/library?command=search_videos&token={0}&video_" +
            "fields=id,name&sort_by=DISPLAY_NAME&get_item_count=true&page_number={1}")]
        public string IngressVideoSearch {
            get {
                return ((string)(this["IngressVideoSearch"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int PageSize {
            get {
                return ((int)(this["PageSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ingest.api.brightcove.com/v1/accounts/{0}/videos/{1}/ingest-requests")]
        public string RetranscodeUrl {
            get {
                return ((string)(this["RetranscodeUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseArchivedMaster {
            get {
                return ((bool)(this["UseArchivedMaster"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YourTranscodeProfileName")]
        public string RetranscodeIngressProfile {
            get {
                return ((string)(this["RetranscodeIngressProfile"]));
            }
        }
    }
}
