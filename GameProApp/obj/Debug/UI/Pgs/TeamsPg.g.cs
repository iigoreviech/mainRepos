﻿#pragma checksum "..\..\..\..\UI\Pgs\TeamsPg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "275096D5DC56EFEB81CCC921B10F0C7061451D4FD15DF136410796A386F58FED"
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
    /// TeamsPg
    /// </summary>
    public partial class TeamsPg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchTeams;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTeams;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbNoResults;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel adminBtns;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/GameProApp;component/ui/pgs/teamspg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
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
            this.tbSearchTeams = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
            this.tbSearchTeams.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearchTeams_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvTeams = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.tbNoResults = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.adminBtns = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UI\Pgs\TeamsPg.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

