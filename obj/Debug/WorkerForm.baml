   M S B A M L   `   `   `  ����P  LCarMaintainanceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarMaintainanceSystemCarMaintainanceSystem  5   	   &     CarMaintainanceSystem.WorkerForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CarMaintainanceSystem     5   	     � Title$  Worker Form��5   	   $	��450��6   $	��800��6*   .��5	      � 
����·� � RowDefinitions 5
   
   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� $
��Bold"�6   $��25(�6"   $��Arial)�60   $��25q�6C   .��6O   *(Click on Edit button to load the records6y   &   System.Windows.Controls.DataGrid  5   
   -   5        $��MainDataGrid��5   t   $��75, 75, 0, 12q�6D   $	��600��6[   $	��200��6g   $
��Left=�6�   $	��Top=�6�   �� 5   
   $��Edit data here:��6   $��20(�6*   $��75, 280, 0, 0q�68   �� 5   
   -   5         ��Name$ 	myTextBox��5      $	��300��6%   $��30��61   $��220, 280,0,0q�6=   $	��Top=�6S   $
��Left=�6k   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��15q�6#   .+�5      �� -   5        $��btnSave��5   /   $��75��6>   $��45��6I   $��25(�6V   $
��Save��6d   $��Microsoft Sans Serif)�6s   5      � 5      $��1��6   $��15q�6#   .+�5      �� -   5        $��btnEdit��5   /   $
��Edit��6>   $��75��6M   $��45��6X   $��25(�6e   $��Microsoft Sans Serif)�6s   5       � 5!      $��2��6   $��15q�6#   .+�5"      �� -   5        $��	btnCancel��5"   1   $��90��6B   $��45��6M   $��25(�6Z   $��Microsoft Sans Serif)�6h   $��Cancel��6�   5#      � 5$      $��3��6   $��15q�6#   .+�5%      �� -   5        $��btnExit��5%   /   $��75��6?   $��45��6J   $��25(�6W   $��Microsoft Sans Serif)�6e   $
��Exit��6�   5&      5'      5(      5)      