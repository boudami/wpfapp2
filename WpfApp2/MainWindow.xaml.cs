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

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Class1 c1 = new Class1();
        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            c1.nome = "Amin";
            c1.cognome = "Boudlale";
            lblStampa.Content = c1.nome + c1.cognome;
            
            
        }
    }

    
}
