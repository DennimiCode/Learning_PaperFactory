﻿#pragma checksum "..\..\..\..\Controls\MaterialControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBB22ED3258B9D6F0B49133551C2782AC02E79DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PaperFactory.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PaperFactory.Controls {
    
    
    /// <summary>
    /// MaterialControl
    /// </summary>
    public partial class MaterialControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ControlGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MaterialImage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TypeNameMaterialLable;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MinAmountLable;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SuppliersLable;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AmountLable;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controls\MaterialControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PriceLable;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PaperFactory;component/controls/materialcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\MaterialControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ControlGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\..\..\Controls\MaterialControl.xaml"
            this.ControlGrid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ControlGrid_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Controls\MaterialControl.xaml"
            this.ControlGrid.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ControlGrid_MouseLeave);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Controls\MaterialControl.xaml"
            this.ControlGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ControlGrid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MaterialImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.TypeNameMaterialLable = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MinAmountLable = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.SuppliersLable = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.AmountLable = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.PriceLable = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

