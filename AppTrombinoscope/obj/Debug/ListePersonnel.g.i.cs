﻿#pragma checksum "..\..\ListePersonnel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ADE30C3ED7629389B22BA412D498D496DF21D2C120FB23B3297C4DD75124DAA"
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
    /// ListePersonnel
    /// </summary>
    public partial class ListePersonnel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ListePersonnel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataList;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ListePersonnel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxNom;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ListePersonnel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxPrenom;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ListePersonnel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxService;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ListePersonnel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxFonction;
        
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
            System.Uri resourceLocater = new System.Uri("/AppTrombinoscope;component/listepersonnel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListePersonnel.xaml"
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
            this.dataList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BoxNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\ListePersonnel.xaml"
            this.BoxNom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BoxNom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BoxPrenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\ListePersonnel.xaml"
            this.BoxPrenom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BoxPrenom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BoxService = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\ListePersonnel.xaml"
            this.BoxService.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BoxService_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BoxFonction = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\ListePersonnel.xaml"
            this.BoxFonction.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BoxFonction_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

