   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   $    Семестровая.Window5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          �Name$  window5��5   	    � Title$ Группы��5   	   $��512.424��6   $��501.88��6)    � 	Resources 5	         groupsViewSource  usersViewSource��%:   &	        &	      �� 5
   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ groupsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��
10,150,6,9q�6~      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   	   
IsReadOnly	 . ��6f   �� z�5      V� 5      .~�5      �� �� 5      
 �� AngleY$
 -0.042Q�6$   �� 5      T� 5       T� Y$ -1.127Q�6)   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        groupIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID группы��5   X      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	GroupID+6k     5      -   5        
nameColumn��$ Имя группы��5   R   $	 100 6f    69   �� *Name+6f     5      -   5        descriptionColumn��$ Описание��5   `   $	 300 6r    6@   �� *Description+6r   5      �� 5   
   -   5         ��Name$ 	CreateBut��5      $��Создать��6$   $
��Left=�66   $��42��6Q   $��	10,10,0,0q�6]   $	��Top=�6p   $	��150��6�   6�   �� 5    
   -   5        $ DeleteGroupBut��5       $��Удалить��6)   $
��Left=�6;   $��42��6V   $��
165,10,0,0q�6b   $	��Top=�6v   $	��150��6�   6�   �� 5!   
   -   5        $ EditButt��5!      $ ��Редактировать��6#   $
��Left=�6;   $��42��6V   $��
320,10,0,0q�6b   $	��Top=�6v   $	��150��6�   6�   � 5"   
   -	   5         �Name$ grid1��5"      # [ 6   $
��Left=�6M   $��	10,73,0,0q�6h   $	��Top=�6{    � ColumnDefinitions 5#      �� 5$      $
��Auto �6#   �� 5%      $
��Auto �6#    � RowDefinitions 5'      �� 5(      $
��Auto �6    .+�5*      �� $"��ID пользователя:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��0��6e   $��Center=�6r   �� 5+      -
   5         ��Name$ userIdTextBox��5+      $��1��6-   $
��Left=�6=   $��23��6X   $��3q�6d   $��0��6o   $��Center=�6�   $	��120��6�   ��6|   �� *UserId+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   5,      �� 5-   
   -   5         ��Name$ checkboxMygroups��5-      $��Мои группы��6-   $
��Left=�6B   $��
23,110,0,0q�6]   $	��Top=�6q   �� 5.   
   -   5        $ buttsubs��5.      $��Подписаться��6#   $
��Left=�69   $��
249,76,0,0q�6T   $	��Top=�6h   $	��105��6�   6�   50      51      