   M S B A M L   `   `   `  ����  StudentInformationSystem,    &StudentInformationSystem.EnrollStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  EnrollStudent��5   	   $	��500��6   $	��500��6,    � WindowStartupLocation$ CenterScreen=�68   .��5      � #��� ��6    � ColumnDefinitions 5   
   �� 5      $
��247* �6   �� 5      $
��245* �6   .+�5
   
   �� $��Student Details��6   $
��Left=�6*   $��
184,10,0,0q�6E   $	��Top=�6Y   $��Arial)�6q   $��16(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   $��
Student ID��6   $
��Left=�6%   $��	25,67,0,0q�6@   $	��Top=�6S   $��Arial)�6k   �� 5   
   $��Student Name��6   $
��Left=�6'   $��
25,109,0,0q�6B   $	��Top=�6V    J� RenderTransformOrigin$ 0.092,0.439&�6n   $��Arial)�6�   �� 5   
   $��Student Address��6   $
��Left=�6*   $��
25,157,0,0q�6E   $	��Top=�6Y   $��Arial)�6q   �� 5   
   $��Contact Number��6   $
��Left=�6)   $��
25,205,0,0q�6D   $	��Top=�6X   $��Arial)�6p   �� 5   
   $��Course Enroll��6   $
��Left=�6(   $��
25,251,0,0q�6C   $	��Top=�6W   $��Arial)�6o   �� 5   
   $��Registration Date��6   $
��Left=�6,   $��
25,331,0,0q�6G   $	��Top=�6[   $��Arial)�6s   �� 5   
   -   5         ��Name$ 	btnSubmit��5      $��Submit��6$   $
��Left=�65   $��
23,398,0,0q�6P   $	��Top=�6d   $��75��6|   $��Arial)�6�   #��� ��6�   �� 5   
   -   5         ��Name$ txtstudentid��5      $
��Left=�6(   $��23��6C   $��
158,67,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��Arial)�6�   $��2��6�   �� 5   
   -   5        $ txtstudentname��5      $
��Left=�6*   $��23��6E   $��158,109,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��Arial)�6�   $��2��6�   �� 5   
   -   5        $ txtstudentaddress��5      $
��Left=�6-   $��23��6H   $��158,158,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��Arial)�6�   $��2��6�   �� 5   
   -   5        $ txtstudentnumber��5      $
��Left=�6,   $��23��6G   $��158,206,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $��Arial)�6�   $��2��6�   �� 5   
   -   5         ��Name$ courseenroll��5      $
��Left=�6)   $��158,251,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��Arial)�6}   $��2��6�   .@�5      �� $��Network and It Security��6   �� 5      $��Multimedia Technologies��6   �� 5      $��	Computing��6   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ registrationdate��5      $
��Left=�6/   $��158,332,0,0q�6J   $	��Top=�6_   $ -0.383,0.683&�6w   $��Arial)�6�   $��2��6�   �� 5   
   -   5        $ btnHome��5      $
��Home��6"   $
��Left=�61   $��156,398,0,0q�6L   $	��Top=�6a   $��75��6y   $ -0.197,0.502&�6�   $��Arial)�6�   #��� ��6�   �� 5   
   $��Registration ID��6   $
��Left=�6*   $��
25,291,0,0q�6E   $	��Top=�6Y   $��Arial)�6q   �� 5   
   -	   5        $ txtregistrationid��5      $
��Left=�6-   $��23��6H   $��158,291,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��Arial)�6�   $��2��6�   �� 5   
   -
   5        $ btnClear��5      $��Clear
Clear��6#   $��1��6B   $
��Left=�6R   $��
39,396,0,0q�6m   $	��Top=�6�   $��75��6�   6�   5!      5"      