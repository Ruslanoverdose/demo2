   M S B A M L   `   `   `  ����Q  MСеместровая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:СеместроваяСеместровая  5   	   '    !Семестровая.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Семестровая     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � 	Resources 5	         usersViewSource  usersGroupsViewSource �� Source �� Source��%i   &	        &	      7   �� 5
   
   6   �� 5   
   -   5         5   c   �� *Groups+8   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ usersDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10,49,10,39q�6}      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   	   
IsReadOnly	 . ��6e   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        userIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$! ID пользователя��5   V      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *UserId+6o     5      -   5        firstNameColumn��$ Имя��5   \   $	 100 6i    6>   �� *	FirstName+6i     5      -   5        lastNameColumn��$ Фамилия��5   Z   $	 100 6k    6=   �� *
LastName+6k   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        birthDayUsersColumn��$ Дата рождения��5   F   $	 150 6]      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *BirthDayUsers+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        logInUsersColumn��$ 
Логин��5   ^   $	 100 6m    6?   �� *
LogInUsers+6m     5      -	   5        emailColumn��$ Email��5   T   $	 150 6c    6:   �� *Email+6c   5(      �� 5)   
   -
   5        $��Добавить��5)      $
��Left=�6$   $��34��6?   $��	18,10,0,0q�6K   $	��Top=�6^   $	��140��6v    J� RenderTransformOrigin$ 0.471,0.412&�6�   6�   �� 5*   
   -   5         ��Name$ 	UpdateBUt��5*      $��Изменить��6$   $
��Left=�67   $��34��6R   $��
163,10,0,0q�6^   $	��Top=�6r   $	��140��6�   $ 0.471,0.412&�6�   6�   �� 5+   
   -   5        $ 	DelButton��5+      $��Удалить��6$   $
��Left=�66   $��34��6Q   $��
308,10,0,0q�6]   $	��Top=�6q   $	��140��6�   $ 0.471,0.412&�6�   6�   �� 5,   
   -   5        $��Профиль��5,      $
��Left=�6#   $��
453,10,0,0q�6>   $	��Top=�6R   $	��134��6j   $��34��6v   6�   �� 5-   
   -   5        $ ButtonGroups��5-      $��Группы��6'   $
��Left=�68   $��
592,10,0,0q�6S   $	��Top=�6g   $	��134��6   $��34��6�   6�   �� 5.   
   -   5         ��Name$ txBox1��5.      $
��Left=�6"   $��23��6=   $��114,538,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   6�   �� 5/   
   -   5        $ txBox2��5/      $
��Left=�6"   $��23��6=   $��328,538,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   6�   �� 50   
   $��Фамилия��6   $
��Left=�6"   $��263,537,0,0q�6=   $	��Top=�6R   �� 51   
   $��Имя��6   $
��Left=�6   $��
76,537,0,0q�69   $	��Top=�6M   54      55      