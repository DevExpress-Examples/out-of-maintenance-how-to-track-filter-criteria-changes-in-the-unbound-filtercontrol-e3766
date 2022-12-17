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
Imports DevExpress.Xpf.Editors.Filtering

Namespace DXSLSample

    Public Class FilterCriteriaChangedHelper

#If SILVERLIGHT
        public static readonly DependencyProperty FilterControlProperty =
            DependencyProperty.RegisterAttached("FilterControl", typeof(object), typeof(FilterCriteriaChangedHelper), new PropertyMetadata(null, new PropertyChangedCallback(FilterControlPropertyChanged)));
#Else
        Public Shared ReadOnly FilterControlProperty As DependencyProperty = DependencyProperty.RegisterAttached("FilterControl", GetType(Object), GetType(FilterCriteriaChangedHelper), New UIPropertyMetadata(Nothing, New PropertyChangedCallback(AddressOf FilterControlPropertyChanged)))

#End If
        Private Shared Sub FilterControlPropertyChanged(ByVal sender As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            If e.NewValue Is Nothing Then Return
            Dim filterControl As FilterControl = CType(e.NewValue, FilterControl)
            AddHandler filterControl.LayoutUpdated, Sub(s, a) CheckFilterCriteria(filterControl)
        End Sub

        Private Shared Sub CheckFilterCriteria(ByVal filterControl As FilterControl)
            If Equals(filterControl.ActualFilterCriteria, filterControl.FilterCriteria) Then
                Return
            End If

            filterControl.ApplyFilter()
        End Sub

'#Region "CLRs"
        Public Shared Function GetFilterControl(ByVal obj As DependencyObject) As Object
            Return CObj(obj.GetValue(FilterControlProperty))
        End Function

        Public Shared Sub SetFilterControl(ByVal obj As DependencyObject, ByVal value As Object)
            obj.SetValue(FilterControlProperty, value)
        End Sub
'#End Region
    End Class
End Namespace
