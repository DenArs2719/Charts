﻿using System;
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
            buttonAdd_Click(null, null); ///zeby jedna funckja prze uruchomeniu programu już była
            FunctionChanged(); ///żeby wykres był odrazu narysowany
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserControlPolynomial newPolynomial = new UserControlPolynomial(); ///tworzymy nową kontrolkę
            flowLayoutPanelControls.Controls.Add(newPolynomial); ///dodwanaie controlki

            newPolynomial.FunctionChanged += FunctionChanged; ///obsluga zdarzenia
            FunctionChanged(); ///żeby byłą odrazu s serje
        }

        private void FunctionChanged()  ///funkcja ktora resuje wykres
        {
            chart.Series.Clear(); ///czyścimy wszystkie funkcje

            int i = 1;
            foreach (IFunction f in flowLayoutPanelControls.Controls)
            {
                Series s = new Series();
                s.Name = i.ToString() + ". " + f.FunctionName;///żeby nie wypadł bląd na serje
                i++;

                s.ChartType = SeriesChartType.Line; ///typ wykresu

                for (double x = -10; x <= 10; x += 0.1)
                {
                    s.Points.AddXY(x, f.Value(x)); ///dodajemy do wykresu punkty x i naszę funkcję f(x) = x   
                }

                chart.Series.Add(s);
            }
        }
    }
}
