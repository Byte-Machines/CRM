﻿#pragma checksum "..\..\CRM_Main_Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F6FC41291D9BB185BD64E3CA223C89BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CRM_User_Interface {
    
    
    /// <summary>
    /// Main_Login
    /// </summary>
    public partial class Main_Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_MainLogin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtloginid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtpassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnlogin;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnclear;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CRM_Main_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnexit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CRM_User_Interface;component/crm_main_login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CRM_Main_Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid_MainLogin = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtloginid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtpassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.btnlogin = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\CRM_Main_Login.xaml"
            this.btnlogin.Click += new System.Windows.RoutedEventHandler(this.btnlogin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnclear = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnexit = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\CRM_Main_Login.xaml"
            this.btnexit.Click += new System.Windows.RoutedEventHandler(this.btnexit_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

