   M S B A M L   `   `   `  ����	  Nigga    Nigga.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Llama Editor��5   	   $	��480��6   $	��600��6+   $	��620��67   $	��480��6F    � Icon$Q KResources/Icons/free_rainbow_llama_icon_by_littlemissllamalover-d3ijsj2.gif��6V    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6<     5   
   -   5        $ ApplicationCommands.Save��5      6<   .��5      � $
��Auto=�6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��0* �6   �� 5      $
��513* �6   �� 5      $��0* �6   �� 5      $��2* �6   �� 5      $��0* �6   .+�5   
   o� $	��Top=�6   $��20��6$   $	��Top=�60   $��5��6H   .@�5      m� -   5         m�Name$ fileMenu��5      $
��File��6)   .@�5      m� -   5        $ newMenuItem��5      $	��New��60   $
��Left=�6=   $	��140��6X   6d   m� 5      -   5        $ saveMenuItem��5      $
��Save��61   $
��Left=�6?   $	��140��6Z   6f   m� 5      -   5        $ loadMenuItem��5      $
��Load��61   $
��Left=�6?   $	��140��6Z   6f   m� 5      -   5        $ exitMenuItem��5      $
��Exit��61   $
��Left=�6?   $	��140��6Z   6f   5      m� 5      -	   5        $ editMenu��5      $
��Edit��6)   .@�5      m� -
   5        $ undoMenuItem��5      $
��Undo��61   $
��Left=�6?   $	��140��6Z   6f   �� 5      $
��Left=�6   $	��140��67   m� 5      -   5        $ pasteMenuItem��5      $��Paste��62   $
��Left=�6A   $	��140��6\   6h   m� 5      -   5        $ copyMenuItem��5      $
��Copy��61   $
��Left=�6?   $	��140��6Z   6f   m� 5       -   5        $ cutMenuItem��5       $	��Cut��60   $
��Left=�6=   $	��140��6X   6d   m� 5!      -   5        $ SelectAllTextMenuItem��5!      $��
Select All��6:   $
��Left=�6N   $	��140��6i   6u   �� 5"      $
��Left=�6   $	��140��67   m� 5#      -   5        $ ReplaceMenuItem��5#      $��Replace��64   6e   m� 5$      -   5        $ FindMenuItem��5$      $
��Find��61   $
��Left=�6?   $	��140��6Z   6f   5&      m� 5'      -   5        $ helpMenu��5'      $
��Help��6)   .@�5(      m� -   5        $ aboutMenuItem��5(      $��About��62   $
��Left=�6A   $	��140��6\   6h   5)      5*      c� 5,   
   $��-2,20,0,292q�6   $��32��6'   $��3��63   $	��Top=�6G   .@�5-      �� $��ApplicationCommands.Open��6   .��5.      �� $��Resources/Icons/load.png��6   $��16��6:   $��16��6E   5/      �� 50      $��ApplicationCommands.Save��6   .��51      �� $��Resources/Icons/save.png��6   $��16��6:   $��16��6E   52      �� 53      d� 54      -   5         d�Name$ btnBold��54   @   $ ��EditingCommands.ToggleBold��6   .��55      �� $*��$Resources/Icons/format_text_bold.png��6   $��16��6F   $��16��6Q   56      d� 57      -   5        $ 	btnItalic��57   B   $"��EditingCommands.ToggleItalic��6   .��58      �� $,��&Resources/Icons/format_text_italic.png��6   $��16��6H   $��16��6S   59      d� 5:      -   5        $ btnUnderline��5:   E   $%��EditingCommands.ToggleUnderline��6   .��5;      �� $/��)Resources/Icons/format_text_underline.png��6   $��16��6K   $��16��6V   5<      �� 5=      �� 5>      -   5         ��Name$ cmbFontFamily��5>      $	��150��6.   6:   �� 5?      -   5        $ cmbFontSize��5?      $��50��6,   	 �� 
IsEditable	 . 6I   5@      �� 5A   
   $��2��6   $��	0,52,19,0q�6%   .@�5B      �� $��Title��6   .��5D      �� -   5        
 ��Name$
 	editSpace��5D      $��2��61   $ �� HorizontalScrollBarVisibility$
 Auto=�6A   $��Stretch=�6f   $��Stretch=�6�   $��4��6�   . �5E      /� .T�5F      J� 5G      5H      5K      �� 5L      $��+��6   {�.  6!   5N      �� 5O   
   -   5         ��Name$ Scrooll��5O      $��Right=�6&   $��
568,74,0,0q�6B   $��2��6V   6f   5Q      5R      