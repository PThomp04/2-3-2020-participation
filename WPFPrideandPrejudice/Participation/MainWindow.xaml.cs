using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace Participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run text = new Run();

            var book = File.ReadAllText("Pride and Prejudice by Jane Austin.txt");
            text.Text = book;
            text.Foreground = Brushes.DarkBlue;
            p.Inlines.Add(text);
            fd.Blocks.Add(p);
           // PrideTB.


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\thom5434\Downloads\SalesJan2009.csv";
            var lines = File.ReadAllLines(path);
            MessageBox.Show("Read it in successfully!");

        }
    }
}
