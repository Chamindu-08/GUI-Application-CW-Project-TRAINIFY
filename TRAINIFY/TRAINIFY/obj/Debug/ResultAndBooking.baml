   M S B A M L   `   `   `  ����C  ?TRAINIFY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TRAINIFYTRAINIFY  5   	       TRAINIFY.ResultAndBooking   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TRAINIFY     5   	     � Title$  ResultAndBooking��5   	   $	��700��6"   $	��800��6/   .��5	      � ��5
   
   �� 5       �� ImageSource$$ /2024_01_05_08_07_IMG_4677.JPG��6    �� Opacity$
 0.25Q�6F   .+�5   
   �� ���	#FF002250$	��200��6,    �� Orientation$ Vertical=�68   $
��Left=�6O   $	��Top=�6j   .+�5      � $��50��6   $	��Top=�6   $��0,30,0,0q�67   .+�5      �� $
��MENU��6   
�������$��Center=�6;   $��OCR A Extended)�6X   $��40(�6t   $��Center=�6�   6�   5      o� 5      $	��610��6   
������ $	��200��69   $��Center=�6E   $��Center=�6b   ��5      �� 5      .R�5      $�  $� Orientation$ Vertical=�61   5      .@�5      m� -   5         m�Name$ menuItemHome��5      $
��Home��61   $	��100��6?   $��50��6K   
�������$��Times New Roman)�6j   $��20(�6�    m� Icon 5      �� 5      $��icon/home.png��6    $
��Fill=�67   5      m� 5      -   5        $ menuItemSearch��5      $��Search��63   $	��100��6C   $��50��6O   
�������$��Times New Roman)�6n   $��20(�6�    5      �� 5       $��icon/search.png��6    $
��Fill=�69   5"      m� 5$      $��Booking��6   $	��100��6,   $��50��68   
�������$��Times New Roman)�6W   $��20(�6t    5%      �� 5&      $��icon/cursor-finger.png��6    $
��Fill=�6@   .@�5)      m� -   5        $ menuItemViewBooking��5)      $��View Booking��6<   ���	#FF002250
�������$��Times New Roman)�6|   $��20(�6�    5*      �� 5+      $��icon/overview.png��6$   $
��Fill=�6?   5-      m� 5/      -   5        $ menuItemEditBooking��5/      $��Edit Booking��6<   ���	#FF002250
�������$��Times New Roman)�6|   $��20(�6�    50      �� 51      $��icon/user-pen.png��6$   $
��Fill=�6?   53      m� 55      -   5        $ menuItemDeleteBooking��55      $��Delete Booking��6>   ���	#FF002250
�������$��Times New Roman)�6�   $��20(�6�    56      �� 57      $��icon/trash.png��6$   $
��Fill=�6<   59      5:      m� 5<      $��Profile��6   $��50��6,   
�������$��Times New Roman)�6K   $��20(�6h   $��	50,0,50,0q�6v    5=      �� 5>      $��icon/user.png��6    $
��Fill=�67   .@�5A      m� -   5        $ menuItemViewProfile��5A      $��View Profile��6<   ���	#FF002250
�������$��Times New Roman)�6|   $��20(�6�    5B      �� 5C      $��icon/overview.png��6$   $
��Fill=�6?   5E      m� 5G      -   5        $ menuItemEditProfile��5G      $��Edit Profile��6<   ���	#FF002250
�������$��Times New Roman)�6|   $��20(�6�    5H      �� 5I      $��icon/user-pen.png��6$   $
��Fill=�6?   5K      5L      m� 5N      -   5        $ menuItemContactUs��5N      $��
Contact Us��66   $	��120��6J   $��50��6V   
�������$��Times New Roman)�6u   $��20(�6�    5O      �� 5P      $��icon/phone-call.png��6    $
��Fill=�6=   5R      5T      5U      �� 5V   
   $��TRAINIFY��6   $
��Left=�6#   $��65��6>   $��
357,10,0,0q�6J   $	��Top=�6^   $	��274��6v   $��Center=�6�   $��Center=�6�   $��RightToLeft=�6�   $��45(�6�   $��	Castellar)�6�   $
��Bold"�6	  �� 5W   
   $
��Left=�6   $	��500��6/   
���   �$	��Top=�6K   $	��500��6c    � UseLayoutRounding .  $��244,140,0,0q�6�   ��5X      �� 5Y       �� Color$ 	#FFC9C7A9��6"   $	 0.5Q�66   5[      A� 5\   
   $
��Left=�6   $	��110��6-   $��
439,86,0,0q�6:   
���   �$	��Top=�6]   $	��110��6u   ��5]      �� 5^      ��5`      �� 5a      $$ /2024_01_03_21_12_IMG_4655.PNG��6   5c      �� 5d   
   $��Train :��6   $
