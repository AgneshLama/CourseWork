﻿#pragma checksum "..\..\Report.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D26792D20E636B87256C2051A4ED0425"
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


namespace StudentInformationSystem {
    
    
    /// <summary>
    /// Report
    /// </summary>
    public partial class Report : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridReport;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateByName;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateByDate;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateReport;
        
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
            System.Uri resourceLocater = new System.Uri("/StudentInformationSystem;component/report.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Report.xaml"
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
            this.DataGridReport = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnGenerateByName = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\Report.xaml"
            this.btnGenerateByName.Click += new System.Windows.RoutedEventHandler(this.btnGenerate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Report.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnGenerateByDate = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Report.xaml"
            this.btnGenerateByDate.Click += new System.Windows.RoutedEventHandler(this.btnGenerateByDate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGenerateReport = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Report.xaml"
            this.btnGenerateReport.Click += new System.Windows.RoutedEventHandler(this.btnGenerateReport_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

