﻿#pragma checksum "..\..\InfoUsuario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1811AAC4BFA55ADF91122B29AC2322DE6C1D5E951B597E66BC78D0A3C06EBEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Frigot;
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


namespace Frigot {
    
    
    /// <summary>
    /// InfoUsuario
    /// </summary>
    public partial class InfoUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\InfoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAlergia;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\InfoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btEje;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InfoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAlergia;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InfoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReg;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InfoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/Frigot;component/infousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoUsuario.xaml"
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
            
            #line 8 "..\..\InfoUsuario.xaml"
            ((Frigot.InfoUsuario)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbAlergia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btEje = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\InfoUsuario.xaml"
            this.btEje.Click += new System.Windows.RoutedEventHandler(this.btEje_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgAlergia = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btReg = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\InfoUsuario.xaml"
            this.btReg.Click += new System.Windows.RoutedEventHandler(this.btReg_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbUsuario = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

