   M S B A M L   `   `   `  ����M  IHotelAdministrator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HotelAdministratorHotelAdministrator  5   	   #    HotelAdministrator.OtherRooms   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HotelAdministrator     5   	     � Title$  
OtherRooms��5   	   $��325.067��6   $��753.908��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dg��5
   %      
IsReadOnly . $
��Left=�60   $	��189��6K      AutoGenerateColumns .  $��	32,50,0,0q�6t   $	��Top=�6�   $	��499��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 119 6%      Header$ Тип��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Category+  5      $	 126 6%   $ Цена за день��63    6I   �� *	Day_Price+  5      $	 100 6%   $ Статус��63    6C   �� *Status.State+  5      $	 150 6%   $ Занят до��63    6E   �� *DateTo+5      �� 5   
   -   5         ��Name$	 cmd��5      $��
592,26,0,0q�6    $	��Top=�64   $	��120��6L   .@�5      �� $��
Занят��6   $
��Left=�6+   $	��118��6F   �� 5      $��Свободен��6   $
��Left=�6.   $	��118��6I   5      �� 5   
   -   5        $��Подтверждаю��5      $
��Left=�6'   $��609,133,0,0q�6B   $	��Top=�6W   $	��120��6o   6{   �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $��47��6g   $��23��6r   $��14(�6~   6�   5      5      