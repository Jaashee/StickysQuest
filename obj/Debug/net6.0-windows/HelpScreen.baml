   M S B A M L   `   `   `  ����B  >TheGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TheGameTheGame  5          TheGame.HelpScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TheGame     5        N� Title$
  Help��5	       N� WindowHeight$	 450Q�6    N� WindowWidth$	 910Q�6%    N� 
Background
 �   � � 	Resources 5
         DynamicButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName��%J  &	        �� 5   
   " ��6+   .�5      ��  � �� �	#FFF9F9F96+   �� 5       � �� �	#FF0600006+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 2q�60   �� 5       � ��
 �����6,   �� 5       � ��$ 4q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 border��6!   #��z��61   #��z��6]   #��z��6�   $
 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6Q    � ��
 ��ح��� 5   "    � ��
 �   �6?   5      P� 5       � ��$
 True��6;   . �5   "   �� $ border��6L    � ��
 ��  ��� 5    "    � ��
 �����6?   5!      5#      5%      5&      5'      .��5)      � $
��1000��6    � RowDefinitions 5*   
   �� 5+      $
��Auto �6   �� 5,      $��* �6   �� 5-      $
��Auto �6    � ColumnDefinitions 5/   
   �� 50      $��* �6   �� 51      $��* �6   �� 52      $��* �6   .+�56   
   �� $��0��6   $��0��6"    �� Orientation$ Vertical=�62   .+�57      �� -   5         ��Name$ lblPlayerName��57      $�� ��6+   $��16(�66   $
��Bold"�6D   $��Arial)�6V   
�������6i   �� 58      -   5        $ lblPlayerHP��58      $�� ��6)   $��16(�64   $��Arial)�6B   
�������6U   �� 59      -   5        $ lblPlayerSP��59      $�� ��6)   $��16(�64   $��Arial)�6B   
�������6U   �� 5:      -   5        $ lblPlayerMP��5:      $�� ��6)   $��16(�64   $��Arial)�6B   
�������6U   5;      �� 5>   
   -   5        $��lblScore��5>      $��Score =��6    $��0��62   $��1��6?   $��20(�6O   $
��Bold"�6]   $��Arial)�6o   
�������$��Center=�6�   $��Center=�6�   �� 5A   
   $��0��6   $��2��6"   $ Vertical=�62   $��Right=�6I   .+�5B      �� -   5        $ lblEnemyRole��5B      $�� ��6*   $��16(�65   $
��Bold"�6C   $��Arial)�6U   
�������6h   �� 5C      -   5        $ lblEnemyName��5C      $�� ��6*   $��16(�65   $��Arial)�6C   
�������6V   �� 5D      -   5        $ 
lblEnemyHP��5D      $�� ��6(   $��16(�63   $��Arial)�6A   
�������6T   5E      �� 5H   
   -	   5        $��FightCanvas��5H      $
|�True��6$   $��1��65   $��3��6B   .+�5I      �� -
   5        $��
PlayerRect��5I      $	��250��6*   $	��250��67   
��� ��� �� Left$ 66��6Q   $
��Left=�6b   $	��Top=�6}   
 �� Top$ -2��6�    � ToolTip$- 'This box will show the player character��6�   �� 5J      -   5         ��Name$ Weapon��5J      $	��250��6(   $	��250��65   
��� ���$ 66��6O   $ -2��6`   $
��Left=�6p   $	��Top=�6�   �� 5K      -   5        $
 Wand��5K      $	��250��6&   $	��250��63   
