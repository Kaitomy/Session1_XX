   M S B A M L   `   `   `  ????A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5   	       Amonic.UserMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Amonic     5   	     ? Title$'  !AMONIC Airlines Automation System??5      $	??500??65   $	??800??6B    ? 
ResizeMode$ NoResize=?6N    ? WindowStartupLocation$ CenterScreen=?6d   .??5	      ? .+?5
   
   ?? $??Center=?6   $??31??61   
???   ?$	??Top=?6L   $	??800??6d   ?? 5   
   -   5         ??Name$	 Add??5      $
??Exit??6   $
??Left=?6-   $??10,3,0,0q?6H   $	??Top=?6Z   $??0q?6?   ?? 5   
   $??Hi??6   $
??Left=?6   $??	10,36,0,0q?68   $	??Top=?6K   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AmonicDataUsers??5         AutoGenerateColumns .     
IsReadOnly . $??22,90,22,66q?6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date??6%   65     5      $ 
Login time??6%   6<     5      $ Logout time??6%   6>     5      $ Time spent on system??6%   6F     5      $  Unsuccessful logout reason??6%   6L   5      ?? 5   
   $!??Welcome to AMONIC Airlines.??6   $
??Left=?66   $??
174,36,0,0q?6Q   $	??Top=?6e   ?? 5   
   -   5        	 ??Name$
	 Name??5      $?? ??6   $
??Left=?6)   $??	27,36,0,0q?6D   $	??Top=?6W   ?? 5   
   $??Time spent of system:??6   $
??Left=?60   $??
261,53,0,0q?6K   $	??Top=?6_   ?? 5   
   $??Number of crashes:??6   $
??Left=?6-   $??
553,47,0,0q?6H   $	??Top=?6\   5      5      