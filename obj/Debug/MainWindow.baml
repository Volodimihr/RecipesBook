   M S B A M L   `   `   `  ����X  TRecipe_book_ExamWPF_Karvatyuk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Recipe_book_ExamWPF_KarvatyukRecipe_book_ExamWPF_Karvatyuk  5   	   a5clr-namespace:Recipe_book_ExamWPF_Karvatyuk.Converter'Recipe_book_ExamWPF_Karvatyuk.Converter  5   	   .    (Recipe_book_ExamWPF_Karvatyuk.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Recipe_book_ExamWPF_Karvatyuk     5   	   K	converter5clr-namespace:Recipe_book_ExamWPF_Karvatyuk.Converter     5   	   -   5          �Name$
  main��5	   	   
������� � Title$ Recipes Book��5   	   $��16(�6   $	��450��6,   $	��620��69    � 	Resources 5      M   GRecipe_book_ExamWPF_Karvatyuk.Converter.ByteArrayToBitmapImageConverter   byteToImageConverterN   HRecipe_book_ExamWPF_Karvatyuk.Converter.StringDocToFlowDocumentConverter  strToFlowDocConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   &	        &	      '�� &       5   
   6M     5   
   6N   �� 5   
   " ��6   .�5      ��  � ��$ Normal"�6+    5      P� 5       �@��
IsSelected . . �5      ��  � ��$
 Bold"�63   5      5      5      .��5      � $��Stretch=�6   $��Stretch=�6)   	 � ColumnDefinitions	 5   
   �� 5      $
��auto �6   $	��256��6,   6=   �� 5      6!   .+�5   
   �� $��0��6   
���   �$��1q�65   ._�5      � 
 � RowDefinitions
 5      �� 5       $
��auto �6$   64   �� 5!      $
��auto �6$   64   �� 5"      $��* �6$   61   �� 5#      $
��auto �6$   64   .+�5%      �� $��0��6   
���   �$
��0, 1q�6:   ._�5&      � $��0��6   	 5'      �� 5(      $
��auto �6/   6>   �� 5)      $��* �6/   6;   .+�5+      �� $��0��6$   $��Search: ��64   $
��Bold"�6D   $��2q�6V   6c   �� 5,      -   5         ��Name$ tbFilter��5,   2   $��1��6"   
�������$��32��6\   $�� ��6k   $��2q�6�   6�   5-      5.      �� 5/      $��1��6   
���   �$��1q�6:   ._�50      �� -   5         ��Name$ cbCountries��50      $��32��64   
�������$��2q�6}    �� SelectedIndex 6[   �� *	CbIndex+��6�   �� *	Countries+ �� UpdateSourceTrigger$ PropertyChanged=�6�   51      �� 52      $��2��6   
���   �$��1q�6:   ._�53      �� -   5         ��Name$ listView��53      $ 1��61   
���������6[   �� *	Recipes+$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedRecipe+$ PropertyChanged=���54      �� 55      .R�56   "   �� $��0q�6h   ��6,   �� *Title+$ PropertyChanged=�6h   57      59      5:      �� 5;      $��3��6   
���   �$��1q�6:   ._�5<      � 	 5=      �� 5>      61   �� 5?      61   �� 5@      61   .+�5B      �� $��0��6'   69   �� 5C      -   5        $��0��5C   !   $��32��61   $��2q�6@   $	��Add��6K   6s   �� 5D      -   5        $��1��5D   !   $��32��61   $��2q�6@   $
��Edit��6K   6u   �� 5E      $��2��6!   $��32��61   $��2q�6@   $��Delete��6K   ��6\   �� *
DelCommand+6}   5F      5G      5H      5I      � 5J   
   $��2��6   $��
0, 0, 0, 0q�6k    � DataContext 6   �� *SelectedRecipe+$ PropertyChanged=�
 5K      �� 5L      $	��128 �6    6/   �� 5M      $��* �6    6-   .+�5O      � $��0��6   	 5P      �� 5Q      $	��128 �6'   65   �� 5R      6*   .+�5T      �� $��0��6   
���   �$��2q�6=   ._�5U      �� -   5         ��Name$ 	recipeImg��5U      $��Uniform=�6/    �� StretchDirection$
 Both=�6A   ��6Y   �� *	ImageFile+ �� 	Converter# [  5V      �� 5W      $��1��6   
���   �$��2q�6=   ._�5X      �� $��1��6    $��Center=�60   $��Center=�6K   $
��Wrap=�6h   $��32(�6|   $
��Bold"�6�   ��6�   �� *Title+6�   5Y      5Z      �� 5[      $��1��6   
���   �$��2q�66   ._�5\      ,� " ,� VerticalScrollBarVisibility$
 Auto=�6+   $��1��6N   ��6[   �� *Doc+# [ $ PropertyChanged=�5]      5^      5_      5`      