��� ���$ 66��6M   $
��Left=�6^   $	��Top=�6y   $ 1��6�   �� 5L      -   5        $	��Hat��5L      $	��250��6#   $	��250��60   
��� ���$ 66��6J   $
��Left=�6[   $	��Top=�6v   $ -4��6�   $- 'This box will show the player character��6�   �� 5M      -   5        $��WinterEnemyRect��5M      $	��250��6/   $	��250��6<   
��� ���$	 612��6V   $
��Left=�6h   $ -4��6�   $	��Top=�6�   $" This box will show the enemy��6�   �� 5N      -   5        $ 	lblReward��5N      $'��!Enemy defeated!  Choose a reward!��6'   $	 370��6S   $ 34��6e   $��Center=�6u   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   
�������$y�Hidden=�6�   5O      � 5R   
   $��2��6   $��0��6!    � Orientation$ 
Horizontal=�61   $��16q�6J   .+�5S      �� -   5        $��	btnAttack��5S      $��Attack��6&   $	��100��67   $��50��6C   $��4q�6P   #��[  6[   $A ;This button will allow you to attack with your melee weapon��6�   �� 5T      -   5         ��Name$ btnAttackWand��5T      $
��Wand��6,   $	��100��6;   $��50��6G   $��4q�6T   #��[  6_   $9 3This button will allow you to attack with your wand��6�   �� 5U      -   5        $ 	btnPotion��5U      $��Potion��6(   $	��100��69   $��50��6E   $��4q�6R   #��[  6]   $0 *This button will allow you to use a potion��6�   �� 5V      -   5        $ btnRest��5V      $
��Rest��6&   $	��100��65   $��50��6A   $��4q�6N   #��[  6Y   $y sAfter depleting your mp or sp this button will enable, allowing you to rest and restore stats, but take more damage��6�   5W      � 5Y   
   -   5         �Name$ wrpNewEquip��5Y      $��1��6)   $��1��66   $ 
Horizontal=�6F   $��51,72,314,0q�6_   $��2��6t   .+�5Z      �� -   5        $��
btnNewWeap��5Z      $�� ��6'   $	��100��62   $��50��6>   $��4q�6K   #��[  6V   $V PAfter defeating an enemy, this button will allow you to pick a single new weapon��6�   �� 5[      -   5        $ 
btnNewWand��5[      $�� ��6)   $	��100��64   $��50��6@   $��4q�6M   #��[  6X   $T NAfter defeating an enemy, this button will allow you to pick a single new wand��6�   �� 5\      -   5        $ btnNewPotion��5\      $�� ��6+   $	��100��66   $��50��6B   $��4q�6O   #��[  6Z   $V PAfter defeating an enemy, this button will allow you to pick a single new potion��6�   �� 5]      -   5        $ btnKeep��5]      $��Keep Equipment��6&   $	��100��6?   $��50��6K   $��4q�6X   #��[  6c   $��10(�6�   $m gAfter defeating an enemy, this button will allow you to return to the fight with your current equipment��6�   5^      �� 5a   
   $��2��6   $��1��6$   $
��Auto=�64   $��4q�6W   $��55��6b   $	��150��6q   $	��150��6�   $	��150��6�   .��5b      �� -   5         ��Name$ txtActionDisplay��5b       �� 
IsReadOnly$
 True��64   
���   �
�������$��14(�6l   $��Medium"�6z   $��4q�6�   $	��100��6�   $	��150��6�   $	��325��6�    J� RenderTransformOrigin$ 0.473,0.432&�6�   $@ :This box will tell the player what they, and the enemy did��6�   . �5c      /� .T�5d      J� -   5         J�Name$ txtActionDisplayParagraph��5d       5e      5f      5g      �� 5l   
   -   5        $��btnBack��5l      $��Return to options��6    $��2��6<   $��2��6I   $��36��6Y   $	��121��6e   $��Center=�6�   $	��Top=�6�   $��0,79,0,0q�6�   #��[  6�   $��10(�6�   �� 5m   
   -   5        $ lblinstruction��5m      $.��(Hover over elements to see what they do.��6(   $��0��6[   $��20(�6h   $
��Bold"�6v   $��Arial)�6�   
�������$
��Left=�6�   $	��Top=�6�   $��3��6�   $��
329,57,0,0q�6�   $��47��6	  $	��416��6  5n      5o      