��Left=�6"   $��324,402,0,0q�6=   $	��Top=�6R   $��Times New Roman)�6j   $��20(�6�   $��30��6�   $	��120��6�   �� 5e   
   $
��Left=�6   $��26��6/   $��294,402,0,0q�6;   $	��Top=�6P   $��25��6h   	 J� RenderTransformOrigin$	 1.076,0.564&�6s   ��5f      �� 5g      $ /train-station.png��6   5i      �� 5j   
   -	   5        
 ��Name$
 cmbBoxTrain��5j       �� SelectedIndex$ 0��6(   $
��Left=�6:   $��324,437,0,0q�6U   $	��Top=�6j   $	��110��6�   $��30��6�   $	 0.403,0.035&�6�   $��Center=�6�   $��Center=�6�   $��Times New Roman)�6  $��16(�6!  .@�5k      �� $��-SELECT-��6   5l      �� 5m   
   -
   5         ��Name$ 
btnBookNow��5m         RoundedButtonStyle#��[  6%   $��BOOK NOW��6Q   $
��Left=�6d   $��50��6   $��317,552,0,0q�6�   $	��Top=�6�   $	��180��6�   $��25(�6�   #��� ��6�   $��Times New Roman)�6  $
��Bold"�63  6E  A� 5n   
   $
��Left=�6   $	��110��6-   $��
45,530,0,0q�6:   
���   �$	��Top=�6]   $	��110��6u   ��5o      �� 5p      ��5r      �� 5s      $$ /2024_01_03_21_12_IMG_4655.PNG��6   5u      �� 5v   
   -   5        $ 	btnCancel��5v      #��[  6$   $��CANCEL��6P   $
��Left=�6a   $��50��6|   $��525,552,0,0q�6�   $	��Top=�6�   $	��180��6�   $��25(�6�   #��� ��6�   $��Times New Roman)�6  $
��Bold"�60  6B  &   System.Windows.Controls.DataGrid  5w   
   -   5          Name$ dataGridTrainDetails��5w      $
��Left=�61   $	��150��6L   $��294,222,0,0q�6Y   $	��Top=�6n   $	��400��6�   �� 5x   
   $��Time :��6   $
��Left=�6!   $��324,473,0,0q�6<   $	��Top=�6Q   $��Times New Roman)�6i   $��20(�6�   $��30��6�   $	��120��6�   �� 5y   
   $
��Left=�6   $��26��6/   $��294,473,0,0q�6;   $	��Top=�6P   $��25��6h   $	 1.076,0.564&�6s   ��5z      �� 5{      $ 
/clock.png��6   5}      �� 5~   
   -   5        $
 
cmbBoxTime��5~      $ 0��6'   $
��Left=�69   $��324,508,0,0q�6T   $	��Top=�6i   $	��110��6�   $��30��6�   $	 0.403,0.035&�6�   $��Center=�6�   $��Center=�6�   $��Times New Roman)�6  $��16(�6   .@�5      �� $��-SELECT-��6   5�      �� 5�   
   $��	Tickets :��6   $
��Left=�6$   $��554,404,0,0q�6?   $	��Top=�6T   $��Times New Roman)�6l   $��20(�6�   $��30��6�   $	��120��6�   �� 5�   
   $
��Left=�6   $��26��6/   $��524,406,0,0q�6;   $	��Top=�6P   $��25��6h   $	 1.076,0.564&�6s   ��5�      �� 5�      $ /money-check.png��6   5�      �� 5�   
   -   5         ��Name$ CheckBox1Class��5�      $��	1st Class��6+   $
��Left=�6?   $��20��6Z   $��554,437,0,0q�6f   $	��Top=�6{   $��80��6�   $��Times New Roman)�6�   $��15(�6�   �� 5�   
   -   5        $ CheckBox2Class��5�      $��	2nd Class��6+   $
��Left=�6?   $��20��6Z   $��554,462,0,0q�6f   $	��Top=�6{   $��80��6�   $��Times New Roman)�6�   $��15(�6�   �� 5�   
   -   5        $ CheckBox3Class��5�      $��	3rd Class��6+   $
��Left=�6?   $��20��6Z   $��554,486,0,0q�6f   $	��Top=�6{   $��80��6�   $��Times New Roman)�6�   $��15(�6�   �� 5�   
   -   5         ��Name$ 	txt1Class��5�      $
��Left=�6%   $��644,437,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��50��6�   $��20��6�   �� 5�   
   -   5        $ 	txt2Class��5�      $
��Left=�6%   $��644,462,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��50��6�   $��20��6�   �� 5�   
   -   5        $ 	txt3Class��5�      $
��Left=�6%   $��644,486,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��50��6�   $��20��6�   �� 5�   
   $��Trains��6   $
��Left=�6!   $��294,173,0,0q�6<   $	��Top=�6Q   $��Times New Roman)�6i   $��20(�6�   $��30��6�   $	��120��6�   $
��Bold"�6�   5�      5�      