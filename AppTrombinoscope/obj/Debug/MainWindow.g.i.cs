﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E3BC26E46686F2ED91CEC5C0BCAA9461574D44B7CC65458CA23CBEAC8557E59D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppTrombinoscope;
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


namespace AppTrombinoscope {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ConnexionBDDItemMenu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListePersonnelItemMenu;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GestionServiceItemMenu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GestionFonctionItemMenu;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GestionPersonnelItemMenu;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GestionnaireItemMenu;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ParametreBDDItemMenu;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ServiceView;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView FonctionView;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MembresView;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServiceTB;
        
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
            System.Uri resourceLocater = new System.Uri("/AppTrombinoscope;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.ConnexionBDDItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.ConnexionBDDItemMenu.Click += new System.Windows.RoutedEventHandler(this.ConnexionBDDItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListePersonnelItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.ListePersonnelItemMenu.Click += new System.Windows.RoutedEventHandler(this.ListePersonnelItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GestionServiceItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.GestionServiceItemMenu.Click += new System.Windows.RoutedEventHandler(this.GestionServiceItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GestionFonctionItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.GestionFonctionItemMenu.Click += new System.Windows.RoutedEventHandler(this.GestionFonctionItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GestionPersonnelItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.GestionPersonnelItemMenu.Click += new System.Windows.RoutedEventHandler(this.GestionPersonnelItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GestionnaireItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.GestionnaireItemMenu.Click += new System.Windows.RoutedEventHandler(this.GestionnaireItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ParametreBDDItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.ParametreBDDItemMenu.Click += new System.Windows.RoutedEventHandler(this.ParametreBDDItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ServiceView = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.FonctionView = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.MembresView = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.ServiceTB = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

