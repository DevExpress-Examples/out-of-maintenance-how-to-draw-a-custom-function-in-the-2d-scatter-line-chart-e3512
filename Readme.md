<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569821/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3512)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ScatterLineChartWithCustomFunction/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ScatterLineChartWithCustomFunction/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ScatterLineChartWithCustomFunction/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ScatterLineChartWithCustomFunction/MainWindow.xaml.vb))
<!-- default file list end -->
# How to draw a custom function in the 2D Scatter Line chart  


<p>This example demonstrates how to draw an Archimedian Spiral function in the 2D Scatter Line chart. </p><br />



<h3>Description</h3>

<p>To do this, it is necessary to add a<strong> LineScatterSeries2D</strong> object to the  diagram&#39;s <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsDiagram_Seriestopic"><u>Series</u></a> collection and then programmatically add series points to it. For more information, see the <strong>CreateArchimedianSpiralPoints</strong> method&#39;s implementation below.</p><br />


<br/>


