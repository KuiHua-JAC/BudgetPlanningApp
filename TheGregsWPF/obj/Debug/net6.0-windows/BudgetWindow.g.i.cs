﻿#pragma checksum "..\..\..\BudgetWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEFD974C367EEAFAA18E4C4F4819D9D38A78098A"
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
using TheGregsWPF;


namespace TheGregsWPF {
    
    
    /// <summary>
    /// BudgetWindow
    /// </summary>
    public partial class BudgetWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbDbPath;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel budgetContainer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLog;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerStart;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerEnd;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox summarizeByCategoryCheckbox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox summarizeByMonthCheckbox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chckBoxFilter;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCategories;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewCategory;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewExpense;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SearchBar;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearch;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrevious;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\BudgetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBudgetItems;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TheGregsWPF;V1.0.0.0;component/budgetwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BudgetWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\BudgetWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNewDatabase_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\BudgetWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSelectDatabase_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbDbPath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.budgetContainer = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 5:
            this.txbLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.datePickerStart = ((System.Windows.Controls.DatePicker)(target));
            
            #line 29 "..\..\..\BudgetWindow.xaml"
            this.datePickerStart.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.datePickerEnd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 32 "..\..\..\BudgetWindow.xaml"
            this.datePickerEnd.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.summarizeByCategoryCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 43 "..\..\..\BudgetWindow.xaml"
            this.summarizeByCategoryCheckbox.Checked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\BudgetWindow.xaml"
            this.summarizeByCategoryCheckbox.Unchecked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.summarizeByMonthCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 48 "..\..\..\BudgetWindow.xaml"
            this.summarizeByMonthCheckbox.Checked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\BudgetWindow.xaml"
            this.summarizeByMonthCheckbox.Unchecked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\BudgetWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.chckBoxFilter = ((System.Windows.Controls.CheckBox)(target));
            
            #line 53 "..\..\..\BudgetWindow.xaml"
            this.chckBoxFilter.Checked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\BudgetWindow.xaml"
            this.chckBoxFilter.Unchecked += new System.Windows.RoutedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.cmbCategories = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\BudgetWindow.xaml"
            this.cmbCategories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.handleSummaryChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnNewCategory = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\BudgetWindow.xaml"
            this.btnNewCategory.Click += new System.Windows.RoutedEventHandler(this.btnNewCategory_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnNewExpense = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\BudgetWindow.xaml"
            this.btnNewExpense.Click += new System.Windows.RoutedEventHandler(this.btnNewExpense_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.SearchBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.txbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\BudgetWindow.xaml"
            this.txbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\BudgetWindow.xaml"
            this.btnPrevious.Click += new System.Windows.RoutedEventHandler(this.btnPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\BudgetWindow.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.dataGridBudgetItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 88 "..\..\..\BudgetWindow.xaml"
            this.dataGridBudgetItems.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGridBudgetItems_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

