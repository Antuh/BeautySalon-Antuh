   M S B A M L   `   `   `  ����P  L20.101-02-BeautySalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:_20._101_02_BeautySalon.pages_20._101_02_BeautySalon.pages  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6A   .    (_20._101_02_BeautySalon.pages.ClientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:_20._101_02_BeautySalon.pages     5      6sys&clr-namespace:System;assembly=mscorlib     6A     N� Title$  
ClientPage��5	       � 	Resources 5         defaultImage��%W   &	        ��5   
   51pack://application:,,,/Resourse/Agent/picture.png��5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��8* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   � $��0��6   $��2��6   $��41��6-   $	��Top=�69    5      �� 5      $
��125* �6#   �� 5       $
��200* �6#   �� 5!      $
��200* �6#   �� 5"      $	��120 �6#   61   �� 5#      $	��140 �6#   61   .+�5%      �� -   5        $��cmbCount��5%       �� SelectedIndex$ 0��6'   $��Center=�69   $��22��6T   $��0,0,10,0q�6`   $��1��6�   �� 5&      -   5        $��Center=�5&      $��0,0,10,0q�61   $��22��6C   6O   �� 5'      -   5         ��Name$ 
cmbSorting��5'      $��2��6+   $ 0��6;   $��Center=�6M   $��22��6�   $��5,0,5,0q�6�   �� 5(      -   5        $��	cmbFilter��5(      $��3��6(   $ 0��68   $��Center=�6J   $��22��6e   $��Center=�6�   $	��102��6�   �� 5)      -   5         ��Name$ CbBirthDateInMonth��5)      $��4��63   $��Center=�6C   $��ДР в тек.мес.��6^   $��15��6�   $��Center=�6�   $	��122��6�   5*      �� 5,   
   -   5         ��Name$ LViewAgents��5,      $��1��6(   $��0��65   $��5,5,5,0q�6E   $	��317��6�   $	��Top=�6�    �� View 5-      �� 5.      .P�5/      �� $ ��Идентификатор��6%   	 �� Width$
	 Auto��6<   
 �� CellTemplate
 50      �� 51      .R�52   "   �� $��Center=�6@   $��Center=�6]   ��6,   �� *ID+6]   53      55      �� 56      $��Пол��6%   $
	 Auto��62   
 57      �� 58      .R�59   "   �� $��Center=�6N   $��Center=�6k   ��6,   ��  �� Path$ Gender.Name�6k   5:      5<      �� 5=      $��Фамилия��6%   $
	 Auto��66   
 5>      �� 5?      .R�5@   "   �� $��Center=�6G   $��Center=�6d   ��6,   �� *	FirstName+6d   5A      5C      �� 5D      $��Имя��6%   $
	 Auto��62   
 5E      �� 5F      .R�5G   "   �� $��Center=�6F   $��Center=�6c   ��6,   �� *
LastName+6c   5H      5J      �� 5K      $��Отчество��6%   $
	 Auto��67   
 5L      �� 5M      .R�5N   "   �� $��Center=�6H   $��Center=�6e   ��6,   �� *
Patronymic+6e   5O      5Q      �� 5R      $��Дата рождения��6%   $
	 Auto��6<   
 5S      �� 5T      .R�5U   "   �� $��Center=�6F   $��Center=�6c   ��6,   �� *
Birthday+6c   5V      5X      �� 5Y      $��Телефон��6%   $
	 Auto��66   
 5Z      �� 5[      .R�5\   "   �� $��Center=�6C   $��Center=�6`   ��6,   �� *Phone+6`   5]      5_      �� 5`      $'��!Электронная почта��6%   $
	 Auto��6@   
 5a      �� 5b      .R�5c   "   �� $��Center=�6C   $��Center=�6`   ��6,   �� *Email+6`   5d      5f      �� 5g      $#��Дата добавления��6%   $
	 Auto��6>   
 5h      �� 5i      .R�5j   "   �� $��Center=�6N   $��Center=�6k   ��6,   �� *RegistrationDate+6k   5k      5m      �� 5n      $6��0Дата последнего посещения��6%   $
	 Auto��6H   
 5o      �� 5p      .R�5q   "   �� $��Center=�6I   $��Center=�6f   ��6,   �� *DateService+6f   5r      5t      �� 5v      $-��'Количество посещений��6%   $
	 Auto��6C   
 5w      �� 5x      .R�5y   "   �� $��Center=�6J   $��Center=�6g   ��6,   �� *CountService+6g   5z      5|      �� 5}      $��Список тегов��6%   $
	 Auto��6;   
 5~      �� 5      .R�5�   "   �� ��6/   �� *	TagList+��5�   &   �� 5�   *   .R�5�   .   �� $
��Left=�6f   $��Center=�6�   ��68   �� *Title+ �� StringFormat$ - {0}��6�   5�   +   5�   #   5�      5�      5�      ��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value$ Stretch=�6C   5�       � ContextMenu 5�      �� 5�      .@�5�      m� -   5         m�Name$ ClientService��5�      $��Посещения��66   6I   5�      5�      � 5�   
   $��1��6   $��	0,327,0,0q�6   $��2��6/   $��41��6@   $	��Top=�6L    5�      �� 5�      6%   �� 5�      6%   �� 5�      6%   .+�5�      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $��Stretch=�6B   $��15, 0, 5, 0q�6`   .+�5�      �� $��Записей: ��6   $
��Bold"�6-   $
��Left=�6?   $��Center=�6[   6x   �� 5�      -   5         ��Name$ txtDataCount��5�      $
��Bold"�62   $�� ��6E   $��Right=�6M   $��Center=�6j   6�   �� 5�      $�� из ��6   $
��Bold"�6(   $
��Left=�6:   $��Center=�6V   6s   �� 5�      -	   5        $ txtFullDataCount��5�      $�� ��67   $��Right=�6?   $��Center=�6\   6y   5�      �� 5�      $��2��6   $ 
Horizontal=�6*   $��Right=�6C   $
��auto��6_   $��
5, 5, 5, 5q�6l   .+�5�      �� -
   5         ��Name$
 back��5�      $��B��6'   {�.  $��30��6X   $��20��6d   
�������
���   � � Cursor$
 Hand��6�   6�   �� 5�      -   5         ��Name$ pagin��5�      $ 
Horizontal=�6,   $��Stretch=�6E   $
��auto��6c   6s   �� 5�      -   5        $ forward��5�      $��F��6*   $��30��6L   $��20��6X   
�������
���   �$
 Hand��6�   6�   5�      5�      � 5�   
   $��2��6   $��0,41,0,0q�6   $��2��6.   .+�5�      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   $	��545��6j   .+�5�      �� -   5        $ deleteButton��5�      $��5q�6/   $��30��6:   
����������#FF4A6D$
��Bold"�6o   
�������$
 Hand��6�   $	��163��6�   $��0��6�   $��Удалить��6�   6�   �� 5�      -   5        $ 	addButton��5�      $��5q�6,   $��30��67   
����������#FF4A6D$
��Bold"�6m   
�������$
 Hand��6�   $	��163��6�   $��1��6�   $��Добавить��6�   6�   �� 5�      -   5        $ 	rebButton��5�      $��5q�6,   $��30��67   
����������#FF4A6D$
��Bold"�6l   
�������$
 Hand��6�   $	��163��6�   $��1��6�   $��Обновить��6�   6�   5�      5�      5�      5�      