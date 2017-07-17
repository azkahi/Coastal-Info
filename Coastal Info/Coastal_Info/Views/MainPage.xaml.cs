using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Coastal_Info.Models;

namespace Coastal_Info.Views
{
    public partial class MainPage : ContentPage
    {
        private List<String> Regions = new List<string>()
        {
            "A (Western)",
            "B (Central)",
            "C (Eastern)"
        };

        private List<String> Stations = new List<string>()
        {
            "Badas",
            "Balikpapan",
            "Banten (Ciwandan)",
            "Binuangeun",
            "Carik",
            "Celukan Bawang",
            "Cirebon"
        };

        private List<String> Predictions = new List<string>()
        {
            "Yes",
            "No"
        };

        public MainPage()
        {
            InitializeComponent();
            PopulatePickers();
        }

        private void PopulatePickers()
        {
            foreach (string s in Regions)
            {
                RegionPicker.Items.Add(s);
            }

            foreach (string s in Stations)
            {
                StationPicker.Items.Add(s);
            }

            foreach (string s in Predictions)
            {
                PredictionPicker.Items.Add(s);
            }
        }

        public async void SearchButton(object sender, EventArgs e)
        {
            if (RegionPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Region Not Selected", "Please select a region.", "Ok");
                return;
            }
            if (StationPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Station Not Selected", "Please select a station.", "Ok");
                return;
            }
            if (StationPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Prediction Not Selected", "Please select a prediction.", "Ok");
                return;
            }

            CoastalData coastalData = new CoastalData
            {
                Region = RegionPicker.Items[RegionPicker.SelectedIndex],
                Station = StationPicker.Items[StationPicker.SelectedIndex],
                DateStart = DateStartPicker.Date,
                DateEnd = DateEndPicker.Date,
            };

            string _prediction = PredictionPicker.Items[PredictionPicker.SelectedIndex];
            if (_prediction == "Yes")
            {
                coastalData.Prediction = true;
            } else
            {
                coastalData.Prediction = false;
            }

            ResultPage resultPage = new ResultPage();
            resultPage.BindingContext = coastalData;
            await Navigation.PushModalAsync(resultPage);
        }
    }
}
