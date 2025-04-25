using System.Collections.ObjectModel;

namespace MAUI_Chart_Segment_Color
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ObservableCollection<Brush> CustomBrushes { get; set; }

        public ViewModel() 
        {
            Data =
            [
                new Model("2015", 25),
                new Model("2016", 17),
                new Model("2017", 20),
                new Model("2018", 30),
                new Model("2019", 41),
                new Model("2020", 35),
                new Model("2021", 46),
            ];

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
        }
    }
}
