﻿#pragma checksum "..\..\..\..\Pages\Seller pages\SellerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50DF1ABEB24085F8B492E75E720E79E860771A25E2F8017EFB5D7E419112AABA"
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
    /// SellerPage
    /// </summary>
    public partial class SellerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasketBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MarketplaceBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BalanceLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Marketplace;component/pages/seller%20pages/sellerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((Marketplace.Pages.SellerPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BasketBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            this.BasketBtn.Click += new System.Windows.RoutedEventHandler(this.GoToBasketBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MarketplaceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            this.MarketplaceBtn.Click += new System.Windows.RoutedEventHandler(this.MarketplaceBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BalanceLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            
            #line 44 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReplinishBalanceBtnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 45 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLikesBtnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 46 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToBasketBtnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 47 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToRequestsPageBtnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 50 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MakeSupplyPage);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 51 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SellsBtnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 52 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateNewProductBtnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 53 "..\..\..\..\Pages\Seller pages\SellerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ListOfSuppliesBtnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

