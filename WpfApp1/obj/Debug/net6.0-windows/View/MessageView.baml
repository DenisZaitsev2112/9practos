   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.MessageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:WpfApp1.View  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��113* �6   �� 5      $
��287* �6    � RowDefinitions 5   
   �� 5      $
��1.3* �6   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6   .+�5   
   � $��2��6   $��0��6#   $��2��60     5      �� 5      $��1* �6#   �� 5      $��4* �6#    5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    .+�5!      �� $��
Кому: ��6   
������� �� TextAlignment$ Center=�69   $��Center=�6P   $��Center=�6k   $��16(�6�   �� 5#      $��
Тема: ��6   
�������$ Center=�69   $��Center=�6P   $��Center=�6k   $��14(�6�   $��1��6�   �� 5%      $��От кого: ��6   
�������$ Center=�6<   $��Center=�6S   $��Center=�6n   $��14(�6�   $��2��6�   �� 5'      $��0��6   $��1��6%   $��7,2,7,2q�65   
�������$��Center=�6Z   $ Center=�6�   ��6u   �� *addressReciever+6�   �� 5)      $��1��6   $��1��6%   $��7,2,7,2q�66   
�������$��Center=�6[   $ Center=�6�   ��6v   �� *theme+6�   �� 5+      $��2��6   $��1��6%   $��7,2,7,2q�66   
�������$��Center=�6[   $ Center=�6�   ��6v   �� *addressSender+6�   5.      �� 50   
   $��2��6   $��2��6   ��63   �� *textMessage+�� 52   
   $��3��6   $��1��6   $��5,0,5,0q�6.   $��Ответить��6?      buttonBrush#���   6R   ���	#00000000 � Cursor$
 Hand��6�   ��6�   �� *answerCommand+��6�   ��  �� ElementName$ RichTextBox��6�   �� 54   
   $��0��6   $��3��6!   $��5,0,5,0q�6.   $��Вернуться��6@   #���   6T   ���	#00000000��6�   �� *backCommand+56      57      