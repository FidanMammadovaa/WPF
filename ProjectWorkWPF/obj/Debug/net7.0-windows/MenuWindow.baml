   M S B A M L   `   `   `  ����K  GProjectWorkONWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjectWorkONWPFProjectWorkONWPF  5   	   !    ProjectWorkONWPF.MenuWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjectWorkONWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MenuWindow��5   	   $	��450��6   $
��1200��6)      DarkWindowStyle#��[  5
   	   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��5* �6   .+�5   
   o� $	��Top=�6   $��20(�6$   $��0��62   .@�5      m� $��Client��6   .@�5      m� -   5        $��addClientButton��5   (   $	��Add��6   6?   m� 5      -   5        $��listClientButton��5   )   $
��List��6   6A   5      m� 5      $��Order��6   .@�5      m� -   5        $��addOrderButton��5   (   $	��Add��6   6>   m� 5      -   5        $��listOrderButton��5   )   $
��List��6   6@   5      m� 5      $��Product��6   .@�5      m� -   5        $��addProductButton��5   (   $	��Add��6   6@   m� 5      -   5        $��listProductButton��5   )   $
��List��6   6B   5      m� 5      -   5        $��logOut��5   (   $��Log Out��6   66   5      �� 5    
   -   5         ��Name$ 
clientView��5    .   $��1��6   $��20(�6     �� View 5!      �� 5"      .P�5#      �� $
��Name��6%    �� Width$	 170��63    �� DisplayMemberBinding 6?   �� *Name+�� 5$      $��Surname��6%   $	 200��66    6B   �� *	Surname+�� 5%      $��Email��6%   $	 220��64    6@   �� *Email+�� 5&      $��Phone��6%   $	 200��64    6@   �� *PhoneNumber+�� 5'      $��Address��6%    66   �� *	Address+5(      5*      �� 5+   
   -	   5        $ 	orderView��5+   B   $��1��6   $��20(�6    $y�Hidden=�6.    5,      �� 5-      .P�5.      �� $
��Name��6%   $	 200��63    6?   �� *Client+�� 5/      $��Product��6%   $	 200��66    6B   �� *	Product+�� 50      $��Quantity��6%   $	 200��67    6C   �� *
Quantity+�� 51      $��
ArriveTime��6%   $	 200��69    6E   �� *
ArriveTime+52      54      �� 56   
   -
   5        $ productView��56   B   $��1��6   $��20(�6    $y�Hidden=�6.    57      �� 58      .P�59      �� $
��Name��6%   $	 150��63    6?   �� *Name+�� 5:      $��Price��6%   $	 150��64    6@   �� *Price+�� 5;      $��Quantity��6%   $	 180��67    6C   �� *
Quantity+�� 5<      $��Description��6%   $	 180��6:    6F   �� *Description+5=      5?      5@      5A      