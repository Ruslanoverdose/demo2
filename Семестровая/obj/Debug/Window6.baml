   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   $    Семестровая.Window6   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          � Title$#  Добавить запись��5   	   $��170.301��6!   $��237.97��62    � 	Resources 5	         groupsViewSource��%   &	        �� 5
   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5       � DataContext# [  6   $
��Left=�6N   $��	10,10,0,0q�6i   $	��Top=�6|    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Имя группы:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��1��6`   $��Center=�6m   �� 5      -   5         ��Name$ nameTextBox��5      $��1��6+   $
��Left=�6;   $��23��6V   $��3q�6b   $��1��6m   $��Center=�6�   $	��120��6�   ��6z   �� *Name+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6�   �� 5      $��Описание:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��2��6^   $��Center=�6k   �� 5      -   5        $ descriptionTextBox��5      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��2��6t   $��Center=�6�   $	��120��6   ��6�   �� *Description+$ TwoWay=� . 	 . 6   5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
75,111,0,0q�6?   $	��Top=�6S   $��75��6k   6v   5      5       