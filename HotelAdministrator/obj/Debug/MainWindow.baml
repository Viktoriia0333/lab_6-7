   M S B A M L   `   `   `  ����M  IHotelAdministrator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HotelAdministratorHotelAdministrator  5   	   #    HotelAdministrator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HotelAdministrator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��767��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dg��5
   &      
IsReadOnly . $
��Left=�61   $	��196��6L      AutoGenerateColumns .  $��	12,48,0,0q�6u   $	��Top=�6�   $	��346��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 119 6%      Header$ Тип��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Category+  5      $	 126 6%   $ Цена за день��63    6I   �� *	Day_Price+  5      $	 100 6%   $ Статус��63    6C   �� *Status.State+5      �� 5   
   -   5         ��Name$	 Doc��5      $
��Left=�6    $	��132��6;   $��
402,36,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��202��6�   �� 5   
   -   5        	 ��Name$	 	Dayscount��5   $   
 J� 	AllowDrop
 . $
��Left=�67   $��
44,295,0,0q�6R   $	��Top=�6f   $��48��6~   .@�5      �� $��1��6   $
��Left=�6(   $��48��6C   �� 5      $��2��6   $
��Left=�6'   $��48��6B   �� 5      $��3��6   $
��Left=�6'   $��48��6B   �� 5      $��4��6   $
��Left=�6'   $��48��6B   �� 5      $��5��6   $
��Left=�6'   $��48��6B   5      �� 5   
   $#��Количество дней��6   $
��Left=�6*   $��
24,265,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $��Подтверждаю��5      $
��Left=�6'   $��461,206,0,0q�6B   $	��Top=�6W   $��88��6o   $��21��6z   6�   �� 5   
   -   5        $��Другие номера��5      $
��Left=�6)   $��
630,47,0,0q�6D   $	��Top=�6X   $	��113��6p   $��32��6|   6�   �� 5   
   -   5        $!��Добавить номер��5      $
��Left=�6*   $��630,101,0,0q�6E   $	��Top=�6Z   $	��113��6r   $��32��6~   6�   �� 5   
   -   5        $��Обновить��5      $
��Left=�6$   $��
130,22,0,0q�6?   $	��Top=�6S   $��88��6k   $��21��6v   6�   5      5       