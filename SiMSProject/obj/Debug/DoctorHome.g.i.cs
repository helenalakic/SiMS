﻿#pragma checksum "..\..\DoctorHome.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E13706CCE8A56F4C9CF1E0E560F3FD49FEFF9775AA45CB9A05B7A52C47009DCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SiMSProject;
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


namespace SiMSProject {
    
    
    /// <summary>
    /// DoctorHome
    /// </summary>
    public partial class DoctorHome : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSort;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxMin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxMax;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchPrice_btn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridMedicines;
        
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
            System.Uri resourceLocater = new System.Uri("/SiMSProject;component/doctorhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DoctorHome.xaml"
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
            
            #line 14 "..\..\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignOut);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToMedicinesPendingApproval);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboBoxSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\DoctorHome.xaml"
            this.ComboBoxSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortBy);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxMin = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\DoctorHome.xaml"
            this.TextBoxMin.GotFocus += new System.Windows.RoutedEventHandler(this.textBoxMin_GetFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\DoctorHome.xaml"
            this.TextBoxMin.LostFocus += new System.Windows.RoutedEventHandler(this.textBoxMin_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBoxMax = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\DoctorHome.xaml"
            this.TextBoxMax.GotFocus += new System.Windows.RoutedEventHandler(this.textBoxMax_GetFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\DoctorHome.xaml"
            this.TextBoxMax.LostFocus += new System.Windows.RoutedEventHandler(this.textBoxMax_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchPrice_btn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\DoctorHome.xaml"
            this.SearchPrice_btn.Click += new System.Windows.RoutedEventHandler(this.SearchByPrice);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\DoctorHome.xaml"
            this.TextBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboBoxSearch = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\DoctorHome.xaml"
            this.ComboBoxSearch.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSearchByChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridMedicines = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 67 "..\..\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IngredientsButton);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

