﻿#pragma checksum "..\..\member_index.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BEEAF5049F674876A2FCA7CB7505B0678494438893B106BE30937FBCFACE55EB"
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
using UnitySpace;


namespace UnitySpace {
    
    
    /// <summary>
    /// member_index
    /// </summary>
    public partial class member_index : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rbtn1;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notif;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock notifBullet;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup NotificationPopup;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock notifBarCounter;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel notifactionContent;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image profil;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\member_index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl membreC;
        
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
            System.Uri resourceLocater = new System.Uri("/UnitySpace;component/member_index.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\member_index.xaml"
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
            
            #line 10 "..\..\member_index.xaml"
            ((UnitySpace.member_index)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainWindow_LocationChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\member_index.xaml"
            ((UnitySpace.member_index)(target)).LocationChanged += new System.EventHandler(this.MainWindow_LocationChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Rbtn1 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\member_index.xaml"
            this.Rbtn1.Loaded += new System.Windows.RoutedEventHandler(this.comfirmed_meeting);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 35 "..\..\member_index.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.logout);
            
            #line default
            #line hidden
            return;
            case 4:
            this.notif = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\member_index.xaml"
            this.notif.Click += new System.Windows.RoutedEventHandler(this.ButtonNotif_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.notifBullet = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.NotificationPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 7:
            this.notifBarCounter = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.notifactionContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.profil = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.membreC = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

