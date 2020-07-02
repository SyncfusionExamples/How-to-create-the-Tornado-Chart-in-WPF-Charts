# How-to-create-the-Tornado-Chart-in-WPF-Charts

This example explains how to create a Tornado Chart using the Bar and RangeColumn Charts. Please refer KB links for more details,

[How to create a Tornado Chart?](https://www.syncfusion.com/kb/11657/how-to-create-the-tornado-chart-in-wpf-charts)

Tornado Chart is a special type of bar chart where the bars extend from the defined midpoint. Two series are required for a chart to achieve Tornado Chart by the following these steps.

**Tornado Chart using the Bar Chart**

Step1: Create Bar Series with Binding of  ItemSource, XBindingPath, and YBindingPath properties. 
Step2: By using the LabelTemplate in ChartAdornmentInfo class, you can display the model data in data marker as demonstrated in the following code example.

**XAML**
```
<!--Create Bar Series and bind Models property to ItemsSource-->
    <chart:BarSeries SideBySideSeriesPlacement="False" EnableAnimation="True" 	ItemsSource="{Binding Models}" 
    XBindingPath="Year" Interior="LightBlue" 	Palette="None" Label=" Export" YBindingPath="Export">
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
                                    <TextBlock FontSize="10"
			Text="{Binding Converter={StaticResource ValueConverter}}"/>
                                </Grid>
                            </DataTemplate>
                        </chart:ChartAdornmentInfo.LabelTemplate>
                    </chart:ChartAdornmentInfo>
               </chart:BarSeries.AdornmentsInfo>
        </chart:BarSeries>
```

**Tornado Chart using the Range Column Chart**

Step1: Create RangeColumn series with Binding of  ItemSource, XBindingPath, and YBindingPath properties. 
Step2: By using the LabelTemplate in ChartAdornmentInfo class, you can display the model data in data marker as demonstrated in the following code example.

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
                           ShowLabel="True"  FontSize="10" HorizontalAlignment="Center"     
                            VerticalAlignment="Center">                       
                    </chart:ChartAdornmentInfo>
               </chart:RangeColumnSeries.AdornmentsInfo>
      </chart:RangeColumnSeries>
```

