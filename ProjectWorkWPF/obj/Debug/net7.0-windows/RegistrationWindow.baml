   M S B A M L   `   `   `  ����K  GProjectWorkONWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProjectWorkWPFProjectWorkWPF  5   	   E'clr-namespace:ProjectWorkWPF.ViewModelsProjectWorkWPF.ViewModels  5	   R   '    !ProjectWorkWPF.RegistrationWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ProjectWorkWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   8
viewmodels'clr-namespace:ProjectWorkWPF.ViewModels  6R     � Title$  RegistrationWindow��5   	   $	��650��6$   $	��600��61   
������� � 	Resources 5         
labelStyle �� 
TargetType �� Property �� Value  ActiveInputStyle �� Triggers P� Property P� Value��%�  &	        &	 �     �� 5   
   " ��6#   .�5      ��  � ��
 �   �6+   �� 5       � ��$ 25(�6)   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6)    5      P� 5       �@J�	IsFocused$
 True��6/   . �5      ��  � ��
 �   �63   �� 5       � ��
 ��ح�64   �� 5       � ��$ 1q�68   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5       $
��1.2* �6   �� 5!      $
��1.2* �6   �� 5"      $
��1.5* �6   	 � RowDefinitions	 5$   
   �� 5%      �� 5&      $
��0.7* �6   �� 5'      $
��0.7* �6   �� 5(      $
��0.7* �6   �� 5)      $
��0.7* �6   �� 5*      $
��0.7* �6   �� 5+      .+�5.   
   �� $��1��6   $��1��6    $��Username��6-   #��[  6@   �� 5/   
   $��1��6   $��2��6    $��Password��6-   #��[  6@   �� 50   
   $��1��6   $��3��6    $��Confirm��6-   #��[  6?   �� 51   
   $��1��6   $��4��6    $
��Name��6-   #��[  6<   �� 52   
   $��1��6   $��5��6    $��Surname��6-   #��[  6?   �� 54   
   -   5        $��usernameTextBox��54   ,   $��2��6C   $��2��6S   $��1��6g   $��20(�6t   ��6   �� *
Username+6t   G� 56   
   -   5        $��passwordBox1��56   E   $��2��6Y   $��2��6i   $��2��6}   $��20(�6�   �� 57   
   -   5        $��passwordBox2��57   @   $y�Hidden=�6,   $��2��6T   $��2��6d   $��2��6x   $��20(�6�   ��6   �� *
Password+6�   �� 58   
   -   5        $��showPasswordBoxText��58      $��4��6,   $��2��6<   $��60��6I   $��40��6T   $
��👁��6`   
�������$��20(�6�   6�   G� 5:   
   -   5        $��confirmBox1��5:   E   $��2��6X   $��2��6h   $��3��6|   $��20(�6�   �� 5;   
   -   5        $��confirmBox2��5;   ?   $y�Hidden=�6+   $��2��6R   $��2��6b   $��3��6v   $��20(�6�   ��6   �� *	Confirm+6�   �� 5<   
   -   5        $��showConfirmBoxText��5<      $��4��6+   $��3��6;   $��60��6H   $��40��6S   $
��👁��6_   
�������$��20(�6�   6�   �� 5>   
   -   5        $��nameTextBox��5>   (   $��2��6;   $��2��6K   $��4��6_   $��20(�6m   ��6   �� *Name+6m   �� 5?   
   -	   5        $��surnameTextBox��5?   +   $��2��6A   $��2��6Q   $��5��6e   $��20(�6s   ��6   �� *	Surname+6s   �� 5A   
   -
   5        
 ��Name$
 	submitBtn��5A   3   
�������$��6��6Y   $��3��6f   $	��120��6v   $��50��6�   ���	#FF178693$��Submit��6�   $��2��6�   $��25(�6�   ��6   �� *submitCommand+6�   5B      5C      