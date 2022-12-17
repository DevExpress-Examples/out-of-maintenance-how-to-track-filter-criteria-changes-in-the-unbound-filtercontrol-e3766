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
Imports System.Windows

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

    End Class
End Namespace
