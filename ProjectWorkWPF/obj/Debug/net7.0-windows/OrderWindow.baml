   M S B A M L   `   `   `  ����K  GProjectWorkONWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjectWorkONWPFProjectWorkONWPF  5   	   "    ProjectWorkONWPF.OrderWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjectWorkONWPF     5   	     � Title$  OrderWindow��5   	   $	��550��6   $	��600��6*   
����ح� � 	Resources 5
         
labelStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6#   .�5      ��  � ��
 �   �6+   �� 5       � ��$ 25(�6)   �� 5       � ��$ Center=�62   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      $
��1.2* �6   �� 5      $
��1.2* �6   �� 5      $
��1.5* �6    � RowDefinitions 5   
   �� 5      �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      .+�5"   
   �� $��1��6   $��1��6    $
��Name��6-   #��[  6<   �� 5#   
   $��1��6   $��2��6    $��Product��6-   #��[  6?   �� 5$   
   $��1��6   $��3��6    $��Quantity��6-   #��[  6@   �� 5%   
   $��1��6   $��4��6    $��
ArriveTime��6-   #��[  6B   �� 5'   
   -   5        $��nameComboBox��5'   w   
�������$��Stretch=�6�   $��Stretch=�6�   $��2��6�   $��2��6�   $��1��6�   $��25(�6�   ��6*   �� *	Clients+ �� Mode$ TwoWay=� �� SelectedItem 6W   �� *Client+6�   �� 5(   
   -   5        $��productComboBox��5(   y   
�������$��Stretch=�6�   $��Stretch=�6�   $��2��6�   $��2��6�   $��2��6�   $��25(�6�   ��6*   �� *
Products+$ TwoWay=� 6X   �� *	Product+6�   �� 5)   
   -   5        $��quantityTextBox��5)   ,   $��2��6C   $��2��6S   $��3��6g   $��25(�6t   ��6   �� *
Quantity+6t   (  "System.Windows.Controls.DatePicker  5*   
   -   5        $��arriveTimeTextBox��5*   �   $��Stretch=�69   $��Stretch=�6U   
�������$��2��6�   $��2��6�   $��4��6�   $��25(�6�   	   SelectedDate	 6   �� *
ArriveTime+6�   �� 5,   
   
�������$��6��6D   $��3��6Q   $	��120��6a   $��50��6m   ���	#FF178693$
��Save��6�   $��2��6�   $��25(�6�   ��6   �� *saveCommand+6�   5-      5.      