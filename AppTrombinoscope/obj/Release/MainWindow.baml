   M S B A M L   `   `   `  ���� K  GAppTrombinoscope, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AppTrombinoscopeAppTrombinoscope  !    AppTrombinoscope.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:AppTrombinoscope     $	��800��$	��500��  � Title$!  Trombinoscope non connecter��$	��450��$	��800��.��� ���#d3eae0$��
-4,0,-4,-4q� � RowDefinitions �� $	��35* ��� $	��53* ��� $	��23* ��� $	��10* ��� $	��23* ��� $
��101* ��� $	��23* ��� $	��10* ��� $	��23* ��� $	��18* ��� $	��23* ��� $	��59* � � ColumnDefinitions �� $	��51* ��� $
��127* ��� $	��45* ��� $
��127* ��� $	��45* ��� $
��127* ��� $	��25* ��� $	��88* ��� $
��117* ��� $	��37* �.+�o� $��35��$	��Top=�$��10��$��4,0,4.143,0q�$
��auto��.@�m� -    m�Name$ ConnexionBDDItemMenu��$��Connexion BDD��$��35��$	��124��$��10(�$
��Bold"�m� -   $ ListePersonnelItemMenu��$��Liste du Personnel��$��35��$	��107��$��10(�$
��Bold"�{�.  m� -   $ GestionServiceItemMenu��$��Gestion : Services��$��35��$	��107��$��10(�$
��Bold"�{�.  m� -   $ GestionFonctionItemMenu��$��Gestion : Fonctions��$��35��$	��116��$��10(�$
��Bold"�{�.  m� -   $ GestionPersonnelItemMenu��$��Gestion : Personnels��$��35��$	��120��$��10(�$
��Bold"�{�.  m� -   $ GestionnaireItemMenu��$��Gestionnaire��$��35��$��90��$��10(�$
��Bold"�m� -   $ ParametreBDDItemMenu��$��Paramètre BDD��$��35��$	��107��$��10(�$
��Bold"��� $��Services��$��40,20,32,12q�$
��Bold"�$��1��$��1�� J� RenderTransformOrigin$ 0.561,0.267&��� $��	Fonctions��$��36.373,20,24.627,12q�$
��Bold"�$��3��$��1���� $��Membres��$��34.373,20,30.627,12q�$
��Bold"�$��5��$��1���� $
��Nom:��$��37.373,0,9.627,0q�$	��Top=�$
��Bold"�$��7��$��26��$��2���� $��Prenom :��$��17.373,0,9.627,0q�$
��Bold"�$��7��$��4��$��26��$	��Top=��� $��	Service :��$��21.373,0,9.627,0q�$	��Top=�$
��Bold"�$��7��$��26��$��6���� $��
Fonction :��$��12.373,0,9.627,0q�$	��Top=�$
��Bold"�$��7��$��26��$��8���� $��Téléphone :��$��3.373,0,9.627,0q�$	��Top=�$
��Bold"�$��7��$��26��$��10��$ 0.493,1.154&��� -   $��ServiceView�����#bdcdca$��1��$��2��$��9���� -	   $��FonctionView�����#bdcdca$��3��$��2��$��9���� -
   $��MembresView��$��0.373,0,24.627,0q����#bdcdca$��5��$��2��$��9��$��2���� $��27�� �� TextWrapping$
 Wrap=�$	��Top=�{�.  ���#bdcdca$��8��$��2��$��0.373,0,0.627,0q��� $��27��$
 Wrap=�$	��Top=�{�.  ���#bdcdca$��8��$��4��$��0.373,0,0.627,0q��� -   $��	ServiceTB��$��27��$
 Wrap=�$	��Top=�{�.  ���#bdcdca$��8��$��6��$��0.373,0,0.627,0q��� $��27��$
 Wrap=�$	��Top=�{�.  ���#bdcdca$��8��$��8��$��0.373,0,0.627,0q��� $��27��$
 Wrap=�$	��Top=�{�.  ���#bdcdca$��8��$��10��$��0.373,0,0.627,0q