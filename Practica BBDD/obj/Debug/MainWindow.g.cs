﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3CFF2BB9A5366AC41821B2908B5BE26C753E73F9DDAC65C850A0BB45CDDAB428"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_BBDD;
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


namespace Practica_BBDD {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridTitulo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titulo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listaAlumnos;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listaProfesores;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listaMaterias;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button agregarAlumno;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button agregarMateria;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button agregarProfesor;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrarAlumno;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrarProfesor;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrarMateria;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modificarMateria;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica BBDD;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 9 "..\..\MainWindow.xaml"
            ((Practica_BBDD.MainWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridTitulo = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.listaAlumnos = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.listaProfesores = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.listaMaterias = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.agregarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\MainWindow.xaml"
            this.agregarAlumno.Click += new System.Windows.RoutedEventHandler(this.agregarAlumno_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.agregarMateria = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\MainWindow.xaml"
            this.agregarMateria.Click += new System.Windows.RoutedEventHandler(this.agregarMateria_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.agregarProfesor = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\MainWindow.xaml"
            this.agregarProfesor.Click += new System.Windows.RoutedEventHandler(this.agregarProfesor_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.borrarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\MainWindow.xaml"
            this.borrarAlumno.Click += new System.Windows.RoutedEventHandler(this.borrarAlumno_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.borrarProfesor = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\MainWindow.xaml"
            this.borrarProfesor.Click += new System.Windows.RoutedEventHandler(this.borrarProfesor_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.borrarMateria = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\MainWindow.xaml"
            this.borrarMateria.Click += new System.Windows.RoutedEventHandler(this.borrarMateria_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.modificarMateria = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\MainWindow.xaml"
            this.modificarMateria.Click += new System.Windows.RoutedEventHandler(this.modificarMateria_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

