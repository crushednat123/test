   M S B A M L   `   `   `  ����  Library.    (Library.Pages.PageStudent.StartSchoolboy   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          �Name$  startWindow��5   	   $	��660��5   	   $
��1300��6   $	��800��6#   $	��550��62    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � 
ResizeMode$ CanResizeWithGrip=�5   	   .��5      � $��6.9 0 6.4 0q�6   .+�5   
   � $��-0.5 0 -9 -2q�6    � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      .+�5      ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6*    �� EndPoint$ 0.5,1&�6=   .��5      �    DarkBlueTopColor	 � Color#	 [  6'   
 � Offset$
 0Q�6Q   � 5        DarkBlueBottomColor#	 [ 6'   $
 1Q�6T   5      ._�5"      �� .+�5#      ��  �� Orientation$ 
Horizontal=�6!   .+�5%      �� $��/Resources/Logo.png��6    $��48��6=   $
��Left=�6H   $��15 5 0 0q�6c   �� 5'      $��Библиотека��6$     titlePogram#��[ 66   $��
10 15 0 10q�6[   5(      �� 5*        separatorLeft#��[ 6!   $��
20 10 20 0q�6H   �� 5,      $ 
Horizontal=�6!   $��Center=�6:   $��0 35 0 0q�6W   .+�5-      �� $ 10��6!   $��40��63   $��40��6>   ��5.      �� 5/   "   $	 0,0&�66   $	 1,2&�6G   .��50   &   �   TopFrame#	 [ 63   $
 0Q�6U   � 51   &     BottomFrame#	 [ 63   $
 1Q�6X   52   #   ._�55      �� -   5         ��Name$ Char1NameAndSurName��55   (   $�� ��6E     tbNameAndSurname#��[ 6M   56      �� 58      $��10 0 0 0q�6%   $��Center=�67   .+�59      �� -   5        $ NameAndSyrName��59   (   $�� ��6@     tbNameSurname#��[ 6H   �� 5:      -   5        $ tbRole��5:   (   $�� ��68     tbNumberVersion#��[ 6@   6k   5;      5=      �� 5?      #��[ 6    �� 5C      -   5         ��Name$ stackPanelMenu��5C   !   .+�5E      �� -   5         ��Name$ btnMain��5E   H    	 btnMenuActive#��[	 6!   .��5F      �� $ 
Horizontal=�6)   .+�5G   "   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6/    
 fa:IconImage#��[
 6;   �� 5I   "   $��Главная��6,     menuButtonText#��[ 6;   5J      5L      �� 5N      -   5        $ btnBooks��5N   B     btnMenu#��[ 6!   .��5O      �� $ 
Horizontal=�6)   .+�5P   "     $ BookOpen=�6/   #��[
 6?   �� 5R   "   $��
Книги��6,   #��[ 69   5S      5U      �� 5V      -   5        $ 
btnMyBooks��5V   B   #��[ 6!   .��5W      �� $ 
Horizontal=�6)   .+�5X   "     $
 Book=�6/   #��[
 6;   �� 5Y   "   $��Мои книги��6,   #��[ 6=   5Z      5\      �� 5`      -	   5        $ btnBack��5`   Y   $y�	Collapsed=�6!   #��[ 68   .��5a      �� $ 
Horizontal=�6)   .+�5b   "     $ 	ArrowLeft=�6/   #��[
 6@   �� 5c   "   $��
Назад��6,   #��[ 69   5d      5f      �� 5h      -
   5        $ btnExitZapic��5j      #��[ 5h   !   .��5k      �� $ 
Horizontal=�6)   .+�5l   "     $ DoorOpen=�6/   #��[
 6?   �� 5m   "   $��
Выход��6,   #��[ 6:   5n       � ToolTip 5o      _� 5p   "   $(��"Выйти из уч. записи��6*   $	��150��6H   5r      5s      5t      5u      �� 5x      -   5        $��1��5x      $ 	0 10 10 0��6'   ��5y      �� 5z      $	 1,0&�6*   $	 0,1&�6;   .��5{      �   DarkBlueTopRightColor#	 [ 6'   $
 0Q�6V   � 5|        DarkBlueBottomLeftColor#	 [ 6'   $
 1Q�6X   5}      ._�5      �  � RowDefinitions 5�      �� 5�      $��* �6(   .+�5�       � -   5          �Name$ 
startFrame��5�      $��0 35 0 0q�60     � NavigationUIVisibility$ Hidden=�6o   5�      �� 5�      $ 
Horizontal=�6!   $	��Top=�6:   $��Right=�6R   $��0 0 10 0q�6n   .+�5�      �� -   5        $ 	btnRollUp��5�   !   $ Свернуть��64     btnCrossAndRollUp#��[ 6_   .��5�        $ Minus=�6+   $��5��68     fa:IconImageTopButton#��[ 6C   5�      �� 5�      -   5        $ 	btnExpand��5�   !   #��[ 6L   .��5�        -   5          Name$ 
iconExpand��5�   +   $ ExpandArrowsAlt=�6@   #��[ 6W    5�      _� 5�   "   $��Развернуть��6*   $	��150��6?   5�      �� 5�      -   5        $ btnExit��5�   !   $ Закрыть��62   #��[ 6Z   .��5�        $ PowerOff=�6+   #��[ 6;   5�      5�      5�      5�      5�      5�      5�      