   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   $    Семестровая.Window9   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          �Name$  window9��5   	    � Title$ Window9��5   	   $��75.564��6   $	��300��6)    � 	Resources 5	         groupsViewSource��%   &	        �� 5
   
   6   5      .��5      � $��49��6   $	��Top=�6   $��0,0,0,-2q�6/   .+�5   
   � -   5         �Name$ grid1��5       � DataContext# [  6   $
��Left=�6N   $��	10,10,0,0q�6i   $	��Top=�6|    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��ID группы:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��0��6_   $��Center=�6l   �� 5      -   5         ��Name$ groupIDTextBox��5      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��0��6p   $��Center=�6�   $	��120��6�   ��6}   �� *	GroupID+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   5      �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��
209,11,0,0q�6>   $	��Top=�6R   $��75��6j   $��25��6u   6�   5      5      