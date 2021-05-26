using System;
using System.Collections.Generic;
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
using WpfAppDied.model;
using WpfAppDied.Model;

namespace WpfAppDied
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<Train>GetTrains;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            TrainList = Globals.dataProvider.GetTrains();
        }

        public IEnumerable<Train> TrainList { get; }

        private void ExitButton_Click(Object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
