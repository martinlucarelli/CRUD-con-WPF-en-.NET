   M S B A M L   `   `   `  ����H  DPractica BBDD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Practica_BBDDPractica_BBDD  5   	        Practica_BBDD.nuevaMateria   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Practica_BBDD     5   	     � Title$  nuevaMateria��5   	   $	��250��6   $	��400��6+   .��5	      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��NOMBRE:��6   $
��Left=�6"   $��32,0,0,0q�6=   $��Center=�6O   $��0��6j   �� 5   
   $��HORAS POR SEMANA:��6   $
��Left=�6,   $��32,0,0,0q�6G   $��Center=�6Y   $��1��6t   $��11(�6�   �� 5   
   $��AÑO:��6   $
��Left=�6   $��32,0,0,0q�6:   $��Center=�6L   $��2��6g   �� 5   
   $��PROFESOR (dni):��6   $
��Left=�6*   $��32,0,0,0q�6E   $��Center=�6W   $��3��6r   �� 5   
   -   5        $��TexBoxNombre��5      $
��Left=�6&   $��	166,0,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $��Center=�6p   $	��171��6�   $��21��6�   $��0��6�   �� 5   
   -   5        $��TexBoxHoras��5      $
��Left=�6%   $��	166,0,0,0q�6@   $
 Wrap=�6S   $�� ��6g   $��Center=�6o   $	��171��6�   $��21��6�   $��1��6�   �� 5   
   -   5        $��
TexBoxAnio��5      $
��Left=�6$   $��	166,0,0,0q�6?   $
 Wrap=�6R   $�� ��6f   $��Center=�6n   $	��171��6�   $��21��6�   $��2��6�   �� 5   
   -   5        $��TexBoxProfCargo��5      $
��Left=�6)   $��	166,0,0,0q�6D   $
 Wrap=�6W   $�� ��6k   $��Center=�6s   $	��171��6�   $��21��6�   $��3��6�   �� 5!   
   -   5        $��aceptar��5!      $��Aceptar��6    $
��Left=�62   $��
100,10,0,0q�6M   $��4��6a   $	��Top=�6n   6�   �� 5"   
   -   5        $��cancelar��5"      $��Cancelar��6!   $
��Left=�64   $��	227,9,0,0q�6O   $��4��6b   $	��Top=�6o   6�   5%      5&      