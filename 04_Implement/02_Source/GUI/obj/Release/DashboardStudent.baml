   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI      GUI.DashboardStudent   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:GUI     -     � Icon$$  img/icons/logo_app_desktop.png�� � Title$ Dashboard Student��$	��768��$
��1366�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .���� ���#fff �� CornerRadius$ 0�����#00a7ee$	��1.5q�._�� 
�������.+��� -    ��Name$ TitleBar��$��40�����#00a7ee$ 0��$	��Top=��� -   $��btnClose��$��0q�$��Center=�$��Center=�$��X��$��Right=�$��0q�$	��Top=�$��40��$��Arial)�$��15(�$
��Bold"�$��40��$��0,0,1,0q���Z� ����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value
 �#00a7ee�� 	 � ��
 �#fff�� 	 � ��
 ��  �� 
TargetType" ��.R��� #��z��$ 0��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ��� 	 � ��

 �  ���� 	 � ��

 ������� -   $��btnMini��$��0q�$��Center=�$��Center=�$��_��$��Right=�$��0,0,41,0q�$��0q�$	��Top=�$��40��$��Arial)�$��15(�$
��Bold"�$��40����Z� ���� " ��.��� 	 � ��
 �#00a7ee�� 	 � ��
 �#fff�� 	 � ��
 �� " ��.R��� #��z��$ 0��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 	 � ��

 � ����� 	 � ��

 ������� $
��Left=�$��36��$��36��$	��Top=�$#��img/icons/logo_icon_white.png��$��2,2,0,0q� � -     �Name$ GridPrincipal��$��305,144,30,30q�  � NavigationUIVisibility$ Hidden=����#fff$
��1028��$	��591��� $	��275��$
��Left=����	#FF222222$��	0,115,0,0q�.+��� $��Center=�$��Center=�$��18(����#fff$��STUDENT�����#039866$
��Left=�$��75��$��	0,-75,0,0q�$	��Top=�$	��275��$
��Bold"�� -    �Name$ 
GridCursor��$��	0,100,0,0q����#00a7ee$��10��$
��Left=�$��60��$	��Top=��� -    ��Name$ ListViewMenu��$��0q�$��	0,100,0,0q�
�������$��Arial)�$��18(� �� SelectedIndex$ 0����Z� ��Z� .@��� $��60��$
��Bold"�.����  �� Orientation$ 
Horizontal=�.+��� $!��img/icons/myinformation.png��$��10,0,0,0q�$��30��$��30���� $��17(�$��Center=�$��My Information��$��5,0,0,0q�$��19���� $��60��$
��Bold"�.���� $ 
Horizontal=�.+��� $��img/icons/myscore.png��$��10,0,0,0q�$��30��$��30���� $��My Score��$��17(�$��Center=�$��5,0,0,0q��� $"��img/icons/student_avatar.png��$��10,19,205,571q�$��60��$��60��$��Center=�$��Center=��� -   $��fullname_title��$��0q�$��14(����#fff$��Leo Nguyen Student��$
��Left=�$��	75,19,0,0q�$	��Top=�$
��Bold"�$	��190���� -	   $��class_title��$��0q�$��14(����#fff$��K16 Student��$
��Left=�$��	75,49,0,0q�$	��Top=�$
��Bold"�$	��190���� ���#fff$
��Left=�$��75��$��
275,40,0,0q�$	��Top=�$
��1088���� -
   $��logout��$��0q�$��Center=�$��1262,60,9,669q����#E74C3C$��92��$��35����Z� .���� $ 
Horizontal=�.+��� $��20��$��3,0,0,0q�	Log out�� $��img/icons/logout_btn.png��$��27��$��40��$��	-10,0,0,0q�$��Right=�$��Center=��� $��Management Dashboard��$
��Left=�$��
305,60,0,0q�$	��Top=�$��17(�$
��Bold"