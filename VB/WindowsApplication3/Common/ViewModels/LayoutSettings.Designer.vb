﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace DXSample.Common.ViewModels


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
    Friend NotInheritable Partial Class LayoutSettings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As LayoutSettings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New LayoutSettings()), LayoutSettings))

        Public Shared ReadOnly Property [Default]() As LayoutSettings
            Get
                Return defaultInstance
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property LogicalLayout() As String
            Get
                Return (DirectCast(Me("LogicalLayout"), String))
            End Get
            Set(ByVal value As String)
                Me("LogicalLayout") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property ViewsLayout() As String
            Get
                Return (DirectCast(Me("ViewsLayout"), String))
            End Get
            Set(ByVal value As String)
                Me("ViewsLayout") = value
            End Set
        End Property
    End Class
End Namespace
