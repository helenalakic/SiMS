﻿#pragma checksum "..\..\CreateMedicine.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28F7C12392BFA3EFB4FB3BCCA5DEB6F3385F7EE7082EEE8C5C5D3A6C7C5FD26F"
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
    /// CreateMedicine
    /// </summary>
    public partial class CreateMedicine : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox medicineId;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox medicineName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox manufacturer;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantityInStock;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\CreateMedicine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SiMSProject;component/createmedicine.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateMedicine.xaml"
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
            
            #line 14 "..\..\CreateMedicine.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignOut);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\CreateMedicine.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToMedicines);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\CreateMedicine.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToRegistration);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\CreateMedicine.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToAllUsers);
            
            #line default
            #line hidden
            return;
            case 5:
            this.medicineId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.medicineName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.manufacturer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.quantityInStock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.SubmitButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\CreateMedicine.xaml"
            this.SubmitButton.Click += new System.Windows.RoutedEventHandler(this.ClickToCreateMedicine);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

