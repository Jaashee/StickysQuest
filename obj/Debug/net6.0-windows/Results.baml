   M S B A M L   `   `   `  ����B  >TheGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TheGameTheGame  5          TheGame.Results   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TheGame     5        N� Title$  Results��5	      .��5      � ���#F0F0F0 � 	Resources 5   
      RoundedButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value��%v  &	        �� 5      " ��6*   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $ border��6%   #��z��65   $ 5��6_   #��z��6p   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   #��z��6k   5      5      5      �� 5       � ��$ 18(�6-   �� 5       � ��$
 Bold"�6/   �� 5       � ��$ 20,10q�6,   �� 5       � �� �	#FF6F6F6F6/   �� 5       � ��
 �����6/   �� 5       � ��$ 0q�64    5      P� 5      	 �@J�IsMouseOver$

 True��65   . �5      ��  � �� �	#FFFF333367   5       5"      5#      .+�5%   
   �� $��Results��6   $��60(�6#   $
��Bold"�61   ���	#FFFF3333$��Center=�6Z   $	��Top=�6w   $��79��6�   $	��210��6�    J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         Color$ Black��6#      	Direction$	 320Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.8Q�6Q      
BlurRadius$ 8Q�6_   5)      � 5+   
    � RowDefinitions 5,      �� 5-      $
��Auto �6    �� 5.      $��* �6    �� 5/      $
��Auto �6    .+�52      � $��1��6    � ColumnDefinitions 53      �� 54      $	��59* �6'   �� 55      $	��42* �6'   �� 56      $	��59* �6'   .+�59      �� $��0��6   $
��Left=�6-   $	��Top=�6H   $��	75,26,0,0q�6`   $��0��6s   $��0��6~   �� 5:      -   5         ��Name$ 
PlayerRect��5:      
��� ���$��28,80,27,39q�6>   �� 5;      -   5        $ RectPlayerHat��5;      
��� ���$��28,80,27,39q�6A   �� 5?      $��2��6   $
��Left=�6-   $��Center=�6H   $��98,0,0,0q�6c   $��0��6u   $��0��6�   �� 5A      $��Score:��6   $
��Bold"�6)   $��24(�6;   $��65,70,65,259q�6I   $��1��6_   �� 5B      -   5         ��Name$ txtPlayerScore��5B      $��Center=�62   $��	0,115,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��29��6�   $��1��6�   �� 5D      -   5         ��Name$ 	lblResult��5D      $��Victory��6+   $��Center=�6=   $	��Top=�6Z   $��36(�6r   $
��Bold"�6�   ���	#FF01A40B$��0��6�   ���	#FF1E1E1E$��20,10q�6�   $��	0,184,0,0q�6�   $��1��6�   $��68��6   $	��162��6  �� 5E      $��Player��6   $
��Bold"�6)   $��24(�6;   $��107,33,107,294q�6I   �� 5F      -   5        $ 	EnemyRect��5F      
��� ���$��2��6=   $��24,77,24,43q�6M   �� 5G      $��Enemy��6   $
��Bold"�6(   $��24(�6:   $��2��6H   $��103,33,103,294q�6X   5I      �� 5K      $��2��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $��Bottom=�6\   $��0,0,0,20q�6w   .+�5L      �� -   5         ��Name$ btnScore��5L      $��View Scoreboard��6+   #��[  6\   $��10,40,10,10q�6�   $	��200��6�   �� 5M      -   5        $ btnStagePlay��5M      $��View Stageplay��6/   #��[  6\   $��10,40,10,10q�6�   $	��200��6�   �� 5N      -   5        $ btnContinue��5N      $��Back to Main Menu��6.   #��[  6d   $��10,40,10,10q�6�   $	��200��6�   5O      5P      5Q      5R      