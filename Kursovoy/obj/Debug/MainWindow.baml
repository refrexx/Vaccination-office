   M S B A M L   `   `   `  ����C  ?Kursovoy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KursovoyKursovoy  5   	       Kursovoy.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Kursovoy     5   	     � Icon$  \img\logo.png��5   	    � Title$+ %Прививочный кабинет��5	   	   $	��450��6%   $	��800��65   .��5
      �  � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $	��60* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   
����ح�65   � 5   
   $��2��6   
����ح�65   �� 5   
   $��\img\logo.png��6   $��15,0,0,0q�6'   $	��100��69   $
��Left=�6E   6b   �� 5   
   -   5        $��BtnBack��5      $��0,0,15,0q�5      $��
Назад��6#   $	��150��63   $��40��6?   
�������$��Right=�6^   5   7   �� 5   
      BlockHeader#��[  6   ��69   ��  �� ElementName$ 	FrameMain�� �� Path$ Content.Title�6v    � 5   
   -   5          �Name$ 	FrameMain��5        � NavigationUIVisibility$ Hidden=�6#   $��1��6C   6R   5      5      