﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.StudyManagement.Core {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class FileManagementSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static FileManagementSettings defaultInstance = ((FileManagementSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FileManagementSettings())));
        
        public static FileManagementSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Configures how the viewer services are optimized when handling files in the filestore.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Configures how the viewer services are optimized when handling files in the files" +
            "tore.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Performance")]
        public global::ClearCanvas.ImageViewer.StudyManagement.Core.FileProcessingDisposition FileProcessingDisposition {
            get {
                return ((global::ClearCanvas.ImageViewer.StudyManagement.Core.FileProcessingDisposition)(this["FileProcessingDisposition"]));
            }
        }
    }
}
