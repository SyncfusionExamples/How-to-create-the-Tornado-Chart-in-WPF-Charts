# How to create the Tornado Chart in WPF Charts

This example explains how to create a Tornado Chart using the [Bar](https://help.syncfusion.com/wpf/charts/seriestypes/columnandbar#bar-chart) and [RangeColumn](https://help.syncfusion.com/wpf/charts/seriestypes/range#range-column-chart) Charts.

Tornado Chart is a special type of bar chart where the bars extend from the defined midpoint. Two series are required for a chart to achieve Tornado Chart by the following these steps.

## Tornado Chart using the Bar Chart

**Step1:** Create [Bar](https://help.syncfusion.com/wpf/charts/seriestypes/columnandbar#bar-chart) Series with Binding of  [ItemSource](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource), [XBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_XBindingPath), and [YBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.XyDataSeries.html?tabs=tabid-1#Syncfusion_UI_Xaml_Charts_XyDataSeries_YBindingPath) properties.

**Step2:** By using the [LabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Chart.ChartAdornmentInfo.html#Syncfusion_Windows_Chart_ChartAdornmentInfo_LabelTemplate) in [ChartAdornmentInfo](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Chart.ChartAdornmentInfo.html) class, you can display the model data in data marker as demonstrated in the following code example.

**XAML**
```
<!--Create Bar Series and bind Models property to ItemsSource-->
<chart:BarSeries SideBySideSeriesPlacement="False" EnableAnimation="True" ItemsSource="{Binding Models}" 
         XBindingPath="Year" Interior="LightBlue" Palette="None" Label=" Export" YBindingPath="Export">
	<chart:BarSeries.AdornmentsInfo>
		<chart:ChartAdornmentInfo AdornmentsPosition="Top" ShowLabel="True" 
				HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="10">                       
		</chart:ChartAdornmentInfo>
   </chart:BarSeries.AdornmentsInfo>
</chart:BarSeries>

<chart:BarSeries EnableAnimation="True" ItemsSource="{Binding Models}" 
		XBindingPath="Year"  Interior="LightCoral" YBindingPath="Import" 
		Palette="None"  Label="Import">
	<chart:BarSeries.AdornmentsInfo>
		<chart:ChartAdornmentInfo AdornmentsPosition="Top" ShowLabel="True" 
				HorizontalAlignment="Center" VerticalAlignment="Center">
			<!--LabelTemplate to show Positive values in Label of Series-->
			<chart:ChartAdornmentInfo.LabelTemplate>
				<DataTemplate>
					<Grid>
						<TextBlock FontSize="10" Text="{Binding Converter={StaticResource ValueConverter}}"/>
					</Grid>
				</DataTemplate>
			</chart:ChartAdornmentInfo.LabelTemplate>
		</chart:ChartAdornmentInfo>
	</chart:BarSeries.AdornmentsInfo>
</chart:BarSeries>
```

### Output:

![Tornado chart using Bar chart](https://user-images.githubusercontent.com/53489303/200747476-727725e3-c11c-4e0a-90cd-dbac6b5ad9e4.png)

## Tornado Chart using the Range Column Chart

**Step1:** Create [RangeColumn](https://help.syncfusion.com/wpf/charts/seriestypes/range#range-column-chart) series with Binding of [ItemSource](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource), [XBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_XBindingPath), and [YBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.XyDataSeries.html?tabs=tabid-1#Syncfusion_UI_Xaml_Charts_XyDataSeries_YBindingPath) properties.

**Step2:** By using the [LabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Chart.ChartAdornmentInfo.html#Syncfusion_Windows_Chart_ChartAdornmentInfo_LabelTemplate) in [ChartAdornmentInfo](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Chart.ChartAdornmentInfo.html) class, you can display the model data in data marker as demonstrated in the following code example.

**XAML**
```
<!--Create RangeColumnSeries and bind Models property to ItemsSource-->
<chart:RangeColumnSeries SideBySideSeriesPlacement="False" EnableAnimation="True" ItemsSource="{Binding Models}" 
	  XBindingPath="DeptName" Interior="LightBlue" IsTransposed="True" Palette="None" High="PassStart" Low="Pass">
	<!--To show label using ChartAdornmentInfo-->                                   
	<chart:RangeColumnSeries.AdornmentsInfo>
		 <chart:ChartAdornmentInfo AdornmentsPosition="Bottom"  FontSize="10" ShowLabel="True"
 HorizontalAlignment="Center" VerticalAlignment="Center">      
		 </chart:ChartAdornmentInfo>
	 </chart:RangeColumnSeries.AdornmentsInfo>
</chart:RangeColumnSeries>

<chart:RangeColumnSeries EnableAnimation="True" ItemsSource="{Binding Models}" 
IsTransposed="True" XBindingPath="DeptName" Low="PassEnd"                                                                                          
	  Interior="LightCoral" High="Pass" Palette="None" >
	<!--To show label using ChartAdornmentInfo-->
	<chart:RangeColumnSeries.AdornmentsInfo>
		<chart:ChartAdornmentInfo AdornmentsPosition="Top"  
			ShowLabel="True" FontSize="10" HorizontalAlignment="Center" VerticalAlignment="Center">                       
		</chart:ChartAdornmentInfo>
	</chart:RangeColumnSeries.AdornmentsInfo>
</chart:RangeColumnSeries>
```

### Output:

![Tornado chart using RangeColumn chart](https://user-images.githubusercontent.com/53489303/200747452-95047e73-a416-4fa1-8776-9cd5bc1110e0.png)

KB article - [How to create the Tornado Chart in WPF Charts?](https://www.syncfusion.com/kb/11657/how-to-create-the-tornado-chart-in-wpf-charts)

### See also

[How to add a series side by side](https://www.syncfusion.com/kb/132/how-to-add-a-series-side-by-side)

[How to display the axis labels in a particular format](https://www.syncfusion.com/kb/3318/how-to-display-the-axis-labels-in-a-particular-format)

[How can you modify axis text elements without disturbing the axis labels](https://www.syncfusion.com/kb/5123/how-can-you-modify-axis-text-elements-without-disturbing-the-axis-labels)
