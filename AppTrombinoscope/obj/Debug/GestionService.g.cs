﻿#pragma checksum "..\..\GestionService.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7052A74C7462A79D3C2EDF11B507D73F3E7E99AE0C5BEDC9F8C3015E663A779E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace AppTrombinoscope {
    
    
    /// <summary>
    /// GestionService
    /// </summary>
    public partial class GestionService : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListeService;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServiceAddNameTb;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AjouterBt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifierBt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupprimerBt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameModificationTb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ValiderBt;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GestionService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitterBt;
        
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
            System.Uri resourceLocater = new System.Uri("/AppTrombinoscope;component/gestionservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionService.xaml"
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
            this.ListeService = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ServiceAddNameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AjouterBt = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\GestionService.xaml"
            this.AjouterBt.Click += new System.Windows.RoutedEventHandler(this.AjouterBt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ModifierBt = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.SupprimerBt = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.NameModificationTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ValiderBt = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.QuitterBt = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

