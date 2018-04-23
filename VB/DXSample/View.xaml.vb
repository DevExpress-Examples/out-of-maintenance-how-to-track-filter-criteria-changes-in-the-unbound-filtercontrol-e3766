' Developer Express Code Central Example:
' How to track filter criteria changes in the unbound FilterControl
' 
' By default, the FilterControl's FilterCriteria
' (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic.htm)
' property is updated only after the ApplyFilter method has been called, while the
' ActualFilterCriteria
' (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic.htm)
' property does not send notifications when the user changes the filter.
' 
' This
' sample project shows how to force an unbound FilterControl to update its
' FilterCriteria property and bind another control or a view model to this
' property.
' 
' This is a temporary solution until the ID S135378, 'FilterControl
' criteria changed event' suggestion is implemented.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3766

Imports System
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports DevExpress.Xpf.Editors.Filtering
Imports DevExpress.Xpf.Editors.Settings

Namespace DXSLSample
    Partial Public Class View
        Inherits UserControl

        Public Sub New()
            InitializeComponent()

            AddHandler Loaded, AddressOf View_Loaded
        End Sub

        Private Sub View_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)

            Dim list As New List(Of FilterColumn)()
            list.Add(New FilterColumn() With {.FieldName = "Name", .ColumnType = GetType(String)})
            list.Add(New FilterColumn() With {.FieldName = "DateTime", .ColumnType = GetType(Date), .EditSettings = New DateEditSettings()})

            filterControl.FilterColumns = list
        End Sub
    End Class

    Public Class TestData
        Public Property Name() As String
        Public Property DateTime() As Date
    End Class
End Namespace
