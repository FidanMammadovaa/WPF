   M S B A M L   `   `   `  ����K  GProjectWorkONWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProjectWorkWPFProjectWorkWPF  5   	   E'clr-namespace:ProjectWorkWPF.ViewModelsProjectWorkWPF.ViewModels  5   	        ProjectWorkWPF.LoginWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ProjectWorkWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   8
viewmodels'clr-namespace:ProjectWorkWPF.ViewModels  5   	     � Title$  LoginWindow��5
   	   $	��450��6   $	��800��6*      DarkWindowStyle#��[  5   	    � 	Resources 5        myButtonStyle �� 
TargetType �� Property �� Value  myLabelStyle��%  &	       &	 �     �� 5   
   " ��6&   .�5      ��  � ��$
 25px(�6)   �� 5       � ��
 ��+��6+   �� 5       � ��
 �����6+   5      �� 5   
   " ��6%   .�5      ��  � ��
 �����6+   �� 5       � ��$
 30px(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      �� 5      �� 5      �� 5      $��1* �6    � RowDefinitions 5    
   �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      .+�5*   
   �� $��Center=�6   $��2��6-   $��1��6:   $��3��6J   #��[ 6^   $��Welcome to the program��6�   �� 5+   
   $��3��6   $��1��6   $��Username��6-   #��[ 6@   �� 5,   
   $��4��6   $��1��6   $��Password��6-   #��[ 6@   �� 5-   
   -   5        $��usernameTextBox��5-   ,   $��3��6C   $��2��6P   $��2��6`   $��20(�6t   ��6   �� *
Username+6t   �� 5/   
   -   5        $��passwordTextBox��5/   @   $y�Hidden=�6,   $��4��6W   $��2��6d   $��2��6t   $��20(�6�   ��6   �� *
Password+6�   G� 50   
   -   5        $��passwordBox��50   D   $��4��6W   $��2��6d   $��2��6t   $��20(�6�   �� 51   
   -   5        $��showPasswordBoxText��51      $��4��6N   $��4��6^   $��60��6k   $��40��6v   $
��👁��6�   $��20(�6�   #��[ 6�   �� 53   
   -   5        $��	signUpBtn��53      $��6��6"   $��1��6/   $��Sign up��6?   #��[ 6Q   6x   �� 54   
   -   5        $��	signInBtn��54   2   $��6��6C   $��3��6P   $��Sign in��6`   #��[ 6r   ��6   �� *loginCommand+6r   59      5:      