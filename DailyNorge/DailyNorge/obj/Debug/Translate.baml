   M S B A M L   `   `   `  ����E  ADailyNorge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DailyNorge
DailyNorge  5   	       DailyNorge.Translate   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DailyNorge     5   	     � Title$  Translate - score��5   	   $	��450��6#   $	��800��60   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ TranslateSearchWord��5      $ ��Słowo szukane w słowniku��6-   $��Center=�6P   $��Center=�6m   ���	#FFFF5602$��10,68,10,10q�6�   $
��Lato)�6�   $��36(�6�   $��62��6�   $	��376��6�   �� 5   
   -   5        $ TranslateWord��5      $��słowo po polsku��6'   $��1��6A   $
��Left=�6Q   $��Center=�6l   ���	#FFFF5602$��
10,68,0,10q�6�   $��36(�6�   $��62��6�   $	��376��6�   $
��Lato)�6�   �� 5   
   -   5         ��Name$ ReturnButton��5      $��Cofnij��6'   $
��Left=�68   $��2��6S   $��Bottom=�6`   $	��103��6{   $��	15,0,0,10q�6�   
�������$��35��6�   $��20(�6�   ��6�   Z� ��5      �� 5       �� ImageSource$ img/button.png��6   5      �� 5   
   -   5        $ slowoPodaneLabel��5      $��Podane słowo:��6*   $
��Left=�6B   $��	10,10,0,0q�6]   $	��Top=�6p   $��58��6�   $	��298��6�   $��36(�6�   
�������6�   �� 5   
   -   5        $ SlowoPrzetlumaczoneLabel��5      $��Przetłumaczone słowo:��62   $��1��6R   $
��Left=�6b   $��	10,10,0,0q�6}   $	��Top=�6�   $��58��6�   $	��376��6�   
�������$��36(�6�   5      ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      � 	 � Color$	 	#FF0C6D93��6   
 � Offset$
 0.103Q�6-   � 5       $	 	#FF095270��6   $
 1Q�6-   5!      5$      