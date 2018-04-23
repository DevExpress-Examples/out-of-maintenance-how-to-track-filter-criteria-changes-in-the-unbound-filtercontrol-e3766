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
using System.Windows.Controls;
using System.Collections.Generic;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Settings;

namespace DXSLSample {
    public partial class View : UserControl {
        public View() {
            InitializeComponent();

            Loaded += new System.Windows.RoutedEventHandler(View_Loaded);
        }

        void View_Loaded(object sender, System.Windows.RoutedEventArgs e) {

            List<FilterColumn> list = new List<FilterColumn>();       
            list.Add(new FilterColumn() { FieldName = "Name", ColumnType = typeof(string) });
            list.Add(new FilterColumn() { FieldName = "DateTime", ColumnType = typeof(DateTime), EditSettings = new DateEditSettings() });

            filterControl.FilterColumns = list;
        }
    }

    public class TestData {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}
