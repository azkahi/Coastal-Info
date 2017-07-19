using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coastal_Info.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultDetailPage : ContentPage
    {
        private Frame tableContentTemplate;
        private Label contentTemplate;

        public ResultDetailPage()
        {
            InitializeComponent();
            contentTemplate = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            tableContentTemplate = new Frame
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                OutlineColor = Color.Black
            };

            for (int i = 0; i <= 20; i ++)
            {
                TableDetail.RowDefinitions.Add(new RowDefinition { Height = 20 });
                TableDetail.Children.Add(new Frame
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Black,
                    Padding = new Thickness(0.0, 0.0),
                    Content = new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Text = 20 + i + "/7/2017"
                    }
                }, 0, i);
                TableDetail.Children.Add(new Frame
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Black,
                    Padding = new Thickness(0.0, 0.0),
                    Content = new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Text = "19:00"
                    }
                }, 1, i);
                TableDetail.Children.Add(new Frame
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Black,
                    Padding = new Thickness(0.0, 0.0),
                    Content = new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Text = "1.00"
                    }
                }, 2, i);
            }

        }
    }
}