   M S B A M L   `   `   `  ����P  L20.101-02-BeautySalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_20._101_02_BeautySalon.window_20._101_02_BeautySalon.window  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6D   8    2_20._101_02_BeautySalon.window.ClientServiceWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:_20._101_02_BeautySalon.window     5   	   6sys&clr-namespace:System;assembly=mscorlib     6D     � Title$  ClientServiceWindow��5   	   $	��450��6%   $	��800��62    � Icon$ /images/beauty_logo.ico��6>    � 	Resources 5	         defaultImage��%]   &	        ��5
   
   ;7pack://application:,,,/ImageAndIcon/beauty_logo.png.png��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��375* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $
��Left=�6I   $��10,0,0,0q�6d   $��26��6v   $��74��6�   .+�5      �� $��Клиент: ��6   $��20(�6)   �� 5      -   5         ��Name$ TbClientInfo��5      $��20(�6/   5      �� 5   
   -   5         ��Name$ spServiceInfo��5      $��0,52,0,0q�6,   $��2��6>   �� 5   
   -   5         ��Name$ LViewService��5      $��1��6)   $��5,5,5,5q�66   ��5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � ��
 �� Value$
 Stretch=�6C   5      ��5!      �� 5"      .R�5#      �� 
���   �$��1q�61   ._�5$      �  � ColumnDefinitions 5%      �� 5&   "   $	��200 �63   �� 5'   "   $��* �63   .+�5*      �� $	��180��6$   $	��100��60   $��5q�6=   ��6H   ��  �� Path$ Service.ImgPath� �� FallbackValue# [  �� 5,      $��1��6)   $��5q�69   .+�5-   "   �� $
��Bold"�6P   ��6,   �� $ Service.Title�6P   �� 5.   "   $ 
Horizontal=�6-   .+�5/   &   �� $��Strikethrough{�6W   ��60   �� $ Service.CostText�6W   �� 50   &   ��60   �� $ Service.DiscountCost� �� StringFormat$  {0} рублей за ���� 51   &   ��60   �� $ Service.DurationInMin�$ {0} минут��52   #   �� 53   "   ��6,   �� $ Service.DiscountText��� 54   "   $ 
Horizontal=�6-   $��0,30,0,0q�6F   .+�55   &   ��  ��Name$ BtnDelService��69   -   5        $	��100��55   -   
����������#FF4A6D
������� � Cursor$
 Hand��6�   $��Удалить��6�   6�   �� 56   &   $ BtnRefrService��69   -   5        $	��100��56   -   
����������#FF4A6D
�������$
 Hand��6�   $ ��Редактировать��6�   6�   57   #   58      59      5:      5;      5=      5>      5?      