   M S B A M L   `   `   `  ����H  DPractica BBDD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Practica_BBDDPractica_BBDD  5   	   *    $Practica_BBDD.cargaHorariaModificada   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Practica_BBDD     5   	     � Title$  cargaHorariaModificada��5   	   $	��250��6(   $	��300��65   .��5	      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $"��Id de la materia a modificar��6   $��Center=�67   $��0,10,0,0q�6T   $	��Top=�6f   $	��174��6~   $��24��6�   �� 5   
   -   5        $��	textBoxId��5      $��Center=�6#   $��0,50,0,0q�6@    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��128��6�   �� 5   
   $��Nueva cantidad de horas��6   $��Center=�62   $��0,10,0,0q�6O   $	��Top=�6a   $	��146��6y   $��24��6�   $��1��6�   �� 5   
   -   5        $��textBoxNuevasHoras��5      $��Center=�6,   $��0,50,0,0q�6I   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��128��6�   $��1��6�   �� 5   
   -   5        $��aceptar��5      $��Acepatar��6    $
��Left=�63   $��40,0,0,0q�6N   $��2��6`   $��Center=�6m   $��56��6�   6�   �� 5   
   -   5        $��cancelar��5      $��Cancelar��6!   $
��Left=�64   $��	193,0,0,0q�6O   $��2��6b   $��Center=�6o   $��56��6�   6�   5      5      