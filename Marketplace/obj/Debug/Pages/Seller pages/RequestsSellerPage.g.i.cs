﻿#pragma checksum "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEFBB932866AD02060C08016F4FEB89B9F6C64941CC89937CF4F8F8AE0FF5098"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Marketplace.Pages.Seller_pages;
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


namespace Marketplace.Pages.Seller_pages {
    
    
    /// <summary>
    /// RequestsSellerPage
    /// </summary>
    public partial class RequestsSellerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasketBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MarketplaceBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SurnameLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NoOneRequestsLabel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Requests;
        
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
            System.Uri resourceLocater = new System.Uri("/Marketplace;component/pages/seller%20pages/requestssellerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
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
            
            #line 10 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            ((Marketplace.Pages.Seller_pages.RequestsSellerPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BasketBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            this.BasketBtn.Click += new System.Windows.RoutedEventHandler(this.GoToBasketBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MarketplaceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            this.MarketplaceBtn.Click += new System.Windows.RoutedEventHandler(this.MarketplaceBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 27 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            this.NameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NameMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SurnameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 28 "..\..\..\..\Pages\Seller pages\RequestsSellerPage.xaml"
            this.SurnameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NameMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NoOneRequestsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Requests = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
