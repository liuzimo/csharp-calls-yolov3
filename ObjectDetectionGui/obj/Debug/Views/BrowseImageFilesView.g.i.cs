﻿#pragma checksum "..\..\..\Views\BrowseImageFilesView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65BDA18B139455FFBDAE574340C8DB63D8FD6C47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LogoDetectionGui.Views;
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


namespace LogoDetectionGui.Views {
    
    
    /// <summary>
    /// BrowseImageFilesView
    /// </summary>
    public partial class BrowseImageFilesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\BrowseImageFilesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\BrowseImageFilesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FileBrowseGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\BrowseImageFilesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseImageFilesBt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\BrowseImageFilesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DetectLogoBt;
        
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
            System.Uri resourceLocater = new System.Uri("/LogoDetectionGui;component/views/browseimagefilesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\BrowseImageFilesView.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.FileBrowseGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\Views\BrowseImageFilesView.xaml"
            this.FileBrowseGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FileBrowseGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BrowseImageFilesBt = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\BrowseImageFilesView.xaml"
            this.BrowseImageFilesBt.Click += new System.Windows.RoutedEventHandler(this.BrowseImageFilesBt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DetectLogoBt = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Views\BrowseImageFilesView.xaml"
            this.DetectLogoBt.Click += new System.Windows.RoutedEventHandler(this.DetectLogoBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

