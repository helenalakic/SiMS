   M S B A M L   `   `   `  ����F  BSiMSProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SiMSProjectSiMSProject  5      "    SiMSProject.RefusedMedicines   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SiMSProject     5        N� 
Background
  ����� N� Title$ RefusedMedicines��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      � $��35��6   ���#b5d2eb.+�5      �� -   5        $��Sign out��5      $
��Left=�6.   $��	860,8,0,0q�6I   $	��Top=�6\   $��75��6t   6�   5      �� 5      $ 
Horizontal=�6   $	��415��63   ���#b5d2eb.+�5      �� $	��415��6   $	��210��6+   .+�5      �� $	��100��6   $	��100��6(   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$��All medicines��6i   6�   �� 5      -   5        $��10q�5      $��0,0,0,0q�6+   
������ 
�������$ ��Medicines pending approval��6i   6�   �� 5      $��10q�6   $��0,0,0,0q�6+   
������ 
�������$��Rejected medicines��6i   5      � 5      $	��760��6   $	��418��6$    � ColumnDefinitions 5      �� 5      $
��729* �6+   �� 5      $	��31* �6+   .+�5      �� $��Sort by:��6   $��Georgia)�6/   $��
2,59,529,0q�6D   $	��Top=�6X   $��30��6p   $��16(�6|   �� 5      -   5        $��ComboBoxSort��5   2   $��	70,60,0,0q�6   $
��Left=�6`   $	��Top=�6{   $	��120��6�   $��25��6�   .@�5!      �� $��Medicine name��6'   6B   �� 5"      $��Price��6'   69   �� 5#      $��Quantity in stock��6'   6E   5$      �� 5'      $��
Search by:��6   $��Georgia)�61   $��385,59,243,0q�6F   $	��Top=�6\   $��30��6t   $��16(�6�   �� 5(      -   5         ��Name$ 
TextBoxMin��5(      $��
595,60,0,0q�6r   $y�Hidden=�6�   
�������$��16(�6�   $��Georgia)�6�    �� TextAlignment$
 Left=�6�   $�� ��6�   $��50��6�   $��25��6�   $
��Left=�6  $	��Top=�6  �� 5)      -   5        $ 
TextBoxMax��5)      $��
647,60,0,0q�6r   $y�Hidden=�6�   
�������$��16(�6�   $��Georgia)�6�   $
 Left=�6�   $�� ��6�   $��50��6�   $��25��6�   $
��Left=�6  $	��Top=�6  �� 5*      -   5        $��SearchPrice_btn��5*   )   $��25��6   $y�Hidden=�6W   $	��Top=�6k   $��Right=�6�   $��0,60,3,0q�6�   $��25��6�   .��5+      �� $��25��6    $(��"/Images/account-search-outline.png��6,   $	��Top=�6X   $��Right=�6p   $��0,0,0,0q�6�   $��20��6�   6�   5,      �� 5-      -   5        $ TextBoxSearch��5-      $��
599,60,0,0q�65   
�������$��16(�6�   $��Georgia)�6�   $
 Left=�6�   $�� ��6�   $	��120��6�   $��25��6�   $
��Left=�6�   $	��Top=�6�   �� 5.      -	   5        $��ComboBoxSearch��5.   3   $��
470,60,0,0q�6   $
��Left=�6t   $	��Top=�6�   $	��120��6�   $��25��6�   .@�50      �� $��Medicine id��6'   6@   �� 51      $��Medicine name��6'   6A   �� 52      $��Manufacturer��6'   6@   �� 53      $��Price range��6'   6?   �� 54      $��Quantity��6'   6<   �� 55      $��Ingredients��6'   6?   56      &   System.Windows.Controls.DataGrid  5:      -
   5          Name$ dataGridMedicines��5:         
IsReadOnly .    SelectionMode$ Single=�6�   	   AutoGenerateColumns	 .  $��Center=�6�   $	��270��5;      $	��Top=�6    $	��724��68   $��0,95,0,0q�6D   ��5:   :   �� *RejectedMedicines+
 �� SelectedItem
 6d   �� *rm+   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ 
medicineId��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *
MedicineId+6d     5>      $ medicineName��61   $	 100 6h    6G   �� *MedicineName+6h     5?      $ manufacturer��61   $ * 6h    6G   �� *Manufacturer+6h     5@      $ quantity��61   $ 60 6`    6C   �� *
Quantity+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ ingredients��65   $ 70 6J      CellTemplate 5B   "   �� 5C   &   .R�5D   *   �� $��Ingredients_btn��61   -   5        $��Ingredients��5D   H   ���#1d2345
�������6�   5E   '   5G        5H      $ quantityInStock��61   $	 100 6n    6J   �� *QuantityInStock+6n     5I      $ price (RSD)��61   $ 75 6`    6F   �� *Price+6`     5J      $ Rejected(reason)��65   $ * 6O    5K   "   �� 5L   &   .R�5M   *   �� $��Rejected_btn��61   -   5        $
��View��5M   E   ���#1d2345
�������6�   5N   '   5P      5S      5T      5V      5W      5X      5Y      