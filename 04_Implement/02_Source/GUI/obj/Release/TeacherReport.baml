   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI      GUI.TeacherReport   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  localclr-namespace:GUI  datanamespace:GUI  -     N� Title$  Teacher Report�� � 	Resources    ReportTemplate �� DataType?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  NameC  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffectD  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension   Duration �� Orientation��%�  &	        �� $ Report��.R�  $ TrainsitionigContentSlide��   *SlideInFromLeft+$ 0:0:0.5X�.���� ���#CFE6FF$ 
Horizontal=�$��Center=�$��0,0,0,0q�.+��� $��Center=�$��Center=�$��5q�$��35��$	��125�����#305066$��14(����� *stt+�� $��Center=�$��Center=�$��35��$	��310�����#305066$��14(�$
��Bold"����� *	nameClass+�� $��Center=�$��Center=�$��35��$	��180�����#305066$��14(����� *tt+�� $��Center=�$��Center=�$��35��$	��210�����#305066$��14(����� *pass+�� $��Center=�$��Center=�$��35��$	��170�����#305066$��14(����� *scale+.��  -   $ TrainsitionigContentSlide��   *Fadein+$ 0:0:0.5X�.��� .+��� $��0,25,0,0q�$��Center=�$ 
Horizontal=�$	��Top=�.+��� $��Center=�$��Center=�$��20,0,0,0q�$��14(�$
��Bold"�$��Type:���� -    ��Name$ 
chooseType��$	��130��$��14(�.@��� $��14(� �� 
IsSelected . $��Semester���� $��14(�$��Subject���� $��Center=�$��Center=�$��20,0,0,0q�$��14(�$
��Bold"�$��Subject:���� -   $ chooseSubject��{�.  $	��170��$��14(��� $��Center=�$��Center=�$��20,0,0,0q�$��14(�$
��Bold"�$��	Semester:���� -   $ chooseSemester��$��40��$��14(�.@��� $��14(� . $��I���� $��14(�$��II���� $��0,80,0,0q��� $ 
Horizontal=�$	��Top=�.+��� $��35,0,0,0q�	 �� CornerRadius$	 20��$��40��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$��75��$��14(�.��No.�� $��55,0,0,0q�$	 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��240��$��14(�.��Class�� $��53,0,0,0q�$	 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��150��$��14(�.��Total�� $��45,0,0,0q�$	 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��150��$��14(�.��Passed�� $��40,0,0,0q�$	 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��150��$��14(�.��Ratio of passed�� -   $
��test��$��	0,130,0,0q�#��[  