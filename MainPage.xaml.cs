using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace weather
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<WeatherCard> WeatherList = new ObservableCollection<WeatherCard>();

        public MainPage()
        {
            this.InitializeComponent();

            WeatherList.Add(new WeatherCard(new DateTime(2022, 1, 1), new Image(), "Weather Now", "Weather Later", "Weather"));
            WeatherList.Add(new WeatherCard(new DateTime(2022, 2, 2), new Image(), "Weather Now", "Weather Later", "Weather"));
            WeatherList.Add(new WeatherCard(new DateTime(2022, 3, 3), new Image(), "Weather Now", "Weather Later", "Weather"));
            WeatherList.Add(new WeatherCard(new DateTime(2022, 4, 4), new Image(), "Weather Now", "Weather Later", "Weather"));
            WeatherList.Add(new WeatherCard(new DateTime(2022, 5, 5), new Image(), "Weather Now", "Weather Later", "Weather"));
        }

        public class WeatherCard
        {
            public DateTime Date { get; set; }
            public Image WeatherIcon { get; set; }
            public String WeatherNow { get; set; }
            public String WeatherLater { get; set; }
            public String Weather { get; set; }

            public WeatherCard() { }

            public WeatherCard(DateTime date, Image weatherIcon, String weatherNow, String weatherLater, String weather)
            {
                Date = date;
                WeatherIcon = weatherIcon;
                WeatherNow = weatherNow;
                WeatherLater = weatherLater;
                Weather = weather;
            }
            public override string ToString()
            {
                return "Weather: " + Date.ToShortDateString() + WeatherIcon + WeatherIcon + WeatherLater + Weather;
            }
        }

        public void onClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailPage));
        }


    }
}
