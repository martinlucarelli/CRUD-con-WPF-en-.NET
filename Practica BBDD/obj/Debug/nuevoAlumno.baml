   M S B A M L   `   `   `  ����H  DPractica BBDD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Practica_BBDDPractica_BBDD  5   	       Practica_BBDD.nuevoAlumno   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Practica_BBDD     5   	     � Title$  nuevoAlumno��5   	   $	��250��6   $	��400��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $
��DNI:��6   $
��Left=�6   $��32,9,0,0q�6:   $	��Top=�6L   �� 5   
   $��NOMBRE:��6   $
��Left=�6"   $��32,0,0,0q�6=   $��Center=�6O   $��1��6j   �� 5   
   $��	APELLIDO:��6   $
��Left=�6$   $��32,0,0,0q�6?   $��Center=�6Q   $��2��6l   �� 5   
   $��
DIRECCION:��6   $
��Left=�6%   $��32,0,0,0q�6@   $��Center=�6R   $��3��6m   �� 5   
   $��	TELEFONO:��6   $
��Left=�6$   $��32,0,0,0q�6?   $��Center=�6Q   $��4��6l   �� 5   
   -   5        $��	TexBoxDni��5      $
��Left=�6$   $��	166,0,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $��Center=�6n   $	��171��6�   $��21��6�   �� 5   
   -   5        $��TexBoxNombre��5      $
��Left=�6&   $��	166,0,0,0q�6A   $
 Wrap=�6T   $�� ��6h   $��Center=�6p   $	��171��6�   $��21��6�   $��1��6�   �� 5   
   -   5        $��TexBoxApellido��5      $
��Left=�6(   $��	166,7,0,0q�6C   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��171��6�   $��21��6�   $��2��6�   �� 5   
   -   5        $��TexBoxDireccion��5      $
��Left=�6)   $��	166,7,0,0q�6D   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��171��6�   $��21��6�   $��3��6�   �� 5   
   -   5        $��TexBoxTelefono��5      $
��Left=�6(   $��	166,8,0,0q�6C   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��171��6�   $��21��6�   $��4��6�   �� 5    
   -   5        $��aceptar��5       $��Aceptar��6    $
��Left=�62   $��
100,10,0,0q�6M   $��5��6a   $	��Top=�6n   6�   �� 5!   
   -   5        $��cancelar��5!      $��Cancelar��6!   $
��Left=�64   $��	243,0,0,0q�6O   $��5��6b   $��Center=�6o   6�   5$      5%      