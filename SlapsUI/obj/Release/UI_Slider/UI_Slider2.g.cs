﻿#pragma checksum "..\..\..\UI_Slider\UI_Slider2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "487D86C9087D07AF88787A1AF8043102"
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


namespace SlapsUI {
    
    
    /// <summary>
    /// UI_Slider2
    /// </summary>
    public partial class UI_Slider2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ok_Button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_Button;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Input;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Input_2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UI_Slider\UI_Slider2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_2;
        
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
            System.Uri resourceLocater = new System.Uri("/SlapsUI;component/ui_slider/ui_slider2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI_Slider\UI_Slider2.xaml"
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
            this.Ok_Button = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\UI_Slider\UI_Slider2.xaml"
            this.Ok_Button.Click += new System.Windows.RoutedEventHandler(this.Ok_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cancel_Button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\UI_Slider\UI_Slider2.xaml"
            this.cancel_Button.Click += new System.Windows.RoutedEventHandler(this.cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Input = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Input_2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Slider = ((System.Windows.Controls.Slider)(target));
            
            #line 28 "..\..\..\UI_Slider\UI_Slider2.xaml"
            this.Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Slider_2 = ((System.Windows.Controls.Slider)(target));
            
            #line 38 "..\..\..\UI_Slider\UI_Slider2.xaml"
            this.Slider_2.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

