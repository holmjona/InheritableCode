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

            //Person pd = new Person();
            //Person po1 = new Person("frankie","hollywood");
            //Person po2 = new Person("jackie", "chan", new DateTime(1954,4,7));


         //   SuperHero s1 = new SuperHero();
            SuperHero s2 = new SuperHero("Super", "Man");
            Villian v = new Villian();

            Person p3 = s2;

            MessageBox.Show(s2.CapeColor);

            Person p4 = v.CopyMe();
            p4.FirstName = "Boris";
            v.LastName = "Horizontal";

            Person p5 = s2.CopyMe();
            p5.FirstName = "Stellar";
            s2.LastName = "Inter";


            //lbPeoples.Items.Add(pd.FirstName + " - " + pd.Sing());
            //lbPeoples.Items.Add(s2.FirstName + " - " + s2.Sing() );
            //lbPeoples.Items.Add(p3.FirstName + " - " + p3.Sing());
            //lbPeoples.Items.Add(v.FirstName + " - " + v.Sing());
            //lbPeoples.Items.Add(p4.FirstName + " - " + p4.Sing());

            lbPeoples.Items.Add(s2.ToString());
            lbPeoples.Items.Add(p3);
            lbPeoples.Items.Add(v);
            lbPeoples.Items.Add(p4.ToString());

            Button b;

        }
    }
}
