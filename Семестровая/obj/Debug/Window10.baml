   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   %    Семестровая.Window10   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          �Name$  window10��5   	    � Title$ Window10��5   	   $��172.556��6   $��240.226��6+    � 	Resources 5	         groupsViewSource��%   &	        �� 5
   
   6   5      .��5      � .+�5   
   � $��	0,0,10,10q�6    � ColumnDefinitions 5      �� 5      $	��40* �6#   �� 5      $	��37* �6#   .+�5      � -   5         �Name$ grid1��5       � DataContext# [  6"   $
��Left=�6R   $��	10,10,0,0q�6m   $	��Top=�6�   $��2��6�    5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Description:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��0��6e   $��Center=�6r   �� 5      -   5         ��Name$ descriptionTextBox��5      $��1��66   $
��Left=�6F   $��23��6a   $��3q�6m   $��0��6x   $��Center=�6�   $	��120��6  ��6�   �� *Description+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6  �� 5      $��	Group ID:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��1��6b   $��Center=�6o   �� 5      -   5        $ groupIDTextBox��5      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��1��6t   $��Center=�6�   $	��120��6�   ��6�   �� *	GroupID+$ TwoWay=�	 . 
 . 6�   �� 5       $��Name:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��2��6^   $��Center=�6k   �� 5!      -   5        $ nameTextBox��5!      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��2��6q   $��Center=�6�   $	��120��6�   ��6~   �� *Name+$ TwoWay=�	 . 
 . 6�   5"      �� 5#      -   5         ��Name$ EditButtton��5#      $��Button��6*   $
��Left=�6;   $��
74,111,0,0q�6V   $	��Top=�6j   $��75��6�   $��2��6�   5%      5'      5(      