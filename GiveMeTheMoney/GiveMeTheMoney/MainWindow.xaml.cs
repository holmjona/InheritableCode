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

namespace GiveMeTheMoney {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Person pd = new Person();
            Person po1 = new Person("frankie","hollywood");
            Person po2 = new Person("jackie", "chan", new DateTime(1954,4,7));

         //   SuperHero s1 = new SuperHero();
            SuperHero s2 = new SuperHero("Super", "Man");
                

        }
    }
}
