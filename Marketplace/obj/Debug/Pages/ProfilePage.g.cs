// Updated by XamlIntelliSenseFileGenerator 20.10.2023 18:58:11
#pragma checksum "..\..\..\Pages\ProfilePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78CA98C2AEE29ED6E20D93AB9C049819E288CCED1508BECC68FE252B7E22502F"
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


namespace Marketplace.Pages
{


    /// <summary>
    /// ProfilePage
    /// </summary>
    public partial class ProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 39 "..\..\..\Pages\ProfilePage.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Marketplace;component/pages/profilepage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\ProfilePage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\Pages\ProfilePage.xaml"
                    ((Marketplace.Pages.ProfilePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);

#line default
#line hidden
                    return;
                case 2:
                    this.BackBtn = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\Pages\ProfilePage.xaml"
                    this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtnClick);

#line default
#line hidden
                    return;
                case 3:
                    this.BalanceLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:

#line 41 "..\..\..\Pages\ProfilePage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReplinishBalanceBtnClick);

#line default
#line hidden
                    return;
                case 5:

#line 42 "..\..\..\Pages\ProfilePage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLikesBtnClick);

#line default
#line hidden
                    return;
                case 6:

#line 43 "..\..\..\Pages\ProfilePage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToBasketBtnClick);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button BackBtnClick;
    }
}

