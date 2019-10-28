using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace SIEMApplication
{
    class Export
    {
        //export as a png image file
        public void exportChartToPng(Chart chartFrequency, string logFile, string column)
        {
            chartFrequency.SaveImage(logFile + "Column" + column + " Frequency Chart.png",ChartImageFormat.Png);
        }
    }
}
