   M S B A M L   `   `   `  ����  LMS     LMS.PatronManagementWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Patron Management��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   �� $��Patron Management System��6   $��24(�64   $
��Bold"�6B   $��Center=�6T   $��0,0,0,10q�6q   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��1* �6#   .+�5      �� $��Patron List��6   $��10q�6,   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ PatronDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5      $��5q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Full Name��6-   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
FullName+6]     5       $	 Membership ID��6-   $
 * 6e    6D   �� *MembershipID+6e     5!      $	 Email��6-   $
 * 6V    6<   �� *Email+6V     5"      $	 Phone Number��6-   $
 * 6c    6C   �� *PhoneNumber+6c     5#      $	 Address��6-   $
 * 6Z    6>   �� *	Address+6Z     5$      $	 Date of Birth��6-   $
 * 6d    6D   �� *DateOfBirth+6d     5%      $	 Membership Type��6-   $
 * 6i    6F   �� *MembershipType+6i   5'      5(      �� 5+      $��1��6   $��10q�6)   .+�5,      �� $��Actions��6   $��0,0,0,10q�6,   .��5-      �� $��5q�6!   .+�5.      �� -   5        $��Add New Patron��5.   !   $	��0,5q�6:   $��35��6G   6S   �� 5/      -   5        $��Edit Selected Patron��5/   !   $	��0,5q�6@   $��35��6M   6Y   �� 50      -   5        $��Delete Selected Patron��50   !   $	��0,5q�6B   $��35��6O   6[   51      52      �� 54      $��Search��6   $��0,10,0,0q�6+   .��55      �� $��5q�6!   .+�56      �� -   5         ��Name$ SearchTextBox��56   "   $	��0,5q�69   $��30��6F   �� 57      -   5        $��Search��57   !   $��30��62   6>   58      59      5:      5;      5<      5=      