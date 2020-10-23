using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
namespace test
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public class Monstre
    {
        string nom;
        int pv;
        string degat;

        public Monstre(string nom, int pv, string degat)
        {
            this.Nom = nom;
            this.Pv = pv;
            this.Degat = degat;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Pv { get => pv; set => pv = value; }
        public string Degat { get => degat; set => degat = value; }

        public override string ToString()
        {
            return "Le " + Nom + " qui a " + Pv + "pv et frappe de " + Degat + ".";
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent(); ObservableCollection<Monstre> monstres = new ObservableCollection<Monstre>();
            monstres.Add(new Monstre("Goblin", 6, "1d4"));
            monstres.Add(new Monstre("Grade goblin", 8, "1d4"));
            monstres.Add(new Monstre("Roi des goblins", 20, "1d4"));

            lesMonstres.ItemsSource = monstres;
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click()
        {

        }
    }
}
