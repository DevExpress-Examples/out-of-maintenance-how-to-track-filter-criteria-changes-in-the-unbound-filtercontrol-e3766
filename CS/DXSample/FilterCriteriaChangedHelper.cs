// Developer Express Code Central Example:
// How to track filter criteria changes in the unbound FilterControl
// 
// By default, the FilterControl's FilterCriteria
// (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic.htm)
// property is updated only after the ApplyFilter method has been called, while the
// ActualFilterCriteria
// (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic.htm)
// property does not send notifications when the user changes the filter.
// 
// This
// sample project shows how to force an unbound FilterControl to update its
// FilterCriteria property and bind another control or a view model to this
// property.
// 
// This is a temporary solution until the ID S135378, 'FilterControl
// criteria changed event' suggestion is implemented.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3766

using System;
using System.Windows;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Data.Filtering;

namespace DXSLSample {
    public class FilterCriteriaChangedHelper {

#if SILVERLIGHT
        public static readonly DependencyProperty FilterControlProperty =
            DependencyProperty.RegisterAttached("FilterControl", typeof(object), typeof(FilterCriteriaChangedHelper), new PropertyMetadata(null, new PropertyChangedCallback(FilterControlPropertyChanged)));
#else
                public static readonly DependencyProperty FilterControlProperty =
            DependencyProperty.RegisterAttached("FilterControl", typeof(object), typeof(FilterCriteriaChangedHelper), new UIPropertyMetadata(null, new PropertyChangedCallback(FilterControlPropertyChanged)));
#endif
        
        static void FilterControlPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) {
            if (e.NewValue == null) return;
            FilterControl filterControl = (FilterControl)e.NewValue;
            filterControl.LayoutUpdated += (s, a) => {
                CheckFilterCriteria(filterControl);
            };
        }

        static void CheckFilterCriteria(FilterControl filterControl) {
            if (CriteriaOperator.Equals(filterControl.ActualFilterCriteria, filterControl.FilterCriteria)) {
                return;
            }

            filterControl.ApplyFilter();
        }

        #region CLRs

        public static object GetFilterControl(DependencyObject obj) {
            return (object)obj.GetValue(FilterControlProperty);
        }

        public static void SetFilterControl(DependencyObject obj, object value) {
            obj.SetValue(FilterControlProperty, value);
        }
        #endregion
    }
}
