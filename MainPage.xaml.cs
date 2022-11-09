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

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace weather
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<WeatherCard> MyWeatherCard = new ObservableCollection<WeatherCard>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        public class WeatherCard
        {
            public DateTime Date { get; set; }
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }
            public WeatherCard() { }
            public WeatherCard(DateTime date, Image weatherIcon, String weatherNow, String weatherLater, String weather)
            {
                Date = date;

            }
            public override string ToString()
            {
                return Name + " by " + Artist + ", Released: " +
                ReleaseDate.ToShortDateString();
            }
        }

        public void onClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailPage));
        }


    }
}
