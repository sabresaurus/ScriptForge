﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ScriptForge
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ScenesTemplate : ScriptForge.BaseTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
 WriteClassOutline(); 
            return this.GenerationEnvironment.ToString();
        }

    /// <summary>
    /// A function used to define any content that should exist in this classes namespace.
    /// </summary>
    public override void WriteNamespaceContent()
    {
    }

	/// <summary>
    /// This class contains all our GUI Content labels that we use in Script Forge
    /// </summary>
    public override void WriteClassContent()
    {
		// Const elements
		for(int i = 0; i < m_Scenes.Length; i++)
        {
			Write("public const string ");
			Write(m_Scenes[i].ToUpper());
			Write(" = \"");
			Write(m_Scenes[i]);
			WriteLine("\";");
        }

		// Space
		WriteLine("");

		// Array

		WriteLine("/// <summary>");
        WriteLine("/// Returns back an new array containing all the");
        WriteLine("/// scenes that are in the build settings. You");
        WriteLine("/// should cache this value as it creates a new");
        WriteLine("/// array each time.");
        WriteLine("/// </summary>");
		WriteLine("public static string[] Names");
		WriteLine("{");
		PushIndent(indent);
        {
			WriteLine("get");
		
			WriteLine("{");
			PushIndent(indent);
            {
				WriteLine("return new string[]");
				WriteLine("{");
				PushIndent(indent);
                {
					for(int i = 0; i < m_Scenes.Length; i++)
					{
						Write("\"");
						Write(m_Scenes[i]);
						WriteLine("\",");
					}
                }
				PopIndent();
				WriteLine("};");
            }
			PopIndent();
			WriteLine("}");
        }
		PopIndent();
		WriteLine("}");
    }

	/// <summary>
    /// Invoked when the enum should be defined by this widget.
    /// </summary>
    public override void WriteEnumContent()
    {
		if(!m_CreateEnum)
        {
			return;
        }

this.Write("/// <summary>\r\n/// An enum that contains the names of every scene that\r\n/// is in" +
        " your project.\r\n/// </summary>\r\n");


		Write("public enum ");
		WriteLine(m_EnumName);
		WriteLine("{");
		PushIndent(indent);
		for(int i = 0; i < m_Scenes.Length; i++)
        {
			Write(m_Scenes[i]);
			if( i < m_Scenes.Length - 1)
            {
				WriteLine(",");
            }
			else
            {
				WriteLine(string.Empty);
            }
        }
		PopIndent();
		WriteLine("}");
		WriteLine(string.Empty);
    }


private string _m_EnumNameField;

/// <summary>
/// Access the m_EnumName parameter of the template.
/// </summary>
private string m_EnumName
{
    get
    {
        return this._m_EnumNameField;
    }
}

private string[] _m_ScenesField;

/// <summary>
/// Access the m_Scenes parameter of the template.
/// </summary>
private string[] m_Scenes
{
    get
    {
        return this._m_ScenesField;
    }
}

private bool _m_CreateEnumField;

/// <summary>
/// Access the m_CreateEnum parameter of the template.
/// </summary>
private bool m_CreateEnum
{
    get
    {
        return this._m_CreateEnumField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public override void Initialize()
{
    base.Initialize();
    if ((this.Errors.HasErrors == false))
    {
bool m_EnumNameValueAcquired = false;
if (this.Session.ContainsKey("m_EnumName"))
{
    this._m_EnumNameField = ((string)(this.Session["m_EnumName"]));
    m_EnumNameValueAcquired = true;
}
if ((m_EnumNameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("m_EnumName");
    if ((data != null))
    {
        this._m_EnumNameField = ((string)(data));
    }
}
bool m_ScenesValueAcquired = false;
if (this.Session.ContainsKey("m_Scenes"))
{
    this._m_ScenesField = ((string[])(this.Session["m_Scenes"]));
    m_ScenesValueAcquired = true;
}
if ((m_ScenesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("m_Scenes");
    if ((data != null))
    {
        this._m_ScenesField = ((string[])(data));
    }
}
bool m_CreateEnumValueAcquired = false;
if (this.Session.ContainsKey("m_CreateEnum"))
{
    this._m_CreateEnumField = ((bool)(this.Session["m_CreateEnum"]));
    m_CreateEnumValueAcquired = true;
}
if ((m_CreateEnumValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("m_CreateEnum");
    if ((data != null))
    {
        this._m_CreateEnumField = ((bool)(data));
    }
}


    }
}


    }
}
