   M S B A M L   `   `   `  ����  AppTrombinoscope%    AppTrombinoscope.ListePersonnel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ ListePersonnel��5   	   $	��450��6    $	��800��6-   .��5	      � ���#d6e1e2.+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dataList��5
      $
��Left=�6#   $	��370��6>   $��	30,25,0,0q�6K   $	��Top=�6^   $	��540��6v   ���#8eb4ab   AutoGenerateColumns .  ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $	 Nom��6%    62   �� *Nom+  5      $ Prenom��6%    65   �� *Prenom+4  .System.Windows.Controls.DataGridTemplateColumn  5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6)   $ Photo��65      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *Photo+5      5        5      $ Service��6%    66   �� *IntituleService+  5      $ Fonction��6%    67   �� *IntituleFonction+  5      $ Téléphone��6%    68   �� *	Telephone+5      �� 5   
   $��Nom du Personnel��6   $
��Left=�6+   $��
615,40,0,0q�6F   $	��Top=�6Z   $	��131��6r   $
��Bold"�6~   �� 5   
   $��Prénom du Personnel��6   $
��Left=�6.   $��615,115,0,0q�6I   $	��Top=�6^   $	��131��6v   $
��Bold"�6�   �� 5   
   $��Service du Personnel��6   $
��Left=�6/   $��615,212,0,0q�6J   $	��Top=�6_   $	��131��6w   $
��Bold"�6�   �� 5   
   $��Fonction du Personnel��6   $
��Left=�60   $��615,295,0,0q�6K   $	��Top=�6`   $	��131��6x   $
��Bold"�6�   �� 5    
   -   5        $��BoxNom��5       $
��Left=�6    $��23��6;   $��
615,66,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��131��6�   6�   �� 5!   
   -   5        $��	BoxPrenom��5!      $
��Left=�6#   $��23��6>   $��615,141,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��131��6�   6�   �� 5"   
   -   5        $��
BoxService��5"      $
��Left=�6$   $��23��6?   $��615,238,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��131��6�   6�   �� 5#   
   -   5        $��BoxFonction��5#      $
��Left=�6%   $��23��6@   $��615,321,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��131��6�   6�   5%      5&      