   M S B A M L   `   `   `  ????A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5   	       Amonic.AdminMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Amonic     5   	     ? Title$'  !AMONIC Airlines Automation System??5   	   $	??500??63   $	??800??6@    ? 
ResizeMode$ NoResize=?6L    ? WindowStartupLocation$ CenterScreen=?6b   .??5	      ? .+?5
   
   ?? $??Center=?6   $??31??61   
???   ?$	??Top=?6L   $	??800??6d   ?? 5   
   -   5         ??Name$
 Exit??5      $??Add user??6   $
??Left=?62   $??10,3,0,0q?6M   $	??Top=?6_   $??0q?6?   ?? 5   
   -   5        $ AddUser??5      $
??Exit??6#   $
??Left=?62   $??	102,3,0,0q?6M   $	??Top=?6`   $??0q?6?   ?? 5   
   $??Office :??6   $
??Left=?6#   $??	10,36,0,0q?6>   $	??Top=?6Q   ?? 5   
   -   5         ??Name$ 
OfficeList??5       ?? DisplayMemberPath$ Title??6(    ?? SelectedValuePath$ ID??6B   $
??Left=?6Y   $??	78,40,0,0q?6t   $	??Top=?6?   $	??190??6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AmonicDataUsers??5         AutoGenerateColumns .  	   
IsReadOnly	 . $??22,90,22,129q?6Z   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *	FirstName+6S     5      $ 	Last Name??6%    68   ?? *
LastName+6W     5      $	 Age??6%    62   ?? *	Birthdate+6S     5      $ 
Users Role??6%    69   ?? *Roles.Title+6[     5      $ Email Address??6%    6<   ?? *Email+6X     5      $ Office??6%    65   ?? *Offices.Title+6Y     5      $ Active??6%      
Visibility$ Hidden=?65    6I   ?? *Active+6f   5      ?? 5   
   -   5        $??Change Role??5      $
??Left=?6'   $??
50,395,0,0q?6B   $	??Top=?6V   $??31??6n   $	??130??6z   6?   ?? 5   
   $??Enable/Disable Login??6   $
??Left=?60   $??232,395,0,0q?6K   $	??Top=?6`   $??31??6x   $	??204??6?   5      5       