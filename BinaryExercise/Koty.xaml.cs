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

namespace BinaryExercise
{
    /// <summary>
    /// Interaction logic for Koty.xaml
    /// </summary>
    public partial class Koty : Window
    {
        public Koty()
        {
            InitializeComponent();
        }

        private void Zmiana(object sender, KeyEventArgs e)
        {
            Kotek.Source = BaalTech4WonziuLib.Cat.GetCat;
        }
    }
}
