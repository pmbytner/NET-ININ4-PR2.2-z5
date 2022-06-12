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
using System.Windows.Shapes;

namespace NET_ININ4_PR2._2_z5
{
    /// <summary>
    /// Logika interakcji dla klasy WidokProduktu.xaml
    /// </summary>
    public partial class WidokProduktu : Window
    {
        public WidokProduktu(System.Xml.XmlNode produkt)
        {
            DataContext = produkt;
            InitializeComponent();
        }
    }
}
