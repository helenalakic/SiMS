   M S B A M L   `   `   `  ����F  BSiMSProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SiMSProjectSiMSProject  5      4    .SiMSProject.MedicinesPendingApprovalPharmacist   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SiMSProject     5        N� 
Background
  ����� N� Title$( "MedicinesPendingApprovalPharmacist��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      � $��35��6   ���#b5d2eb.+�5      �� -   5        $��Sign out��5      $
��Left=�6.   $��	860,8,0,0q�6I   $	��Top=�6\   $��75��6t   6�   5      �� 5      $ 
Horizontal=�6   $	��415��63   ���#b5d2eb.+�5      �� $	��415��6   $	��210��6+   .+�5      �� $	��100��6   $	��100��6(   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��All medicines��6i   6�   �� 5      $��10q�6   $��0,0,0,0q�6+   
������ 
�������$ ��Medicines pending approval��6i   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��Rejected medicines��6i   6�   5      � 5      $	��760��6   $	��418��6$    � ColumnDefinitions 5      �� 5      �� 5      $��0* �6+   �� 5      $��0* �6+   .+�5      �� $��Sort by:��6   $��Georgia)�6/   $��
2,59,529,0q�6D   $	��Top=�6X   $��30��6p   $��16(�6|   �� 5      -   5        $��ComboBoxSort��5   2   $��	70,60,0,0q�6   $
��Left=�6`   $	��Top=�6{   $	��120��6�   $��25��6�   .@�5!      �� $��Medicine name��6'   6B   �� 5"      $��Price��6'   69   �� 5#      $��Quantity in stock��6'   6E   5$      �� 5&      $��
Search by:��6   $��Georgia)�61   $��385,59,243,0q�6F   $	��Top=�6\   $��30��6t   $��16(�6�   �� 5'      -   5         ��Name$ 
TextBoxMin��5'      $��
595,60,0,0q�63   $y�Hidden=�6G   
�������$��16(�6n   $��Georgia)�6|    �� TextAlignment$
 Left=�6�   $�� ��6�   $��50��6�   $��25��6�   $
��Left=�6�   $	��Top=�6�   �� 5(      -   5        $ 
TextBoxMax��5(      $��
647,60,0,0q�62   $y�Hidden=�6F   
�������$��16(�6m   $��Georgia)�6{   $
 Left=�6�   $�� ��6�   $��50��6�   $��25��6�   $
��Left=�6�   $	��Top=�6�   �� 5)      -   5        $��SearchPrice_btn��5)   )   $��25��6   $y�Hidden=�6W   $	��Top=�6k   $��Right=�6�   $��	0,60,36,0q�6�   $��25��6�   .��5*      �� $��25��6    $(��"/Images/account-search-outline.png��6,   $	��Top=�6X   $��Right=�6p   $��0,0,0,0q�6�   $��20��6�   6�   5+      �� 5,      -   5        $ TextBoxSearch��5,      $��
600,60,0,0q�65   
�������$��16(�6�   $��Georgia)�6�   $
 Left=�6�   $�� ��6�   $	��120��6�   $��25��6�   $
��Left=�6�   $	��Top=�6�   �� 5-      -	   5        $��ComboBoxSearch��5-   3   $��
470,60,0,0q�6   $
��Left=�6v   $	��Top=�6�   $	��120��6�   $��25��6�   .@�5/      �� $��Medicine id��6'   6@   �� 50      $��Medicine name��6'   6A   �� 51      $��Manufacturer��6'   6@   �� 52      $��Price range��6'   6?   �� 53      $��Quantity��6'   6<   �� 54      $��Ingredients��6'   6?   55      &   System.Windows.Controls.DataGrid  59      -
   5          Name$ dataGridMedicines��59         
IsReadOnly .    SelectionMode$ Single=�5:      	   AutoGenerateColumns	 .  $
��Left=�6b   $	��270��5;      $	��Top=�6    $	��724��68   $��0,95,0,0q�6D   
 �� SelectedItem
 5:   *   �� *pa+   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ 
medicineId��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 68 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *
MedicineId+6d     5>      $ medicineName��61   $	 100 6h    6G   �� *MedicineName+6h     5?      $ manufacturer��61   $ 85 6h    6G   �� *Manufacturer+6h     5@      $ quantity��61   $ 54 6`    6C   �� *
Quantity+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ ingredients��65   $ 70 6J      CellTemplate 5B   "   �� 5C   &   .R�5D   *   �� $��Ingredients_btn��61   -   5        $��Ingredients��5D   H   ���#1d2345
�������6�   5E   '   5G        5H      $ quantityInStock��61   $ 92 6n    6J   �� *QuantityInStock+6n     5I      $ price (RSD)��61   $ 68 6`    6F   �� *Price+6`     5J      $ Approved by��65   $ 80 6J    5K   "   �� 5L   &   .R�5M   *   �� $��ApprovedBy_btn��61   -   5        $��Click��5M   G   ���#1d2345
�������6�   5N   '   5P        5Q      $ Accept��65   $ 50 6E    5R   "   �� 5S   &   .R�5T   *   �� $��
Accept_btn��61   -   5        $��Accept��5T   C   ���#1d2345
�������6~   5U   '   5W        5X      $ Decline��65   $ 50 6F    5Y   "   �� 5Z   &   .R�5[   *   �� $��Decline_btn��61   -   5        $��Decline��5[   D   ���#1d2345
�������6�   5\   '   5^      5b      5c      5e      5f      5g      5h      