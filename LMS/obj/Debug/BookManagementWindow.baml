   M S B A M L   `   `   `  ����  LMS    LMS.BookManagementWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Book Management��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   �� $��Book Management System��6   $��24(�62   $
��Bold"�6@   $��Center=�6R   $��0,0,0,10q�6o   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��32* �6#   �� 5      $
��555* �6#   �� 5      $
��293* �6#   .+�5      �� $��	Book List��6   $��10,10,10,10q�6*   $��2��6?   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ BookDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5      $��5q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��6-   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Title+6V     5!      $	 Author��6-   $
 * 6X    6=   �� *Author+6X     5"      $
	 ISBN��6-   $
 * 6T    6;   �� *ISBN+6T     5#      $	 Genre��6-   $
 * 6V    6<   �� *Genre+6V     5$      $	 	Publisher��6-   $
 * 6^    6@   �� *	Publisher+6^     5%      $	 Year Published��6-   $
 * 6g    6E   �� *YearPublished+6g     5&      $	 Copies Available��6-   $
 * 6j    6G   �� *NumberOfCopies+6j   5(      5)      �� 5,      $��2��6   $��10,10,10,10q�6)   .+�5-      �� $��Actions��6   $��0,0,0,10q�6,   .��5.      �� $��5q�6!   .+�5/      �� -   5        $��Add New Book��5/   !   $	��0,5q�68   $��35��6E   6Q   �� 50      -   5        $��Edit Selected Book��50   !   $	��0,5q�6>   $��35��6K   6W   �� 51      -   5        $��Delete Selected Book��51   !   $	��0,5q�6@   $��35��6M   6Y   52      53      �� 55      $��Search��6   $��0,10,0,0q�6+   .��56      �� $��5q�6!   .+�57      �� -   5         ��Name$ SearchTextBox��57   "   $	��0,5q�6:   $��30��6G   �� 58      -   5        $��Search��58   !   $��30��62   6>   59      5:      5;      5<      5=      5>      