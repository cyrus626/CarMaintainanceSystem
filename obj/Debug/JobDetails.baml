   M S B A M L   `   `   `  ����P  LCarMaintainanceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarMaintainanceSystemCarMaintainanceSystem  5   	   &     CarMaintainanceSystem.JobDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CarMaintainanceSystem     5   	     � Title$  Job Details��5   	   $	��600��6   $	��800��6*   .��5	      �� 
����·�.+�5
   
   � $��25q�6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��5q�6   $��0��6   $��0��6+   .+�5      �� -   5         ��Name$ lblCarNo��5   &   $��18(�6   
����+��$
��Left=�6P   $��Car No.:��6k   �� 5      -   5         ��Name$ 	editCarNO��5   2   $	��180��6   $��30��6&   6E   5       � 5!      $��5q�6   $��0��6   $��1��6+   .+�5"      �� -   5        $ lblName��5"   &   $��18(�6   
����+��$��	WorkerId:��6O   �� 5#      -   5        $ editName��5#   2   $	��180��6   $��30��6&   6D   5$      � 5%      $��5q�6   $��1��6   $��1��6+   .+�5&      �� -   5        $ lblKMs��5&   &   $��18(�6   
����+��$
��KMs:��6N   �� 5'      -   5        $ editKMs��5'   2   $	��180��6   $��30��6&   6C   5(      � 5)      $��5q�6   $��1��6   $��0��6+   .+�5*      �� -   5        $ 
lblJobDate��5*   &   $��18(�6   
����+��$��	Job date:��6R   (  "System.Windows.Controls.DatePicker  5+      -   5        $��dateTimePicker1��5+   5   $	��180��6   $��30��6)   
����+��6L   5,      � 5-      $��5q�6   $��2��6   $��0��6+   .+�5.      �� -	   5        $ 	lblTuning��5.   &   $��18(�6   
����+��$��Tuning:��6Q   �� 5/      -
   5        $��
editTuning��5/   2   $	��180��6   $��30��6&   62   50      � 51      $��5q�6   $��2��6   $��1��6+   .+�52      �� -   5        $ lblAlignment��52   &   $��18(�6   
����+��$��
Alignment:��6T   �� 53      -   5        $��editAlignment��53   &   $	��180��6   $��30��6;   54      � 55      $��5q�6   $��3��6   $��0��6+   .+�56      �� -   5        $ lblBalancing��56   &   $��18(�6   
����+��$��
Balancing:��6T   �� 57      -   5        $��editBalancing��57      $	��180��6/   $��30��6;   58      � 59      $��5q�6   $��3��6   $��1��6+   .+�5:      �� -   5        $ lblTires��5:   &   $��18(�6   
����+��$��Tires:��6P   �� 5;      -   5        $ 	editTires��5;      $	��180��6-   $��30��69   5<      � 5=      $��5q�6   $��6��6   $��0��6+   .+�5>      �� -   5        $ 
lblWeights��5>   &   $��18(�6   
����+��$��Weights:��6R   �� 5?      -   5        $��editWeights��5?      $	��180��6-   $��30��69   5@      � 5A      $��5q�6   $��6��6   $��1��6+   .+�5B      �� -   5        $ lblOilChanged��5B   &   $��18(�6   
����+��$��Oil Changed:��6U   �� 5C      -   5        $��editOilChanged��5C      $��30��60   $��
120,2,93,2q�6<   5D      � 5E      $��5q�6   $��7��6   $��0��6+   .+�5F      �� -   5        $ 	lblOilQty��5F   &   $��18(�6   
����+��$��Oil Quantity:��6Q   �� 5G      -   5        $ 
editOilQty��5G      $��30��6.   $��
115,2,93,2q�6:   5H      � 5I      $��5q�6   $��7��6   $��1��6+   .+�5J      �� -   5        $ lblOilFilter��5J   &   $��18(�6   
����+��$��
OilFilter:��6T   �� 5K      -   5        $��editOilFilter��5K      $	��180��6/   $��30��6;   5L      � 5M      $��5q�6   $��8��6   $��0��6+   .+�5N      �� -   5        $ 
lblGearOil��5N   &   $��18(�6   
����+��$��	Gear Oil:��6R   �� 5O      -   5        $��editGearOil��5O      $	��180��6-   $��30��69   5P      � 5Q      $��5q�6   $��8��6   $��1��6+   .+�5R      �� -   5        $ lblGearOilQty��5R   &   $��18(�6   
����+��$��Gear Oil Qty:��6U   �� 5S      -   5        $��editGearOilQty��5S      $��30��60   $��
124,2,93,2q�6<   5T      � 5U      $��5q�6   $��9��6   $��0��6+   .+�5V      �� -   5        $ lblPoint��5V   &   $��18(�6   
����+��$��Point:��6P   �� 5W      -   5        $��	editPoint��5W      $	��180��6+   $��30��67   5X      � 5Y      $��5q�6   $��9��6   $��1��6+   .+�5Z      �� -   5        $ lblCondenser��5Z   &   $��18(�6   
����+��$��
Condenser:��6T   �� 5[      -    5        $ editCondenser��5[      $��30��61   $��
103,2,93,2q�6=   5\      � 5]      $��5q�6   $��10��6   $��0��6,   .+�5^      �� -!   5        $ lblPlug��5^   &   $��18(�6   
����+��$��Plug:��6O   �� 5_      -"   5        $��editPlug��5_      $	��180��6*   $��30��66   5`      � 5a      $��5q�6   $��11��6   $��0��6,   .+�5b      �� -#   5        $ lblFuelFilter��5b   &   $��18(�6   
����+��$��Fuel filter:��6U   �� 5c      -$   5        $��editFuelFilter��5c      $	��180��60   $��30��6<   5d      � 5e      $��5q�6   $��11��6   $��1��6,   .+�5f      �� -%   5        $ lblAirFilter��5f   &   $��18(�6   
����+��$��Air Filter:��6T   �� 5g      -&   5        $��editAirFilter��5g      $	��180��6/   $��30��6;   5h      � 5i      $��5q�6   $��10��6   $��1��6,   .+�5j      �� -'   5        $ 
lblPlugQty��5j   &   $��18(�6   
����+��$��	Plug Qty:��6R   �� 5k      -(   5        $��editPlugQty��5k      $	��180��6-   $��30��69   5l      5m      �� 5n   
   -)   5        $��editRemarks��5n      $	��769��6%   $��23��61   .��6=   	Remarks6F   � 5o   
   $��1q�6    5p      �� 5q      $��* �6#   �� 5r      $��* �6#   �� 5s      $��* �6#   �� 5t      $��* �6#   �� 5u      $��* �6#   �� 5v      $��* �6#   �� 5w      $��* �6#   .+�5y      � $��15q�6   $��0��6   .+�5z      �� -*   5        $��btnPrevious��5z      $��<��6,   $��25(�6<   $��Microsoft Sans Serif)�6J   5{      � 5|      $	�� 15q�6   $��1��6    .+�5}      �� -+   5        $��	btnUpdate��5}      $��Update��6B   $��25(�6S   $��Microsoft Sans Serif)�6a   5~      � 5      $	�� 15q�6   $��2��6    .+�5�      �� -,   5        $��btnSave��5�   /   $
��Save��6>   $��25(�6M   $��Microsoft Sans Serif)�6[   5�      � 5�      $��15q�6   $��4��6   .+�5�      �� --   5        $��Cancel��5�      $��Cancel��6'   $��25(�68   $��Microsoft Sans Serif)�6F   5�      � 5�      $��15q�6   $��5��6   .+�5�      �� -.   5        $��btnExit��5�   /   $
��Exit��6>   $��25(�6M   $��Microsoft Sans Serif)�6[   5�      � 5�      $��15q�6   $��6��6   .+�5�      �� -/   5        $��btnNext��5�      $��>��6(   $��25(�64   $��Microsoft Sans Serif)�6B   5�      5�      5�      5�      