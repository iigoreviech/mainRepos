﻿#pragma checksum "..\..\..\..\UI\Wnds\AuthWnd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51D01D15DBB36B223E00090FA3D759DCBD88805F8A10D8F6534DFF980EE6559D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameProApp;
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


namespace GameProApp {
    
    
    /// <summary>
    /// AuthWnd
    /// </summary>
    public partial class AuthWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ToolBar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnSvernut;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnExit;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VisiblePasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton TogglePasswordButton;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShowPasswordImage;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Watermark;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/GameProApp;component/ui/wnds/authwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
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
            this.ToolBar = ((System.Windows.Controls.Grid)(target));
            
            #line 23 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.ToolBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSvernut = ((System.Windows.Controls.Image)(target));
            
            #line 30 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.btnSvernut.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnSvernut_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnExit = ((System.Windows.Controls.Image)(target));
            
            #line 46 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.btnExit.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnExit_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 64 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 94 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.tbPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.tbPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.VisiblePasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TogglePasswordButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 98 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.TogglePasswordButton.Click += new System.Windows.RoutedEventHandler(this.TogglePasswordButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ShowPasswordImage = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.Watermark = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\..\UI\Wnds\AuthWnd.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
