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

namespace kolko_i_krzyzyk
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

        bool gracz1 = true;
        int ruch = 0;

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Restartuj();
            wynikO.Content = "0";
            wynikX.Content = "0";
            kto.Content = "O";
            gracz1 = true;
        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;

            foreach (var b in all)
            {
                b.IsEnabled = true;
                b.Content = "";
            }
        }


        private void Sprawdz()
        {
            if (btn1.Content != "" && btn1.Content == btn2.Content && btn2.Content == btn3.Content)
            {
                Wygrana();
            }
            else if (btn4.Content != "" && btn4.Content == btn5.Content && btn5.Content == btn6.Content)
            {
                Wygrana();
            }
            else if (btn7.Content != "" && btn7.Content == btn8.Content && btn8.Content == btn9.Content)
            {
                Wygrana();
            }
            else if (btn1.Content != "" && btn1.Content == btn4.Content && btn4.Content == btn7.Content)
            {
                Wygrana();
            }
            else if (btn2.Content != "" && btn2.Content == btn5.Content && btn5.Content == btn8.Content)
            {
                Wygrana();
            }
            else if (btn3.Content != "" && btn3.Content == btn6.Content && btn6.Content == btn9.Content)
            {
                Wygrana();
            }
            else if (btn1.Content != "" && btn1.Content== btn5.Content && btn5.Content == btn9.Content)
            {
                Wygrana();
            }
            else if (btn3.Content != "" && btn3.Content == btn5.Content && btn5.Content == btn7.Content)
            {
                Wygrana();
            }
            else if (ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButton.OK, MessageBoxImage.Warning);
                Restartuj();
            }

        }


        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            if (gracz1)
            {
                wynikO.Content = ((int.Parse((string) wynikO.Content)) + 1).ToString();
            }
            else
            {
                wynikX.Content = ((int.Parse((string) wynikX.Content)) + 1).ToString();
            }
            Restartuj();
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            kto.Content = gracz1 ? "O" : "X";
        }
    }
}
