   M S B A M L   `   `   `  ????F  BToyStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ToyStoreAppToyStoreApp  5   	       ToyStoreApp.MenuWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ToyStoreApp     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.5.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     ? Title$  
MenuWindow??5	   	   $	??550??6   $
??1000??6)    ? Icon$ /Source/Иконка.ico??66   .??5
      ? ???	#ffdadada.+?5   
   ?? $	??400??6   $??15q?6    
???????$??Center=?5       ?? Padding$ 30q?6,   $	??900??5       ?? CornerRadius$ 25??6     J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6#      Color$ 	LightGray??63      ShadowDepth$ 0Q?5   #   ._?5      ?  ? RowDefinitions 5      ?? 5      $	??61* ?6$   ?? 5      $
??373* ?6$   	 ? ColumnDefinitions	 5      ?? 5      $
??200* ?6'   ?? 5      $
??600* ?6'   .+?5      ?? 
 ?? Orientation$
 Vertical=?6   
???????$??2??6K   .+?5      ?? $??Главная??6   $??10q?6/   ?? 5      $??Каталог??6   $??10q?6/   ?? 5      $??Избранное??6   $??10q?61   ?? 5      $??Корзина??6   $??10q?6/   ?? 5       $??Мой профиль??6   $??10q?63   ?? 5!      $ ??Тех. поддержка??6   $??
10 60 10 0q?66   ?? 5"      $??
Выйти??6   $??
10 10 10 0q?6-      MaterialDesignFlatButton#??[  6A   5#      ?? 5$      $??1??6   $??1??6-   $
 
Horizontal=?6>   ???	#FFFF9D63.+?5%      ?? $G??AОнлайн-магазин игрушек «Песочница»??6    $??30(?6J   $
??Bold"?5&      $??
20 10 0 10q?6.   5'      ? 5(      $??1??6   $??2??6'   .+?5)      ?? $??Center=?6   $??/Source/Лого.png??69   $??	0,55,0,45q?6S   $	??367??6f   5*      5,      5-      5.      5/      