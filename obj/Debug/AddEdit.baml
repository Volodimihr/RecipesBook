   M S B A M L   `   `   `  ����X  TRecipe_book_ExamWPF_Karvatyuk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Recipe_book_ExamWPF_KarvatyukRecipe_book_ExamWPF_Karvatyuk  5   	   a5clr-namespace:Recipe_book_ExamWPF_Karvatyuk.Converter'Recipe_book_ExamWPF_Karvatyuk.Converter  5   	   +    %Recipe_book_ExamWPF_Karvatyuk.AddEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Recipe_book_ExamWPF_Karvatyuk     5   	   K	converter5clr-namespace:Recipe_book_ExamWPF_Karvatyuk.Converter     5   	   -   5          �Name$  AddEditWindow��5	   	   
������� � Title$ AddEdit��5   	   $	��480��6   $	��320��6&    � 	Resources 5      M   GRecipe_book_ExamWPF_Karvatyuk.Converter.ByteArrayToBitmapImageConverter   byteToImageConverter��%   &	          5   
   6M   5      .��5      �  � DataContext 6   �� *
TempRecipe+ �� UpdateSourceTrigger$ PropertyChanged=� � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   � $��0��6    5      �� 5      �� 5      $
��auto �6    .+�5      �� $��0��6   
���   �$��2q�66   ._�5      �� -   5         ��Name$ 	imgRecipe��5      ��6+   �� *	ImageFile+ �� 	Converter# [  5      � 5      $��1��6    � ColumnDefinitions 5       �� 5!      �� 5"      $
��auto �6'   .+�5$      �� $��0��6   $��5q�6,   $��Choose image: ��67   $
��Bold"�6M   $��18(�6_   $��Center=�6m   $��Right=�6�   �� 5%      -   5        $��1��5%      $��64��6)   $��32��64   $	��...��6@   $��5q�6n   $��Right=�6y   5&      5'      � 5(   
   $��1��6    5)      �� 5*      $
��auto �6#   �� 5+      .+�5-      �� $��0��6   $��Title:��6(   $��24(�66   �� 5.      $��1��6   $��24(�6=   $��5q�6K   ��6&   �� *Title+6K   5/      � 50   
   $��2��6    51      �� 52      $
��auto �6#   �� 53      .+�55      �� $��0��6   $��Country:��6(   $��24(�68   �� 56      $��1��6   $��24(�6?   $��5q�6M   ��6&   �� *	Country+6M   57      �� 58   
   -   5        	 ��Name$	 rtbCompInstr��58   ;   
�������$��3��6.   6;   � 59   
   $��4��6    5:      �� 5;      �� 5<      �� 5=      .+�5?      �� -   5        $��1��5?      ��6%   �� 
 �� ElementName$
 AddEditWindow�� �� Path$ Title�6_   �� 5@      -   5        $��2��5@      $��Close��6%   65   5A      5B      5C      