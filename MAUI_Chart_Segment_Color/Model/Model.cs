using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Chart_Segment_Color
{
    public class Model
    {
        public string XValue { get; set; }
        public double YValue { get; set; }
        public Model(string xvalue, double yValue)
        {
            XValue = xvalue;
            YValue = yValue;
        }
    }
}
