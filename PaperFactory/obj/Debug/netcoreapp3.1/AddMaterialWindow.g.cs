#pragma checksum "..\..\..\AddMaterialWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E69EF973463CA3D60BF677951E96B6D93A7FFF2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PaperFactory;
using System;
using System.Collections;
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


namespace PaperFactory {
    
    
    /// <summary>
    /// AddMaterialWindow
    /// </summary>
    public partial class AddMaterialWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PreviewImage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialTypeTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinWarehouseAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentWarehouseAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountInPackTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MetricTypeTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImageTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenPhotoButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DefaultPhotoButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SuppliersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Supplier;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn AddSupplier;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\AddMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PaperFactory;component/addmaterialwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddMaterialWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\AddMaterialWindow.xaml"
            ((PaperFactory.AddMaterialWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PreviewImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.MaterialNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MaterialNameTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MaterialNameTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaterialTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialTypeTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MaterialTypeTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialTypeTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MaterialTypeTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MaterialPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialPriceTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MaterialPriceTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\AddMaterialWindow.xaml"
            this.MaterialPriceTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MaterialPriceTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MinWarehouseAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\AddMaterialWindow.xaml"
            this.MinWarehouseAmountTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MinWarehouseAmountTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\AddMaterialWindow.xaml"
            this.MinWarehouseAmountTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MinWarehouseAmountTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CurrentWarehouseAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\AddMaterialWindow.xaml"
            this.CurrentWarehouseAmountTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.CurrentWarehouseAmountTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\AddMaterialWindow.xaml"
            this.CurrentWarehouseAmountTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.CurrentWarehouseAmountTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AmountInPackTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\AddMaterialWindow.xaml"
            this.AmountInPackTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.AmountInPackTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\AddMaterialWindow.xaml"
            this.AmountInPackTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AmountInPackTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MetricTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\AddMaterialWindow.xaml"
            this.MetricTypeTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MetricTypeTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\AddMaterialWindow.xaml"
            this.MetricTypeTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MetricTypeTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ImageTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\AddMaterialWindow.xaml"
            this.ImageTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ImageTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.OpenPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\AddMaterialWindow.xaml"
            this.OpenPhotoButton.Click += new System.Windows.RoutedEventHandler(this.OpenPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DefaultPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\AddMaterialWindow.xaml"
            this.DefaultPhotoButton.Click += new System.Windows.RoutedEventHandler(this.DefaultPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.SuppliersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 14:
            this.Supplier = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.AddSupplier = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            case 17:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\AddMaterialWindow.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\AddMaterialWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 16:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.ToggleButton.CheckedEvent;
            
            #line 50 "..\..\..\AddMaterialWindow.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

