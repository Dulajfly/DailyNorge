   M S B A M L   `   `   `  ����E  ADailyNorge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DailyNorge
DailyNorge  5   	       DailyNorge.AddWord   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DailyNorge     5   	     � Title$  AddWord��5   	   $	��450��6   $	��800��6&   .��5	      � $	��421��6   $	��792��6   $	��421��6'   $	��792��67   $	��421��6F    � ColumnDefinitions 5
   
   �� 5      ��5   
   �� 5       �� ImageSource$ img/gotowe.png��6   .+�5   
   �� -   5         ��Name$ LabelPodajSlowoPL��5      $��Podaj słowo po polsku��6+   $
��Left=�6K   $��	10,56,0,0q�6f   $	��Top=�6y   $	��245��6�   
�������$��40��6�   $��20(�6�   �� 5   
   -   5         ��Name$ AddPolishWord��5      $
��Left=�6)   $��33��6D   $��	10,96,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��215��6�   $��18(�6�    �� SelectionBrush 6�   Z� ��6�   Z� .��6�   ��5      �� 5      $ img/button.png��6   .��5   "   5      �� 5   
   -   5        $ LabelPodajSlowoNOR��5      $��Podaj słowo po norwesku��6,   $
��Left=�6N   $��
537,56,0,0q�6i   $	��Top=�6}   $	��245��6�   
�������$��20(�6�   $��40��6�   �� 5   
   -   5        $ AddNorgeWord��5      $
��Left=�6(   $��33��6C   $��554,101,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��215��6�   
���   �$��18(�6�    6�   Z� ��6�   Z� .��6�   ��5      �� 5      $ img/button.png��6   .��5   "   5      �� 5   
   -   5        $ LabelPodajSlowoANG��5      $��Podaj słowo po angielsku��6,   $
��Left=�6O   $��290,164,0,0q�6j   $	��Top=�6   $	��245��6�   $��20(�6�   
�������6�   �� 5   
   -   5        $ AddEnglishWord��5      $
��Left=�6*   $��33��6E   $��300,206,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��215��6�    J� RenderTransformOrigin$ 0.504,0.409&�6�   $��18(�6�    6�   Z� ��6�   Z� .��6  ��5      �� 5      $ img/button.png��6   .��5    "   5!      �� 5"   
   -   5         ��Name$ AddWord1��5"      $��Dodaj��6#   $
��Left=�63   $��343,319,0,0q�6N   $	��Top=�6c   $	��116��6{   
�������$��35��6�   $��18(�6�   ��6�   Z� ��5#      �� 5$      $ img/button.png��6   5&      �� 5'   
   -   5        $ ReturnButton��5'      $��Cofnij��6'   $
��Left=�68   $��
10,376,0,0q�6S   $	��Top=�6g   $	��109��6   
�������$��34��6�   $��20(�6�   ��6�   Z� ��5(      �� 5)      $ img/button.png��6   5+      5-      5.      