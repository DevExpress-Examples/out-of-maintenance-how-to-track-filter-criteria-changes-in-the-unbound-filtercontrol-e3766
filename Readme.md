<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128645017/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3766)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FilterCriteriaChangedHelper.cs](./CS/DXSample/FilterCriteriaChangedHelper.cs) (VB: [FilterCriteriaChangedHelper.vb](./VB/DXSample/FilterCriteriaChangedHelper.vb))
* **[MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/DXSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXSample/MainWindow.xaml.vb))
* [View.xaml](./CS/DXSample/View.xaml) (VB: [View.xaml](./VB/DXSample/View.xaml))
* [View.xaml.cs](./CS/DXSample/View.xaml.cs) (VB: [View.xaml.vb](./VB/DXSample/View.xaml.vb))
<!-- default file list end -->
# How to track filter criteria changes in the unbound FilterControl


<p>By default, the FilterControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic"><u>FilterCriteria</u></a> property is updated only after the ApplyFilter method has been called, while the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic"><u>ActualFilterCriteria</u></a> property does not send notifications when the user changes the filter.</p>
<p>This sample project shows how to force an unbound FilterControl to update its FilterCriteria property and bind another control or a view model to this property.</p>
<p> <br />To learn more on how to implement similar functionality in <strong>Silverlight,</strong> refer to the <a href="https://www.devexpress.com/Support/Center/p/T246246">T246246</a> example.</p>

<br/>


