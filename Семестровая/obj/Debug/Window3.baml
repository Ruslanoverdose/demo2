   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   $    Семестровая.Window3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          �Name$  window3��5   	    � Title$ Window3��5   	   $��108.271��6   $��460.15��6*    � 	Resources 5	         usersViewSource��%   &	        �� 5
   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5       � DataContext# [  6   $
��Left=�6M   $��	84,27,0,0q�6h   $	��Top=�6{    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��User Id:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��0��6]   $��Center=�6j   �� 5      -   5         ��Name$ userIdTextBox��5      $��1��6-   $
��Left=�6=   $��23��6X   $��3q�6d   $��0��6o   $��Center=�6�   $	��120��6�   ��6|   �� *UserId+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   5      �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��
276,32,0,0q�6>   $	��Top=�6R   $��75��6j   6u   5      5      