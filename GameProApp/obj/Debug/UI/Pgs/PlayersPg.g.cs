﻿#pragma checksum "..\..\..\..\UI\Pgs\PlayersPg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3258F824352BEA0AAB2FEF8E6CCA8447E4276F1F962A32AE28044B797D07FA9E"
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
    /// PlayersPg
    /// </summary>
    public partial class PlayersPg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchPlayer;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid filtersPlayers;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCountries;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboPositions;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPlayers;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbNoResults;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel adminBtns;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
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
            System.Uri resourceLocater = new System.Uri("/GameProApp;component/ui/pgs/playerspg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
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
            this.tbSearchPlayer = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.tbSearchPlayer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearchPlayer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.filtersPlayers = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.comboCountries = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.comboCountries.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboCountries_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboPositions = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.comboPositions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboPositions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvPlayers = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.tbNoResults = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.adminBtns = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\UI\Pgs\PlayersPg.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

