﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm

Namespace DXSample.Common.ViewModels
    Public Class ViewModelLogicalLayoutHelper
        Public Shared Property PersistentLogicalLayout() As String
            Get
                Return LayoutSettings.Default.LogicalLayout
            End Get
            Set(ByVal value As String)
                LayoutSettings.Default.LogicalLayout = value
            End Set
        End Property

        Private Shared persistentViewsLayout_Renamed As Dictionary(Of String, String)
        Public Shared ReadOnly Property PersistentViewsLayout() As Dictionary(Of String, String)
            Get
                If persistentViewsLayout_Renamed Is Nothing Then
                    persistentViewsLayout_Renamed = LogicalLayoutSerializationHelper.Deserialize(LayoutSettings.Default.ViewsLayout)
                End If
                Return persistentViewsLayout_Renamed
            End Get
        End Property
        Public Shared Sub SaveLayout()
            LayoutSettings.Default.ViewsLayout = LogicalLayoutSerializationHelper.Serialize(PersistentViewsLayout)
            LayoutSettings.Default.Save()
        End Sub
        Public Shared Sub ResetLayout()
            PersistentViewsLayout.Clear()
            PersistentLogicalLayout = Nothing
            SaveLayout()
        End Sub
    End Class
End Namespace
