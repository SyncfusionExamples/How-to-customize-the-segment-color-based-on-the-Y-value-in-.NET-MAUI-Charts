This article explains how to set the different colors for the chart column segments based on its Y value in the [.NET MAUI charts](https://www.syncfusion.com/maui-controls/maui-charts).

MAUI charts allow you to customize the appearance of the series segments color by adding the own brushes in preferred order and applying for the series [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) property.

Consider the use-case to apply different colors for the column segments based on some ranges, i.e., set CadetBlue color for the segment’s Y value less than 20, set Gray color for the segment’s Y value in between 20 and 40, and set Orange color for the segment’s value greater than 40. It has been achieved by setting the series [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) property with own Brush collection as in the below code example.

```
<chart:ColumnSeries ItemsSource="{Binding Data}"
                    XBindingPath="XValue" YBindingPath="YValue"
                    ShowDataLabels="True"
                    PaletteBrushes="{Binding CustomBrushes}">
 </chart:ColumnSeries>
```

```
public ObservableCollection<Brush> CustomBrushes { get; set; }

…
CustomBrushes = new ObservableCollection<Brush>();

foreach (var item in Data)
{
    if (item.YValue <= 20)
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.CadetBlue));
    }
    else if (item.YValue > 20 && item.YValue <= 40)
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.DarkGray));
    }
    else if (item.YValue > 40) 
    {
        CustomBrushes.Add(new SolidColorBrush(Colors.Orange));
    }
}
```

## Output:

![Customized MAUI chart column series segment color based on the Y values]()

KB article - [How to customize the segment color based on the Y value in MAUI Charts?]()

## See also

[How to create a Column Chart in MAUI?](https://www.syncfusion.com/kb/12874/how-to-create-a-column-chart-in-net-maui)