﻿#pragma checksum "..\..\PharmacistHome.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9FB858AA9C724818D4B5B501DAA7368DBE5977969F308A46774414BE029A3965"
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
    /// PharmacistHome
    /// </summary>
    public partial class PharmacistHome : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\PharmacistHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSort;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PharmacistHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\PharmacistHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\PharmacistHome.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SiMSProject;component/pharmacisthome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PharmacistHome.xaml"
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
            
            #line 14 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignOut);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToMedicinesPendingApproval);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToAcceptedMedicines);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToRefusedMedicines);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBoxSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\PharmacistHome.xaml"
            this.ComboBoxSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortBy);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\PharmacistHome.xaml"
            this.TextBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboBoxSearch = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 49 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenMedicalRecord);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 50 "..\..\PharmacistHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenIssuePrescripption);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dataGridMedicines = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

