//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using UnityEditor;

namespace ScriptForge
{
		public class sf_Skins
		{
			/// <summary>
			/// The cached version of the skin
			/// </summary>
			protected static GUISkin _editorSkin; 
			protected static string _fontAwesomeLargeStyleName = "Font Awesome Large";
			protected static string _fontAwesomeStyleName = "Font Awesome";
			protected static string _widgetTitleStyleName = "Widget Title";
			protected static string _scriptForgeTitleStyleName = "Inspector Title";
			protected static string _scriptForgeSubTitleStyleName = "Inspector Sub Title";
			protected static string _fontAwesomeButtonStyleName = "Font Awesome Button";
			protected static string _infoLabel = "Info Label";
			protected static Color _unityProColor =  new Color(1.0f, 1.0f, 1.0f); 
			protected static Color _unityColor = new Color(0.0f, 0.0f, 0.0f);
			protected static Color _customColor;

			/// <summary>
			/// Gets or sets the Editor Skin
			/// </summary>
			/// <value>The Skin</value>
			public static GUISkin EDITOR_SKIN
			{
				get 
				{
					if( _editorSkin == null )
					{
						EDITOR_SKIN = Resources.Load<GUISkin>(sf_Resources.EDITOR_SKIN_UNITY);

						if( !EditorGUIUtility.isProSkin )
						{
							ChangeToUnitySkin();
						}
						else
						{
							ChangeToUnityProSkin();
						}
					}
					
					return _editorSkin;
				}

				protected set
				{
					_editorSkin = value; 
				}
			}

			public static Color ColorTint
			{
				get
				{
					return _customColor;
				}
			}

			/// <summary>
			/// Changes the skin to Unity free version (white)
			/// </summary>
			public static void ChangeToUnitySkin()
			{
				//Labels
				EDITOR_SKIN.GetStyle( _fontAwesomeStyleName ).normal.textColor = _unityColor;
				EDITOR_SKIN.GetStyle( _fontAwesomeLargeStyleName ).normal.textColor = _unityColor;
				EDITOR_SKIN.GetStyle( _widgetTitleStyleName ).normal.textColor = _unityColor;
				EDITOR_SKIN.GetStyle( _scriptForgeTitleStyleName ).normal.textColor = _unityColor;
				EDITOR_SKIN.GetStyle( _scriptForgeSubTitleStyleName ).normal.textColor = _unityColor;
				EDITOR_SKIN.label.normal.textColor = _unityColor;
				_customColor = _unityColor;
			}



			/// <summary>
			/// Changes the skin to Unity Pro version (black)
			/// </summary>
			public static void ChangeToUnityProSkin()
			{
				EDITOR_SKIN.GetStyle( _fontAwesomeStyleName ).normal.textColor = _unityProColor;
				EDITOR_SKIN.GetStyle( _fontAwesomeLargeStyleName ).normal.textColor = _unityProColor;
				EDITOR_SKIN.GetStyle( _widgetTitleStyleName ).normal.textColor = _unityProColor;	
				EDITOR_SKIN.GetStyle( _scriptForgeTitleStyleName ).normal.textColor = _unityProColor;	
				EDITOR_SKIN.GetStyle( _scriptForgeSubTitleStyleName ).normal.textColor = _unityProColor;
				EDITOR_SKIN.label.normal.textColor = _unityProColor;
				_customColor = _unityProColor;
			}

			public static void ChangeToCustomSkin(Color aTint)
			{
				EDITOR_SKIN.GetStyle( _fontAwesomeStyleName ).normal.textColor = aTint;
				EDITOR_SKIN.GetStyle( _fontAwesomeLargeStyleName ).normal.textColor = aTint;
				EDITOR_SKIN.GetStyle( _widgetTitleStyleName ).normal.textColor = aTint;	
				EDITOR_SKIN.GetStyle( _scriptForgeTitleStyleName ).normal.textColor = aTint;	
				EDITOR_SKIN.GetStyle( _scriptForgeSubTitleStyleName ).normal.textColor = aTint;
				EDITOR_SKIN.label.normal.textColor = aTint;
				_customColor = aTint;
			}

			public static GUIStyle FontAwesomeStyle
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _fontAwesomeStyleName );
				}
			}

			public static GUIStyle FontAwesomLargeStyle
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _fontAwesomeLargeStyleName );
				}
			}

			public static GUIStyle WidgetTitleStyle
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _widgetTitleStyleName );
				}
			}
			
			public static GUIStyle InspectorTitleStyle
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _scriptForgeTitleStyleName );
				}
			}

			public static GUIStyle InspectorSubTitleStyle
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _scriptForgeSubTitleStyleName );
				}
			}

			public static GUIStyle InfoLabel
			{
				get
				{
					return EDITOR_SKIN.GetStyle( _infoLabel );
				}
			}

			public static GUIStyle Button
			{
				get
				{
					GUIStyle edtiorStyle = 	EditorStyles.miniButton;
					GUIStyle customStyle =  EDITOR_SKIN.GetStyle( _fontAwesomeButtonStyleName );
				
					edtiorStyle.font = customStyle.font;
					edtiorStyle.fontSize = customStyle.fontSize;
					edtiorStyle.contentOffset = customStyle.contentOffset;
					return edtiorStyle; 
				}
			}

			public static GUIStyle MiniButtonLeft
			{
				get
				{
					GUIStyle edtiorStyle = EditorStyles.miniButtonLeft;
					GUIStyle customStyle =  EDITOR_SKIN.GetStyle( _fontAwesomeButtonStyleName );
					
					edtiorStyle.font = customStyle.font;
					edtiorStyle.fontSize = customStyle.fontSize;
					edtiorStyle.contentOffset = customStyle.contentOffset;
					return edtiorStyle; 
				}
			}

			public static GUIStyle MiniButtonMiddle
			{
				get
				{
					GUIStyle edtiorStyle = EditorStyles.miniButtonMid;
					GUIStyle customStyle =  EDITOR_SKIN.GetStyle( _fontAwesomeButtonStyleName );
					
					edtiorStyle.font = customStyle.font;
					edtiorStyle.fontSize = customStyle.fontSize;
					edtiorStyle.contentOffset = customStyle.contentOffset;
					return edtiorStyle; 
				}
			}

			public static GUIStyle MiniButtonRight
			{
				get
				{
					GUIStyle edtiorStyle = EditorStyles.miniButtonRight;
					GUIStyle customStyle =  EDITOR_SKIN.GetStyle( _fontAwesomeButtonStyleName );

					edtiorStyle.font = customStyle.font;
					edtiorStyle.fontSize = customStyle.fontSize;
					edtiorStyle.contentOffset = customStyle.contentOffset;
					return edtiorStyle; 
				}
			}

		}
}

