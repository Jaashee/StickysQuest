   M S B A M L   `   `   `  ����B  >TheGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TheGameTheGame  5          TheGame.OptionsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TheGame     5        N� Title$  OptionsPage��5	      .��5      �  � 	Resources 5   
      RoundedButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value��%v  &	        �� 5      " ��6*   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $ border��6%   #��z��65   $ 5��6_   #��z��6p   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   #��z��6k   5      5      5      �� 5       � ��$ 18(�6-   �� 5       � ��$
 Bold"�6/   �� 5       � ��$ 20,10q�6,   �� 5       � �� �	#FF6F6F6F6/   �� 5       � ��
 �����6/   �� 5       � ��$ 0q�64    5      P� 5      	 �@J�IsMouseOver$

 True��65   . �5      ��  � �� �	#FFFF333367   5       5"      5#      .+�5$   
   �� $��Options��6   $��60(�6#   $
��Bold"�61   ���	#FFFF3333$��Center=�6Z   $	��Top=�6w   $��0,50,0,0q�6�    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         Color$ Black��6#      	Direction$	 320Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.8Q�6Q      
BlurRadius$ 8Q�6_   5(      �� 5)   
   $��Center=�6   $��Center=�62   .+�5*      �� $��Volume��6   $��16(�6&   $
��Bold"�64   $��Center=�6F   $��0,0,0,10q�6c   �� 5+      -   5         ��Name$ volumeSlider��5+       � Minimum$ 0Q�6+    � Maximum$ 1Q�67    � Value$ 1Q�6C    � LargeChange$	 0.1Q�6M    � SmallChange$
 0.01Q�6_    �� TickFrequency$	 0.1Q�6r    �� IsSnapToTickEnabled$
 True��6�    �� Orientation$ 
Horizontal=�6�   $	��200��6�   $��0,0,0,20q�6�   6�   �� 5,      -   5         ��Name$ volumePercentage��5,      $��16(�62   $
��Bold"�6@   $��Center=�6R   5-      �� 5.   
   -   5         ��Name$ btnBack��5.      $
��Back��6"   $
��Left=�61   $��	20,0,0,20q�6L   $��Bottom=�6_   #��[  6�   �� 5/   
   -   5        $ btnHelp��5/      $
��Help��6"   $��Center=�61   $��	0,382,0,0q�6N   $	��Top=�6a   #��[  6�   �� 51   
   -   5        $ btnQuit��51      $
��Quit��6"   $��Right=�61   $��	0,0,20,20q�6M   $��Bottom=�6`   #��[  6�   52      53      