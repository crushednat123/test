   M S B A M L   `   `   `  ����  Library'    !Library.Start.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          �Name$  window��5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5	       � AllowsTransparency . 
������ $	��550��5   _   $	��500��6l   .��5      � .+�5   
   �� -   5         ��Name$ border��5   #    �� CornerRadius$ 10��6   |�. ��5      �� 5       �� 
StartPoint$	 1,0&�6    �� EndPoint$	 0,1&�6+   .��5      �    DarkBlueTopRightColor � Color# [  6   	 � Offset$	 0Q�6C   � 5        DarkBlueBottomLeftColor# [ 6   $	 1Q�6E   5      5      !  FontAwesome.Sharp.IconImage  5   
   $��28��6   $	��Top=�6#   $
��Left=�6;   �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]
   Icon$
 DoorOpen=�6V   $��25��5         
Foreground �#7071f0$��7 10 0 0q�6)   �� 5      $��Авторизация��6     titlePogram#��[ 6!   $��
47 10 0 10q�6F   � 5      .+�5      �� -   5         ��Name$ btnExit��5   "   $��5��6   $	��Top=�63    � ToolTip$ Закрыть��6K     btnCrossAndRollUp#��[ 6s   .��5        $
 PowerOff=�6      fa:IconImageTopButton#��[ 60   5      �� 5      -   5        $ 20��5      
����  �$��2q�5!      $��Center=�5"      $��Center=�5#   
   $	��280��6W   $	��320��6c   ��5%      �� 5'      .��5)      � $ #CEE3FF��6   $		 0.2Q�6%   64   � 5*      $ #E0FFFF��6   $		 0.7Q�6%   64   5+      ._�5.      �� $��Center=�6   $
��auto��68   $
��auto��6E   $��Center=�6S   $��0 0 0 20q�6p   .+�50      �� $��Center=�6   $��0 0 0 30q�6.   $��18(�6A   Авторизация6\   �� 54      -   5        $��tBLogin��54   �   $��0��6     TextBox#��[ 6W   $��0 10 0 0q�6x   $	��230��6�   6�     56      -   5          Name$ 	iconLogin��56   #   $
 UserAlt=�66   $
��Left=�6E   
 �����$��
10 -30 0 0q�6r   �� 58      -   5         ��Name$ Placeholder��58        J� IsHitTestVisible .  $
��Wrap=�59      $��
Логин��5:      $��
35 -30 0 0q�5;      $��Center=�5=      
�������$
��Left=�5?      ��5A      �� 5B       �� 
TargetType" ��6$   .�5C   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?   �� 5D   "    � ��$ Comic Sans MS)�6@   �� 5E   "    � ��$
 Bold"�6?    �� Triggers 5F   "   �� 5G   &    �� Binding 62   �� *Text+ �� ElementName$ tBLogin�� �� Value  6`   .a�5H   *   ��  � y�$ Visible=�6G   5I   '   5K      5M      �� 5Q      $��Right=�6    $��	0 0 10 20q�6<   ��5R      �� 5T   	   " ��6   .�5U   
   ��  � ��$ Comic Sans MS)�6(   �� 5V   
    � ��$
 Bold"�6'    5W   
   �� 5X       6   �� *Text.Length+$ tBLogin�� 246L   .a�5Y      ��  � ��
 �  ��6)   5Z      5\   
   �� 5^      �6   �� *Text.Length+$ tBLogin�� �� Mode$ OneWay=�/�� 6N   �6R   �� *	MaxLength+$ tBLogin��5_      G� 5a      -   5        $��
pBPassword��5a   �   $��1��6"   $	��230��6�   �� 5b      -	   5         ��Name$ 
tBPassword��5b   ~   $��2��6   #��[ 6�   $	��230��6�   $y�	Collapsed=�6�     5d      -
   5        $ iconPassword��5d   #   $

 Lock=�69   $
��Left=�6E   
 �����$��
10 -30 0 0q�6r   �� 5e      -   5        $ textBlockPassword��5e       $y�Visible=�6;   $��Пароль��5f      $��
35 -30 0 0q�5g      $��Center=�5h      
�������$
��Left=�5j      �� 5l      -   5        $
��text��5l   <   $��Right=�6    $��0 0 10 0q�6H   /245n      �� 5o      -   5        $ pasText��5o      $��Right=�6"   $��
0 -17 31 0q�6>   05r      �� 5t      -   5         ��Name$ checkPassword��5t   Y   $��3��6   {�.  $#��Показать пароль��6?   6�   �� 5w      -   5        $��btnVhod��5w   ^   $��4��6   $��0 20 0 0q�6*   $	��230��6<   $��
Войти��6n    �� 	IsDefault . 6~   5{      5}      5      5�      5�      