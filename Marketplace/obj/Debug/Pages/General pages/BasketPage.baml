   M S B A M L   `   `   `  ����F  BMarketplace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Marketplace.PagesMarketplace.Pages  5      "    Marketplace.Pages.BasketPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Marketplace.Pages     5      -   5          N� Title$  
BasketPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��91* �6   �� 5      $
��629* �6   .+�5   
   �� ���#353831 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6#      RenderingBias$ Performance=�61      	Direction$	 270Q�6M      ShadowDepth$ 5Q�6]      
BlurRadius$ 10Q�6m   5      �� 5   
   $��Center=�6    �� Orientation$ 
Horizontal=�60   .+�5      �� -   5        	 ��Name$	 ExitBtn��5      $��
Назад��6&   $��Light"�66   $	��100��6I   $��25(�6U   ���#FEF9EF$��10q�6x   ���#3538316�   �� 5      -   5        $��Маркетплейс��5      $��Light"�6+   $	��180��6>   $��25(�6J   $��10q�6X   ���#FEF9EF���#3538316�   �� 5      $��/Pages/logoWhite.png��6   $	��300��62   $��70 0 0 0q�6>   6R   �� 5      -   5        
 ��Name$
 	NameLabel��5   �   $��Italic$�63   ���#FEF9EF$��Center=�6[   $��80 0 0 0q�6v   ��6�   �� *Name+6�   �� 5      -   5        $
 SurnameLabel��5   �   $��Italic$�63   ���#FEF9EF$��Center=�6[   $��30 0 0 0q�6v   ��6�   �� *	Surname+6�   5      �� 5   
   -   5        $
 NoProductsInBasketLabel��5   8   $��1��6   $��Center=�6   $H��BВы пока не добавили товары в корзину��6Y   $��Center=�6�   $��Black"�6�   $��15q�6�   6�   �� 5   
   $��1��6   .+�5      �� $��Корзина��6   $��Center=�6&   $��Black"�6C   $��15q�6V   6d   �� 5      -   5         ��Name$ ProductList��5   A   $��3��6   $��Center=�6$   ���#FEF9EF���#FEF9EF��5       �� 5!      .R�5"      �� $ 
Horizontal=�6%   $��
30 0 30 30q�6>   ���#353831 5#        5$   "   $ 10Q�63   $ Performance=�6@   $	 270Q�6\   $ 3Q�6l   $ 30Q�6|   .+�5&      �� $ 
Horizontal=�6)   $��10q�6B   .+�5'   "   �� 
���   �$��3q�6=   ._�5(   &   �� $	��300��6M   $	��300��6Z   ��6,   �� *Product.Image+6Z   5)   #   �� 5*   "   $ Vertical=�6-   $��Center=�6D   $��30 0 0 0q�6_   .+�5+   &   �� -   5        $��X��5+   u   
���  ��$	��Top=�6�   $��Right=�6�   
 � Tag 6U   �� *idBasketProduct+6�   �� 5,   &   $ 
Horizontal=�61   .+�5-   *   �� ���#FEF9EF$%��Название товара: ��6E   6c   �� 5.   *   ���#FEF9EF��6E   �� *Product.Title+5/   '   �� 50   &   $ 
Horizontal=�61   .+�51   *   �� ���#FEF9EF$1��+Цена товара за еденицу: ��6E   6j   �� 52   *   ���#FEF9EF��6E   �� *Product.Cost+53   '   �� 54   &   $ 
Horizontal=�61   .+�55   *   �� ���#FEF9EF$��Количество: ��6E   6^   �� 56   *   ���#FEF9EF��6E   �� *Count+57   '   �� 58   &   $ 
Horizontal=�61   $��Bottom=�6J   $��Center=�6e   .+�59   *   �� $	 
BuyProduct��61   -	   5        $��Bottom=�59   }   ���#FEF9EF
���   �$	��150��6�   $��	0 100 0 0q�6�   $��30(�6�   $��Купить��6�    6E   �� *idBasketProduct+6   5:   '   5;   #   5<      �� 5=      $��5��6(    J� Opacity$ 0Q�63   5>      5?      5A      5B      5D      5E      