   M S B A M L   `   `   `  ����J  FPersonalJournal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PersonalJournalPersonalJournal  5   	   #    PersonalJournal.JOURNAL_ENTRY   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PersonalJournal     5   	     � Title$  JOURNAL_ENTRY��5   	   $	��450��6   $	��800��6,   ��5	      �� 5
   
    �� ImageSource$ image/book.png��6   64   .��5      � .+�5   
   �� $
��Left=�6   $��	285,0,0,0q�6/   $
��Wrap=�6B   $��JOURNAL ENTRYS��6V   $	��Top=�6l   $��40��6�   $	��220��6�   $��Segoe UI Black)�6�   $��24(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ JournalEntries��5      $	��300��6C      AutoGenerateColumns .     
IsReadOnly . $	��241��6�   $��41,64,449.6,0q�6�   $	��Top=�6�   ��6+   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Journal Title��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *journalTitle+5      �� 5   
   -   5        	 ��Name$	 Stacker��5      $��409,64,34.6,115q�6&   $	��350��6?   
�������.+�5      �� $��
0,0,-0.6,0q�6   $
��Bold"�6,   ���	#FFFCFCFC�� 6W   
���   �$�Journal ��6n   �� 6�   
���   �$�Title��6�   6�   �� 5      -   5        
 ��Name$
 JournalTitleText��5      $��
0,0,-0.6,0q�62   �� 5      $
��Bold"�6   
��������� 6?   
���   �$�Journal ��6V   �� 6h   
���   �$�Entry��6   6�   �� 5      -   5        $
 JournalEntryText��5      $
��Wrap=�62   ��6F   Z� 5      �� 5   
   -   5        $��
Cancel 
��5      $
��Left=�67   $	��Top=�6R   $��85��6j   $��330,329,0,0q�6u   $��55��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FFFC0000z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 360.057Q�6&   T� 5      5       5"      5$      5%      