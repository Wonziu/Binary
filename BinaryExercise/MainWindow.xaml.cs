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
using System.Runtime.InteropServices;



namespace BinaryExercise
{
    public partial class MainWindow : Window
    {

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        List<string> Foo = new List<string>();

        bool change = false;
        int z = 0;
        private string number = null;
        public string[] Box = new string[9] ;

        public MainWindow()
        {
            
            InitializeComponent();
            Mouse.OverrideCursor = Cursors.None;
            FullingList();
            FullingArray();
            Converting();
            FullingBoxes();
            BinToDec();

        }

        private void FullingArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                string temp = rnd.Next(16).ToString();
                Box[i] = temp;
            }
        }

        private void Converting()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (Box[i] == j.ToString())
                    {
                        Box[i] = Foo[j];
                        j = 16;                      
                    }
                }
            }
        }

        private void FullingBoxes()
        {
            box_1.Text = Box[0];
            box_2.Text = Box[1];
            box_3.Text = Box[2];
            box_4.Text = Box[3];
            box_5.Text = Box[4];
            box_6.Text = Box[5];
            box_7.Text = Box[6];
            box_8.Text = Box[7];
            box_9.Text = Box[8];           
        }

        private void FullingList()
        {
            Foo.Add("0000");
            Foo.Add("0001");
            Foo.Add("0010");
            Foo.Add("0011");
            Foo.Add("0100");
            Foo.Add("0101");
            Foo.Add("0110");
            Foo.Add("0111");
            Foo.Add("1000");
            Foo.Add("1001");
            Foo.Add("1010");
            Foo.Add("1011");
            Foo.Add("1100");
            Foo.Add("1101");
            Foo.Add("1110");
            Foo.Add("1111");
        }

        private void Answer(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.System && e.SystemKey == Key.F4)
            {
                e.Handled = true;
            }
            else
            {
                switch (e.Key)
                {
                    case Key.D0:
                        number += "0";
                        break;
                    case Key.D1:
                        number += "1";
                        break;
                    case Key.D2:
                        number += "2";
                        break;
                    case Key.D3:
                        number += "3";
                        break;
                    case Key.D4:
                        number += "4";
                        break;
                    case Key.D5:
                        number += "5";
                        break;
                    case Key.D6:
                        number += "6";
                        break;
                    case Key.D7:
                        number += "7";
                        break;
                    case Key.D8:
                        number += "8";
                        break;
                    case Key.D9:
                        number += "9";
                        break;
                }
            }         
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (number == Box[z])
                {
                    textBox.Text = "Dobrze kratka nr: " + (z + 1);
                    number = null;
                    z++;
                    switch (z)
                    {
                        case 1:
                            box_1.Background = Brushes.Green;
                            break;
                        case 2:
                            box_2.Background = Brushes.Green;
                            break;
                        case 3:
                            box_3.Background = Brushes.Green;
                            break;
                        case 4:
                            box_4.Background = Brushes.Green;
                            break;
                        case 5:
                            box_5.Background = Brushes.Green;
                            break;
                        case 6:
                            box_6.Background = Brushes.Green;
                            break;
                        case 7:
                            box_7.Background = Brushes.Green;
                            break;
                        case 8:
                            box_8.Background = Brushes.Green;
                            break;
                        case 9:
                            box_9.Background = Brushes.Green;
                            break;
                    }
                    if (z == 9)
                    {
                        Koty win = new Koty();
                        win.Show();
                        this.Close();
                        win.Kotek.Source = BaalTech4WonziuLib.Cat.GetCat;
                        win.TimeBox.Text = "Gratulacje !\n Naciśnij enter a dostaniesz kota :)";
                        change = true;
                    }
                }
                else
                {
                    z = 0;
                    textBox.Text = "Źle !";
                    number = null;
                    FullingList();
                    FullingArray();
                    Converting();
                    FullingBoxes();
                    BinToDec();
                    box_1.Background = Brushes.White;
                    box_2.Background = Brushes.White;
                    box_3.Background = Brushes.White;
                    box_4.Background = Brushes.White;
                    box_5.Background = Brushes.White;
                    box_6.Background = Brushes.White;
                    box_7.Background = Brushes.White;
                    box_8.Background = Brushes.White;
                    box_9.Background = Brushes.White;
                }               
            }        
        }

        private void BinToDec()
        {
            for (int i = 0; i < 9; i++)
            {
                Box[i] = Convert.ToInt32(Box[i], 2).ToString();
            }
        }

        private void Lock(object sender, MouseEventArgs e)
        {
            SetCursorPos(1, 1);
        }
    }
}
