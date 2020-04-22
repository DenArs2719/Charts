using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Charts
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            Series s = new Series();
            s.Name = "My function";

            s.ChartType = SeriesChartType.Line; ///typ wykresu

            for(double x = -10;x<=10;x+=0.1)
            { 
                s.Points.AddXY(x,x*x); ///dodajemy do wykresu punkty x i naszę funkcję f(x) = x^2   
            }

            chart.Series.Add(s);

        }

       
    }
}
