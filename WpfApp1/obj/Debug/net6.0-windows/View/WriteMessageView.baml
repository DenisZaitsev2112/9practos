   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5      #    WpfApp1.View.WriteMessageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:WpfApp1.View  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��113* �6   �� 5      $
��287* �6    � RowDefinitions 5   
   �� 5      $
��1.3* �6   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6   .+�5   
   � $��2��6   $��0��6#     5      �� 5      $��1* �6#   �� 5      $��4* �6#    5      �� 5      $��1* �6    �� 5      $��1* �6    .+�5       �� $��
Кому: ��6   
������� �� TextAlignment$ Center=�69   $��Center=�6P   $��Center=�6k   $��16(�6�   �� 5"      $��
Тема: ��6   
�������$ Center=�69   $��Center=�6P   $��Center=�6k   $��14(�6�   $��1��6�   �� 5$      $��0��6   $��1��6#   $��7,2,7,2q�63   
�������$��Center=�6X   ��6s   �� *	address+�� 5&      $��1��6   $��1��6#   $��7,2,7,2q�64   
�������$��Center=�6Y   ��6t   �� *theme+5)      c� 5*   
   $��1��6   $��2��6   $��Center=�63   ���	#00000000.@�5+      �� $��EditingCommands.AlignLeft��6   $��52��6r   $��59��6~   ���	#DDFFFFFF��69   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ FormatAlignLeft=�6�   �� 5,      $!��EditingCommands.AlignCenter��6   $��52��6v   $��59��6�   ���	#DDFFFFFF��6;     $ FormatAlignCenter=�6�   �� 5-      $ ��EditingCommands.AlignRight��6   $��52��6t   $��59��6�   ���	#DDFFFFFF��6:     $ FormatAlignRight=�6�   �� 5.      $"��EditingCommands.AlignJustify��6   $��52��6x   $��59��6�   ���	#DDFFFFFF��6<     $ FormatAlignJustify=�6�   �� 5/      $ ��EditingCommands.ToggleBold��6   $��52��6n   $��59��6z   ���	#DDFFFFFF��6:     $ 
FormatBold=�6�   �� 50      $"��EditingCommands.ToggleItalic��6   $��52��6r   $��59��6~   ���	#DDFFFFFF��6<     $ FormatItalic=�6�   �� 51      $%��EditingCommands.ToggleUnderline��6   $��52��6x   $��59��6�   ���	#DDFFFFFF��6?     $ FormatUnderline=�6�   �� 52      $)��#EditingCommands.DecreaseIndentation��6   $��52��6~   $��59��6�   ���	#DDFFFFFF��6C     $ ArrowCollapseDown=�6�   �� 53      $)��#EditingCommands.IncreaseIndentation��6   $��52��6|   $��59��6�   ���	#DDFFFFFF��6C     $ ArrowCollapseUp=�6�   54      �� 56   
   -   5        $��RichTextBox��56       �� 
AcceptsTab$
 True��6)   $��2��6;   $��2��6O   $	��Top=�6\   
������� � 	Resources 57       �� 
TargetType �� Property �� Value��%X   'J�       �� 58      " J�6   .�59      ��  �@��Margin$ 0q�6/   5:      5;      5<      �� 5>   
   $��3��6   $��1��6   $��5,0,5,0q�6.   $��Отправить��6?      buttonBrush#���   6S   ���	#00000000	 � Cursor$
	 Hand��6�   ��6�   �� *sendCommand+��6�   �� 
 �� ElementName$
 RichTextBox��6�   �� 5@   
   $��0��6   $��3��6!   $��5,0,5,0q�6.   $��Вернутья��6@   #���   6S   ���	#00000000��6�   �� *backCommand+5B      5C      