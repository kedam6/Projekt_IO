   M S B A M L   `   `   `  ����	  Nigga    Nigga.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Llama Editor��5   	   $	��480��6   $	��600��6+   $	��620��67   $	��480��6F    � Icon$T N../Resources/Icons/free_rainbow_llama_icon_by_littlemissllamalover-d3ijsj2.gif��6V    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6<     5   
   -   5        $ ApplicationCommands.Save��5      6<     5	   
   -   5        $ 	SelectAll��5	      5   	    J� InputBindings 5      �� 5   
    �� Command$ 	SelectAll��6   
 �� Key$ A��6)    �� 	Modifiers$
 Ctrlf�61   d� 5   
   $ 	SelectAll��6   	 d� MouseAction$	 LeftDoubleClicke�6+   .��5      � -   5        
 �Name$
 mainGrid��5      $
��Auto=�6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��0* �6   �� 5      $
��513* �6   �� 5      $��0* �6   �� 5      $��2* �6   �� 5      $��0* �6   .+�5   
   o� $	��Top=�6   $��20��6$   $	��Top=�60   $��5��6H   .@�5      m� -   5         m�Name$ fileMenu��5      $
��File��6)   .@�5      m� -   5        $ newMenuItem��5      $	��New��60   $
��Left=�6=   $	��140��6X   6d   m� 5       -   5        $ saveMenuItem��5       $
��Save��61   $
��Left=�6?   $	��140��6Z   6f   m� 5!      -	   5        $ loadMenuItem��5!      $
��Load��61   $
��Left=�6?   $	��140��6Z   6f   m� 5"      -
   5        $ exitMenuItem��5"      $
��Exit��61   $
��Left=�6?   $	��140��6Z   6f   5#      m� 5$      -   5        $ editMenu��5$      $
��Edit��6)   .@�5%      m� -   5        $ undoMenuItem��5%      $
��Undo��61   $
��Left=�6?   $	��140��6Z   6f   �� 5&      $
��Left=�6   $	��140��67   m� 5'      -   5        $ pasteMenuItem��5'      $��Paste��62   $
��Left=�6A   $	��140��6\   6h   m� 5(      -   5        $ copyMenuItem��5(      $
��Copy��61   $
��Left=�6?   $	��140��6Z   6f   m� 5)      -   5        $ cutMenuItem��5)      $	��Cut��60   $
��Left=�6=   $	��140��6X   6d   m� 5*      -   5        $ SelectAllTextMenuItem��5*      $��
Select All��6:   $
��Left=�6N   $	��140��6i   6u   �� 5+      $
��Left=�6   $	��140��67   m� 5,      -   5        $ ReplaceMenuItem��5,      $��Replace��64   6e   m� 5-      -   5        $ FindMenuItem��5-      $
��Find��61   $
��Left=�6?   $	��140��6Z   6f   5/      m� 50      -   5        $ helpMenu��50      $
��Help��6)   .@�51      m� -   5        $ aboutMenuItem��51      $��About��62   $
��Left=�6A   $	��140��6\   6h   52      53      c� 55   
   $��-2,20,0,292q�6   $��32��6'   $��3��63   $	��Top=�6G   .@�56      �� $��ApplicationCommands.Open��6   .��57      �� $/��)/Nigga;component/Resources/Icons/load.png��6   $��16��6K   $��16��6V   58      �� 59      $��ApplicationCommands.Save��6   .��5:      �� $/��)/Nigga;component/Resources/Icons/save.png��6   $��16��6K   $��16��6V   5;      �� 5<      d� 5=      -   5         d�Name$ btnBold��5=   @   $ ��EditingCommands.ToggleBold��6   .��5>      �� $;��5/Nigga;component/Resources/Icons/format_text_bold.png��6   $��16��6W   $��16��6b   5?      d� 5@      -   5        $ 	btnItalic��5@   B   $"��EditingCommands.ToggleItalic��6   .��5A      �� $=��7/Nigga;component/Resources/Icons/format_text_italic.png��6   $��16��6Y   $��16��6d   5B      d� 5C      -   5        $ btnUnderline��5C   E   $%��EditingCommands.ToggleUnderline��6   .��5D      �� $@��:/Nigga;component/Resources/Icons/format_text_underline.png��6   $��16��6\   $��16��6g   5E      �� 5F      �� 5G      -   5         ��Name$ cmbFontFamily��5G      $	��150��6.   6:   �� 5H      -   5        $ cmbFontSize��5H      $��50��6,    �� 
IsEditable . 6I   5I      �� 5J   
   -   5         ��Name$ 	editSpace��5J      " �� VerticalScrollBarVisibility$ Visible=�6)   $ �� HorizontalScrollBarVisibility$
 Auto=�6O   $��Stretch=�6t   $��Stretch=�6�   $��2,80,0.2,10.4q�6�   $��3��6&   5L        5M      -   5        $ 	SelectAll��5M   !   5O       5R      �� 5S      $ 	SelectAll��6   $ A��61   $
 Ctrlf�69   d� 5T      $ 	SelectAll��6   $	 LeftDoubleClicke�63   5V      � 5W   
   -   5        $
 tabsGrid��5W      $��28��6!   $��-2,52,-0.4,0q�6-   $	��Top=�6C   $��6��6[   .+�5X      �� -   5         ��Name$
 tabs��5X      $��Stretch=�6P   5Y      5[      5\      