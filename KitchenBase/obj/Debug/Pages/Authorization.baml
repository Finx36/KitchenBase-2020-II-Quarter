   M S B A M L   `   `   `  ����F  BKitchenBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KitchenBase.PagesKitchenBase.Pages  5   	   %    KitchenBase.Pages.Authorization   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:KitchenBase.Pages     5   	     � Title$  Authorization��5   	   $	��500��6   $	��640��6,   ���#20202A � WindowStartupLocation$ CenterScreen=�6M    � Icon$3 -/KitchenBase;component/Assets/KitchenBase.ico��6r   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+    � ColumnDefinitions 5   
   �� 5      $
��150* �6   6.   �� 5      $
��150* �6   6.   �� 5      $
��150* �6   .+�5   
   �� -   5        $��lblAuthorization��5      $��0��6(   $��0��65   $��3��6E   $��2��6Y   $��Авторизация��6j   $��Century Gothic)�6�   $��Center=�6�   $��35(�5      
�������5      �� 5    
   -   5        $��lblLogin��5       $��2��6    $��1��6-   $��
Логин��6=   $��Century Gothic)�6M   $��30(�5!      
�������5"      �� 5#   
   ���#6c43af$��1q�6'   $��50��6;   $��3��6G   $��1��6T   ._�5$      �� -   5        $��tbLogin��5$      $��30(�6%   66   5%      �� 5&   
   -   5        $��lblPassword��5&      $��4��6#   $��1��60   $��Пароль��6@   $��Century Gothic)�6Q   $��30(�5'      
�������5(      �� 5)   
   ���#6c43af$��1q�6'   $��50��6;   $��5��6G   $��1��6T   ._�5*      G� -   5        $��
tbPassword��5*      $��30(�6,    G� PasswordChar$ *��6:   6N   5+      �� 5,   
   -   5        $��btAccept��5,      $��
Войти��6!   ���#eeebf5���#6c43af$��7��6\   $��1��6i   $��40(�6z   $��Century Gothic)�6�   6�   �� 5-   
   -   5        $��lblAuthoriCheck��5-      $��9��6'   $��0��64   $��3��6D   $5��/Неверный логин или пароль��6X   $��Century Gothic)�6|   $��Center=�6�   $��25(�5.      
�������$y�Hidden=�61   5/      50      51      