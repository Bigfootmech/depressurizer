﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depressurizer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Depressurizer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0}\appcache\appinfo.vdf.
        /// </summary>
        internal static string AppInfoPath {
            get {
                return ResourceManager.GetString("AppInfoPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\userdata\{1}\7\remote\sharedconfig.vdf.
        /// </summary>
        internal static string ConfigFilePath {
            get {
                return ResourceManager.GetString("ConfigFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\steamapps\appmanifest_{1}.acf.
        /// </summary>
        internal static string GameConfigFilePath {
            get {
                return ResourceManager.GetString("GameConfigFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\userdata\{1}\config\localconfig.vdf.
        /// </summary>
        internal static string LocalConfigPath {
            get {
                return ResourceManager.GetString("LocalConfigPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\appcache\packageinfo.vdf.
        /// </summary>
        internal static string PackageInfoPath {
            get {
                return ResourceManager.GetString("PackageInfoPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\userdata\{1}\760\screenshots.vdf.
        /// </summary>
        internal static string ScreenshotsFilePath {
            get {
                return ResourceManager.GetString("ScreenshotsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}\userdata\{1}\config\shortcuts.vdf.
        /// </summary>
        internal static string ShortCutsFilePath {
            get {
                return ResourceManager.GetString("ShortCutsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://steamcommunity.com/id/{0}/games?tab=all.
        /// </summary>
        internal static string UrlCustomGameListHtml {
            get {
                return ResourceManager.GetString("UrlCustomGameListHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://steamcommunity.com/id/{0}/games?tab=all&amp;xml=1.
        /// </summary>
        internal static string UrlCustomGameListXml {
            get {
                return ResourceManager.GetString("UrlCustomGameListXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://steamcommunity.com/id/{0}?xml=1.
        /// </summary>
        internal static string UrlCustomProfileXml {
            get {
                return ResourceManager.GetString("UrlCustomProfileXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://steamcommunity.com/profiles/{0}/games?tab=all.
        /// </summary>
        internal static string UrlGameListHtml {
            get {
                return ResourceManager.GetString("UrlGameListHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://steamcommunity.com/profiles/{0}/games?tab=all&amp;xml=1.
        /// </summary>
        internal static string UrlGameListXml {
            get {
                return ResourceManager.GetString("UrlGameListXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://store.steampowered.com/app/{0}/.
        /// </summary>
        internal static string UrlSteamStore {
            get {
                return ResourceManager.GetString("UrlSteamStore", resourceCulture);
            }
        }
    }
}
