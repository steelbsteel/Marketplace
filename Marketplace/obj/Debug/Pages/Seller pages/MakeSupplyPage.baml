   M S B A M L   `   `   `  ����F  BMarketplace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Marketplace.Pages.Seller_pagesMarketplace.Pages.Seller_pages  5      3    -Marketplace.Pages.Seller_pages.MakeSupplyPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Marketplace.Pages.Seller_pages     5      -   5        .��5
      �   � RowDefinitions  5   
   �� 5      $	��91* �6   �� 5      $
��629* �6   .+�5   
   �� ���#353831 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6#      RenderingBias$ Performance=�61      	Direction$	 270Q�6M      ShadowDepth$ 5Q�6]      
BlurRadius$ 10Q�6m   5      �� 5   
   $��Center=�6    �� Orientation$ 
Horizontal=�60   .+�5      �� -   5         ��Name$ BackBtn��5      $��
Назад��6&   $��Light"�66   $	��100��6I   $��25(�6U   ���#FEF9EF$��10q�6x   ���#3538316�   �� 5      -   5        $ 	BasketBtn��5      $��Корзина��6(   $��Light"�6:   $	��140��6M   $��25(�6Y   $��10q�6g   ���#FEF9EF���#3538316�   �� 5      -   5        $ MarketplaceBtn��5      $��Маркетплейс��6-   $��Light"�6C   $	��180��6V   $��25(�6b   $��10q�6p   ���#FEF9EF���#3538316�   �� 5      $��/Pages/logoWhite.png��6   $	��300��62   $��70 0 0 0q�6>   6R   �� 5      -   5        	 ��Name$	 	NameLabel��5   �   $��Italic$�6.   ���#FEF9EF$��Center=�6V   $��80 0 0 0q�6q   ��6�   �� *Name+6�   �� 5      -   5        $	 SurnameLabel��5   �   $��Italic$�6.   ���#FEF9EF$��Center=�6V   $��30 0 0 0q�6q   ��6�   �� *	Surname+6�   5      �� 5   
   $��Поставка��6   $��1��6#   $��Center=�60   $��20q�6M   $��Black"�6Y   6n   �� 5   
   $��	0 100 0 0q�6   $��Center=�6(   $ 
Horizontal=�6E   $��1��6^   .+�5      �� $ Vertical=�6   $��	50 10 0 0q�61   .+�5      �� $��Товар:  ��6   $��10q�6+   69   �� 5       $��Количество: ��6   $��10q�6/   6=   �� 5!      $��
Дата: ��6   $��10q�6)   67   �� 5"      $��Склад:��6   $��10q�6)   5#      �� 5$      $ Vertical=�6   $��
200 10 0 5q�60   .+�5%      �� -   5        
 ��Name$
 	ProductCB��5%      $��10q�6.   ��5&      �� 5'      .R�5(      �� $ 
Horizontal=�6)   .+�5)   "   �� $��Center=�6C   ��6,   �� *Title+6C   5*      5+      5-      �� 5.      -   5         ��Name$ CountTB��5.      $��10q�6,   6:   �� 5/      ���#218380._�50      (  "System.Windows.Controls.DatePicker  -	   5          Name$ 
datePicker��50   4   $��Light"�6!   $��Center=�6H   $��Center=�51   !   $��30(�6C   $��60��6Q   $	��400��6]   $��10q�6j   ���#2183806v   52      �� 53      -
   5        $
 
StoragesCB��53      $��10q�6/   ��54      �� 55      .R�56      �� $ 
Horizontal=�6)   .+�57   "   �� $��0 0 0 0q�6,   $��Center=�6V   ��6=   �� *	Address+6V   58      59      5;      5<      5=      �� 5>   
   -   5        $��Bottom=�5>      $��1��6,   $��20q�69   $	��600��6E   $1��+Запланировать поставку��6Q   6�   5?      5@      