﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasikJS.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BasikJS.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [bold green]console[/].[bold yellow]log[/](...args: [bold yellow]Array&lt;any&gt;[/])
        ///
        ///[yellow]&lt;Sync Method&gt;[/] [green]&lt;Stable&gt;[/] [green]&lt;Safe&gt;[/] &lt;Last Updated: v0.0.1&gt;
        ///
        ///Prints a variable to the console..
        /// </summary>
        internal static string Guide_console_log {
            get {
                return ResourceManager.GetString("Guide_console_log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [bold fuchsia]Basik[/].[bold green]pipelines[/].[bold yellow]createCommand[/]()
        ///
        ///[yellow]&lt;Sync Method&gt;[/] [yellow]&lt;Unstable&gt;[/] [red]&lt;Unsafe&gt;[/] &lt;Last Updated: v0.0.1&gt;
        ///
        ///Creates a command object that can be used to execute external shell tasks asynchronously.
        ///
        ///[bold fuchsia]Command[/].[bold green]run[/](entrypoint: [bold yellow]string[/], args: [bold yellow]Array&lt;string&gt;[/])
        ///
        ///[green]&lt;Async Method&gt;[/] [yellow]&lt;Unstable&gt;[/] [red]&lt;Unsafe&gt;[/] &lt;Last Updated: v0.0.1&gt;
        ///
        ///Runs an arbitrary command and return [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Guide_pipelines_createCommand {
            get {
                return ResourceManager.GetString("Guide_pipelines_createCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [bold fuchsia]Basik[/].[bold green]workers[/].[bold yellow]getShared[/]()
        ///
        ///[yellow]&lt;Sync Method&gt;[/] [green]&lt;Stable&gt;[/] [red]&lt;Unsafe&gt;[/] &lt;Last Updated: v0.0.1&gt;
        ///
        ///Provides access to the workers global shared object. Is stored inside the CLR application.
        ///Only a single instance of the shared object will exist per application..
        /// </summary>
        internal static string Guide_workers_getShared {
            get {
                return ResourceManager.GetString("Guide_workers_getShared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [bold fuchsia]Basik[/].[bold green]workers[/].[bold yellow]setShared[/](key: [bold yellow]string[/], value: [bold yellow]any[/])
        ///
        ///[yellow]&lt;Sync Method&gt;[/] [green]&lt;Stable&gt;[/] [red]&lt;Unsafe&gt;[/] &lt;Last Updated: v0.0.1&gt;
        ///
        ///Sets any value inside the workers global shared object. Not thread safe..
        /// </summary>
        internal static string Guide_workers_setShared {
            get {
                return ResourceManager.GetString("Guide_workers_setShared", resourceCulture);
            }
        }
    }
}
