﻿#pragma checksum "..\..\TransactionManagementPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D71CA8D0AC1D0BFBE51F60BDFAE4535F0E0FAD0153388FFA754804CF816DA749"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace LMS {
    
    
    /// <summary>
    /// TransactionManagementPage
    /// </summary>
    public partial class TransactionManagementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AvailableBooksListBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker CheckoutDatePicker;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DueDatePicker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CheckedOutBooksListBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\TransactionManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OverdueFeesDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS;component/transactionmanagementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransactionManagementPage.xaml"
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
            this.PatronNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AvailableBooksListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.CheckoutDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DueDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            
            #line 33 "..\..\TransactionManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CheckoutBook_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CheckedOutBooksListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            
            #line 41 "..\..\TransactionManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReturnBook_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 48 "..\..\TransactionManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewOverdueFees_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.OverdueFeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
