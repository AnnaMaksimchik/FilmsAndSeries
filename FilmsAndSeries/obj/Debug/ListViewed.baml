   M S B A M L   `   `   `  ����H  DMyApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FilmsAndSeriesFilmsAndSeries  5   	       FilmsAndSeries.ListViewed   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FilmsAndSeries     5   	     � Title$  List viewed��5   	   $��552.279��6   $��652.977��6.    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ NoResize=�6c   .��5	      � $	��525��6   $	��Top=�6   $��	0,0,-6,-2q�60    � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��217��6:   $��	0,300,0,0q�6G   $	��Top=�6Z   $	��586��6r   $��images\page1.png��6~   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��187��6>   $��	10,85,0,0q�6K   $	��Top=�6^   $	��627��6v   6�   �� 5   
   -   5         ��Name$ label3��5      $��Viewed films and siries:��6    $
��Left=�6C   $��	10,11,0,0q�6^   $	��Top=�6q   $��18(�6�   $��MV Boli)�6�   $
��Bold"�6�   �� 5   
   -   5        $ label��5      $��Films&Series��6   $
��Left=�6:   $��	460,9,0,0q�6U   $	��Top=�6h   $��20(�6�   $��MV Boli)�6�   $	��126��6�   $��39��6�   �� 5   
   -   5         ��Name$ DeleteButton��5      $��Delete��6'   $
��Left=�68   $��
10,283,0,0q�6S   $	��Top=�6g   $��75��6   $��16(�6�   $��Rockwell Extra Bold)�6�   
�������6�   �� 5   
   -   5        $ 
EditButton��5      $
��Edit��6%   $
��Left=�64   $��112,282,0,0q�6O   $	��Top=�6d   $��78��6|   $��Rockwell Extra Bold)�6�   $
��Bold"�6�   $��16(�6�   $��24��6�   6�   �� 5   
   -   5        $ 
BackButton��5      $
��Back��6%   $
��Left=�64   $��
19,485,0,0q�6O   $	��Top=�6c   $��75��6{   $��16(�6�   $��Rockwell Extra Bold)�6�   6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��	10,55,0,0q�6J   	 �� TextWrapping$
	 Wrap=�6]   $	��Top=�6q   $	��464��6�   �� 5   
   -	   5        $ SearchButton��5      $��Search��6'   $
��Left=�68   $��
479,55,0,0q�6S   $	��Top=�6g   $��75��6   $��Rockwell Extra Bold)�6�   $��14(�6�   $��23��6�   6�   �� 5   
   -
   5        $ CancelButton��5      $��Cancel��6'   $
��Left=�68   $��
562,55,0,0q�6S   $	��Top=�6g   $��75��6   $��Rockwell Extra Bold)�6�   $��14(�6�   $��23��6�   6�   �� 5   
   -   5        
 ��Name$
 sortBox��5      $
��Left=�6$   $��517,282,0,0q�6?   $	��Top=�6T   $	��120��6l   $��24��6x   �� 5   
   -   5        $ label1��5      $��Sort by��6    $
��Left=�62   $��447,277,0,0q�6M   $	��Top=�6b   $��MV Boli)�6z   $��14(�6�   $
��Bold"�6�   $��29��6�   $��65��6�    J� RenderTransformOrigin$ 0.766,0.552&�6�   5      5      