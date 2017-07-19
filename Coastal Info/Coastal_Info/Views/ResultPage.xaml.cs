using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Coastal_Info.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultPage : ContentPage
	{
        public ObservableCollection<string> CarouselTest { get; set; }

        public PlotModel CoastalModel { get; set; }

        public ResultPage()
        {
            InitializeComponent();
            CoastalModel = new PlotModel { Title = "Coastal Info" };

            var startDate = DateTime.Now.AddDays(-10);
            var endDate = DateTime.Now;

            var minValue = DateTimeAxis.ToDouble(startDate);
            var maxValue = DateTimeAxis.ToDouble(endDate);

            CoastalModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "d/M" });


            LineSeries lineSeries = new LineSeries();

            lineSeries.Points.Add(new DataPoint(minValue, 0.8));
            lineSeries.Points.Add(new DataPoint(minValue + 1, 0.6));
            lineSeries.Points.Add(new DataPoint(minValue + 2, 1.2));
            lineSeries.Points.Add(new DataPoint(minValue + 3, 1.8));
            lineSeries.Points.Add(new DataPoint(minValue + 4, 1.6));
            lineSeries.Points.Add(new DataPoint(minValue + 5, 1.4));
            lineSeries.Points.Add(new DataPoint(minValue + 6, 1.2));
            lineSeries.Points.Add(new DataPoint(minValue + 7, 1.0));
            lineSeries.Points.Add(new DataPoint(minValue + 8, 0.8));
            lineSeries.Points.Add(new DataPoint(minValue + 9, 1.2));

            CoastalModel.Series.Add(lineSeries);

            CoastalPlotView.Model = CoastalModel;

            BindingContext = this;
        }
	}
}