   M S B A M L   `   `   `  ����  AppTrombinoscope'    !AppTrombinoscope.GestionPersonnel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ GestionPersonnel��5   	   $	��600��6"   $	��800��6/   ���	#FFCED4CE.��5	      � .+�5
   
   �� $��85,75,622,461q�6   $	��Nom��6'   $
��Bold"�65   �� 5   
   $��85,115,622,418q�6   $��prénom��6(   $
��Bold"�69   �� 5   
   $��85,153,622,381q�6   $��Téléphone��6(   $
��Bold"�6<   �� 5   
   -   5        $��NomTb��5      $��186,70,425,469q�6   69   �� 5   
   -   5        $��PrenomTb��5      $��186,110,425,423q�6"   �� 5   
   -   5        $��TelephoneTb��5      $��186,153,425,382q�6%   �� 5   
   -   5        $��Image��5      $��458,19,85,343q�6   66   �� 5   
   -   5        $��ImageBt��5      $��219,194,451,343q�6    $
��Bold"�69   .��6a   choisir photo6q   �� 5   
   $��choisir le service��6   $��124,258,521,260q�6-   $
��Bold"�6F    J� RenderTransformOrigin$ -0.411,0.412&�6X   �� 5   
   $��choisir la fonction��6   $��513,258,132,260q�6.   $
��Bold"�6G   �� 5   
   -   5        $��ListeService��5      $��85,311,471,91q�6'   ��6>   ��  �� Path$ .� �� View 5      �� 5      .P�5      �� $	��Nom��6%    �� DisplayMemberBinding 62   �� $ Intitule� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      5      �� 5   
   -   5        $��ListeFonction��5      $��458,311,85,91q�6(   ��6@   �� $ .� 5      �� 5      .P�5      �� $	��Nom��6%    62   �� $ Intitule�$ TwoWay=�$ PropertyChanged=�6�   5      5!      �� 5"   
   -   5        $��SaveBt��5"      $��124,502,521,34q�6   $��Enregistrer��67   6d   �� 5#   
   -	   5        $��AnnuleBt��5#      $��513,502,132,34q�6!   $��Annuler��69   6M   5$      5%      