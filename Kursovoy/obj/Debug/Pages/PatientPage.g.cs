﻿#pragma checksum "..\..\..\Pages\PatientPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8096B749827B93D609A189ACFF6F12DD79245DB4E9ABBB3D81323368C2D53AD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kursovoy.Pages;
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


namespace Kursovoy.Pages {
    
    
    /// <summary>
    /// PatientPage
    /// </summary>
    public partial class PatientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSortBy;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearchName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearchPatronymic;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridPatient;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddPatient;
        
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
            System.Uri resourceLocater = new System.Uri("/Kursovoy;component/pages/patientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PatientPage.xaml"
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
            
            #line 9 "..\..\..\Pages\PatientPage.xaml"
            ((Kursovoy.Pages.PatientPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboSortBy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Pages\PatientPage.xaml"
            this.ComboSortBy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSortBy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Pages\PatientPage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBoxSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Pages\PatientPage.xaml"
            this.TBoxSearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBoxSearchPatronymic = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Pages\PatientPage.xaml"
            this.TBoxSearchPatronymic.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearchPatronymic_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DGridPatient = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.BtnAddPatient = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Pages\PatientPage.xaml"
            this.BtnAddPatient.Click += new System.Windows.RoutedEventHandler(this.BtnAddPatientClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 63 "..\..\..\Pages\PatientPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditPatientClick);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 70 "..\..\..\Pages\PatientPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDelPatientClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

