//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace MinecraftClient {


    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    public class DefaultConfigResource {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DefaultConfigResource() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("MinecraftClient.DefaultConfigResource", typeof(DefaultConfigResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 # Minecraft Console Client v1.16.3
        ///# Startup Config File
        ///
        ///[Main]
        ///
        ///# General settings
        ///# Leave blank to prompt user on startup
        ///# Use &quot;-&quot; as password for offline mode
        ///
        ///login=
        ///password=
        ///serverip=
        ///
        ///# Advanced settings
        ///
        ///language=en_GB
        ///consoletitle=%username%@%serverip% - Minecraft Console Client
        ///internalcmdchar=slash              # Use &apos;none&apos;, &apos;slash&apos; or &apos;backslash&apos;
        ///splitmessagedelay=2                # Seconds between each part of a long message
        ///botowners=Player1,Player2,Player3  # Name list or [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        public static string MinecraftClient {
            get {
                return ResourceManager.GetString("MinecraftClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 [mcc]
        ///# Messages from MCC itself
        ///mcc.description=Console Client for MC {0} to {1} - v{2} - By ORelio &amp; Contributors
        ///mcc.keyboard_debug=Keyboard debug mode: Press any key to display info
        ///mcc.setting=Loading Settings from {0}
        ///mcc.login=Login :
        ///mcc.login_basic_io=Please type the username or email of your choice.
        ///mcc.password=Password : 
        ///mcc.password_basic_io=Please type the password for {0}.
        ///mcc.password_hidden=Password : {0}
        ///mcc.offline=§8You chose to run in offline mode.
        ///mcc.session_invalid=§8Cach [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        public static string TranslationEnglish {
            get {
                return ResourceManager.GetString("TranslationEnglish", resourceCulture);
            }
        }
    }
}
