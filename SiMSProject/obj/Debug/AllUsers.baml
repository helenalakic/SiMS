   M S B A M L   `   `   `  ����F  BSiMSProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SiMSProjectSiMSProject  5          SiMSProject.AllUsers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SiMSProject     5        N� 
Background  �#b5d2eb N� Title$ AllUsers��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      � $��35��6   ���#b5d2eb.+�5      �� -   5        $��Sign out��5      $
��Left=�6.   $��	860,8,0,0q�6I   $	��Top=�6\   $��75��6t   6�   5      �� 5      $ 
Horizontal=�6   $	��415��63   ���#b5d2eb.+�5      �� $	��415��6   $	��210��6+   .+�5      �� $	��100��6   $	��100��6(   �� 5      $��	Medicines��6   $��Georgia)�60   $��0,0,0,0q�6E   $	��Top=�6V   $��Center=�6n   $��30��6�   $��16(�6�   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��All medicines��6i   6�   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��Create a medicine��6i   6�   �� 5      $��Users��6   $��Georgia)�6,   $��0,0,0,0q�6A   $	��Top=�6R   $��Center=�6j   $��30��6�   $��16(�6�   �� 5      $��10q�6   $��0,0,0,0q�6+   
������ 
�������$��	All users��6i   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��Register new users��6i   6�   5      � 5      $	��760��6   $	��418��6$   .+�5      �� $��Sort:��6   $��Georgia)�6,   $��-700,59,0,0q�6A   $	��Top=�6V   $��30��6n   $��70��6z   $��16(�6�   �� 5      -   5        $��ComboBoxSortBy��5   4   $��-595,60,0,0q�6   $��Center=�6k   $	��Top=�6�   $��90��6�   $��25��6�   .@�5      �� $��	Ascending��6'   6>   �� 5       $��
Descending��6'   6>   5!      �� 5#      $	��by:��6   $��Georgia)�6*   $��-430,59,0,0q�6?   $	��Top=�6T   $��30��6l   $��70��6x   $��16(�6�   �� 5$      -   5        $��ComboBoxSort��5$   4   $��-320,60,0,0q�6   $��Center=�6b   $	��Top=�6   $	��120��6�   $��25��6�   .@�5&      �� $��
First name��6'   6?   �� 5'      $��	Last name��6'   6=   5(      �� 5,      $��
Filter by:��6   $��Georgia)�61   $��
385,59,0,0q�6F   $	��Top=�6Z   $��30��6r   $��85��6~   $��16(�6�   �� 5-      -   5        $��ComboBoxFilter��5-   3   $��
565,60,0,0q�6   $��Center=�6e   $	��Top=�6�   $	��120��6�   $��25��6�   .@�5/      �� $��Doctor��6'   6;   �� 50      $��
Pharmacist��6'   6>   51      &   System.Windows.Controls.DataGrid  55      -   5          Name$ dataGridUsers��55         
IsReadOnly .    SelectionMode$ Single=�56         AutoGenerateColumns .  $
��Left=�6F   $	��270��57      $	��Top=�6    $	��724��68   $��0,95,0,0q�6D    �� SelectedItem 55   j   �� *au+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 UMCN��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Umcn+6X     5:      $	 email��61   $	
 100 6Z    6@   �� *Email+6Z     5;      $	 	firstName��61   $
 * 6b    6D   �� *	FirstName+6b     5<      $	 lastName��61   $
 * 6`    6C   �� *
LastName+6`     5>      $	 phoneNumber��61   $
 * 6f    6F   �� *PhoneNumber+6f     5?      $	 userType��61   $
 * 6`    6C   �� *
UserType+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5@      $	 Block��65   $
 53 6D      CellTemplate 5A   "   �� 5B   &   .R�5C   *   �� $��	Block_btn��61   -	   5        $��Block��5C   g   ���#1d2345
�������{�6B   ��  �� Path$ 	isEnabled�6�   5D   '   5F        5G      $	 Unblock��65   $
 53 6F    5H   "   �� 5I   &   .R�5J   *   �� $��Unblock_btn��61   -
   5        $��Unblock��5J   i   ���#1d2345
�������{�6D   �� $ 	isEnabled�6�   5K   '   5M      5P      5Q      5S      5T      5U      5V      