﻿#pragma checksum "..\..\..\..\Pages\General pages\BasketPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25D955DEA339BC35F6DE57ED9EE5753FE823A6D14FB398EA828AE800F08861F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Marketplace.Pages;
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


namespace Marketplace.Pages {
    
    
    /// <summary>
    /// BasketPage
    /// </summary>
    public partial class BasketPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\..\Pages\General pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\General pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameLabel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\General pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SurnameLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\General pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductList;
        
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
            System.Uri resourceLocater = new System.Uri("/Marketplace;component/pages/general%20pages/basketpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\General pages\BasketPage.xaml"
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
            
            #line 10 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            ((Marketplace.Pages.BasketPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MarketplaceBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            this.NameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NameLabelMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SurnameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            this.SurnameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NameLabelMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductList = ((System.Windows.Controls.ListView)(target));
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
            
            #line 42 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteProductFromBasketBtnClick);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 56 "..\..\..\..\Pages\General pages\BasketPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BuyProductClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

