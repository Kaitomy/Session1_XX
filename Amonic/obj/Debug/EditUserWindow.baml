   M S B A M L   `   `   `  ????A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5   	       Amonic.EditUserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Amonic     5   	     ? Title$  EditUserWindow??5   	   $	??500??6    $	??500??6-    ? 
ResizeMode$ NoResize=?69    ? WindowStartupLocation$ CenterScreen=?6O   .??5	      ? .+?5   
   ?? $??Email address:??6   $
??Left=?6*   $??100,103,0,0q?6E   $	??Top=?6Z   ?? 5   
   $??First Name:??6   $
??Left=?6'   $??100,140,0,0q?6B   $	??Top=?6W   ?? 5   
   $??
Last Name:??6   $
??Left=?6&   $??100,177,0,0q?6A   $	??Top=?6V   ?? 5   
   $??Office:??6   $
??Left=?6#   $??100,214,0,0q?6>   $	??Top=?6S    J? RenderTransformOrigin$ 0.522,0.536&?6k   ? 5   
   -   5         ?Name$
 grid??5      {?.  .+?5      ?? -   5         ??Name$ Email??5      $
??Left=?6&   $??238,111,0,0q?6A    ?? TextWrapping$
 Wrap=?6V   $	??Top=?6k   $	??214??6?   ?? 5      -   5        $ 	FirstName??5      $
??Left=?6)   $??238,148,0,0q?6D   $
 Wrap=?6Y   $	??Top=?6n   $	??214??6?   ?? 5      -   5        $ LastName??5      $
??Left=?6(   $??238,181,0,0q?6C   $
 Wrap=?6X   $	??Top=?6m   $	??214??6?   ?? 5      -   5         ??Name$ 
OfficeList??5   )    ?? SelectedIndex$ 0??6   	 ?? DisplayMemberPath$	 Title??6=   
 ?? SelectedValuePath$
 ID??6W   $
??Left=?6o   $??238,214,0,0q?6?   $	??Top=?6?   $	??214??6?   5      ?? 5   
   -   5         ??Name$ 	ApplyUser??5      $??Apply??6$   $
??Left=?64   $??128,372,0,0q?6O   $	??Top=?6d   $??37??6|   $	??122??6?   6?   ?? 5   
   -   5        $ 	CancelAdd??5      $??Cancel??6$   $
??Left=?65   $??313,372,0,0q?6P   $	??Top=?6e   $??37??6}   $	??122??6?   6?   	? 5   
   -   5         	?Name$ users??5      $
??User??6&   $
??Left=?65   $??193,266,0,0q?6P   $	??Top=?6e   	? 5   
   -	   5        $ admins??5      $??Administrator??6&   $??Center=?6>   $??	0,307,0,0q?6[   $	??Top=?6n   5      5      