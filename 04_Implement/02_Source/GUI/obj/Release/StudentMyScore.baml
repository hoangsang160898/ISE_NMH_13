   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI      GUI.StudentMyScore   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  localclr-namespace:GUI  datanamespace:GUI  -     N� Title$  Student Score�� � 	Resources    ScoreTemplate �� DataType?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  NameC  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffectD  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension   Duration �� Orientation��%�  &	        �� $ MarkDTO��.R�  $ TrainsitionigContentSlide��   *SlideInFromLeft+$ 0:0:0.5X�.���� ���#CFE6FF$ 
Horizontal=�$��Center=�$��0,0,0,0q�.+��� $��Center=�$��Center=�$��5q�$��35��$	��170�����#305066$��14(�$
��Bold"����� *Subject.NameSubject+�� $��Center=�$��Right=�$��35��$	��103�����#305066$��14(����� *FirstFifteenMinutesMark+�� $��Center=�$��Center=�$��35��$	��103�����#305066$��14(����� *SecondFifteenMinutesMark+�� $��Center=�$
��Left=�$��35��$	��103�����#305066$��14(����� *ThirdFifteenMinutesMark+�� $��Center=�$��Right=�$��35��$	��103�����#305066$��14(����� *FirstFortyFiveMinutesMark+�� $��Center=�$��Center=�$��35��$	��103�����#305066$��14(����� *SecondFortyFiveMinutesMark+�� $��Center=�$
��Left=�$��35��$	��103�����#305066$��14(����� *ThirdFortyFiveMinutesMark+�� $��Center=�$��Center=�$��35��$	��103�����#305066$��14(����� *SemesterScore+�� $��Center=�$��Center=�$��35��$	��103�����#305066$��14(����� *AverageMark+.��  -   $ TrainsitionigContentSlide��   *Fadein+$ 0:0:0.5X�.��� .+��� $��0,25,0,0q�$��Center=�$ 
Horizontal=�$	��Top=�.+��� $��Center=�$��Center=�$��0,0,0,0q�$��14(�$
��Bold"�.��
Subject:�� -   $��chooseSubject��$	��170��$��14(��� $��Center=�$��Center=�$��20,0,0,0q�$��14(�$
��Bold"�.��Grade:�� -   $��
chooseYear��$��70��$��14(��� $��Center=�$��Center=�$��20,0,0,0q�$��14(�$
��Bold"�.��	Semester:�� -   $��chooseSemester��$��40��$��14(�.@��� $��14(� �� 
IsSelected . .��I�� $��14(�.��II�� $��0,80,0,0q��� $ 
Horizontal=�$	��Top=�.+��� $��35,0,0,0q� �� CornerRadius$ 20��$��40��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��115��$��14(�.��	Subject�� $��55,0,0,0q�$ 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��260��$��14(�.��
15 minutes�� $��43,0,0,0q�$ 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$	��260��$��14(�.��
45 minutes�� $��42,0,0,0q�$ 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$��75��$��14(�.��
Semester�� $��30,0,0,0q�$ 20��
��� ���._��� ���#fff$
��Bold"�$��Center=�$��Center=�$��75��$��14(�.��	Average�� -   $
��test��$��	0,130,0,0q�#��[  