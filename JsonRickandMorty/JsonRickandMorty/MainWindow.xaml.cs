using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JsonRickandMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string dataSetURL = "https://rickandmortyapi.com/api/character/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(dataSetURL);
                string json = client.GetStringAsync(dataSetURL).Result;
                RickandMortyAPI rickandmortyStuff = JsonConvert.DeserializeObject<RickandMortyAPI>(json);
                
            }
            foreach (var character in RickandMortyAPI.results)
            {

            }
        }
    }
}
