using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double op;
        private double text;
        private double text1;

        public MainWindow()
        {
            InitializeComponent();
        }

        
         

            private void Button_Click_0(object sender, RoutedEventArgs e)
            {

                tbStatus.Text += "0";

            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "1";
            }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "2";
            }
            private void Button_Click_3(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "3";
            }

            private void Button_Click_4(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "4";
            }

            private void Button_Click_5(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "5";
            }
            private void Button_Click_6(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "6";
            }

            private void Button_Click_7(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "7";
            }

            private void Button_Click_8(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "8";
            }
            private void Button_Click_9(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += "9";
            }
            private void Button_Click_Plus(object sender, RoutedEventArgs e)
            {
                   if (double.TryParse(tbStatus.Text, out double parsedNumber))
                   {
                       text = parsedNumber;
                       op = 1;
                       tbStatus.Text += "+";
                       tbStatus.Text = " ";
                   }
                   else
                   {
                       tbStatus.Text = "Invalid input";
                   }
        }
        
        private void Button_Click_Minus(object sender, RoutedEventArgs e)
            {
                 if (double.TryParse(tbStatus.Text, out double parsedNumber))
                 {
                     text = parsedNumber;
                     op = 2;
                     tbStatus.Text += "-";
                     tbStatus.Text = " ";
                 }
                 else
                 {
                    tbStatus.Text = "Invalid input";
                 }
            }

            private void Button_Click_Multi(object sender, RoutedEventArgs e)
            {
                 if (double.TryParse(tbStatus.Text, out double parsedNumber))
                 {
                    text = parsedNumber;
                    op = 3;
                    tbStatus.Text += "*";
                    tbStatus.Text = " ";
                 }
                 else
                 {
                    tbStatus.Text = "Invalid input";
                 }
            }
            private void Button_Click_Divide(object sender, RoutedEventArgs e)
            {
                if (double.TryParse(tbStatus.Text, out double parsedNumber))
                {
                    text = parsedNumber;
                    op = 4;
                    tbStatus.Text += "/";
                    tbStatus.Text = " ";

                }
                else
                {
                   tbStatus.Text = "Invalid input";
                }

            }

            private void Button_Click_Equal(object sender, RoutedEventArgs e)
            {
            if (op == 1)
            {
                if (double.TryParse(tbStatus.Text, out double parsedNumber1))
                {
                    text1 = parsedNumber1;

                    double result = text + text1;
                    string resultString = result.ToString();
                    tbStatus.Text = " ";
                    tbStatus.Text = resultString;

                }
               
            }
            if (op == 2)
            {
                if (double.TryParse(tbStatus.Text, out double parsedNumber1))
                {
                    text1 = parsedNumber1;
                   
                    
                        double result = text - text1;
                        string resultString = result.ToString();
                        tbStatus.Text = " ";
                        tbStatus.Text = resultString;
                   
                }
                
            }
            if (op == 3)
            {
                if (double.TryParse(tbStatus.Text, out double parsedNumber1))
                {
                    text1 = parsedNumber1;


                    double result = text * text1;
                    string resultString = result.ToString();
                    tbStatus.Text = " ";
                    tbStatus.Text = resultString;


                }
          
            }
             if (op == 4)
             {

                if (double.TryParse(tbStatus.Text, out double parsedNumber1))
                {
                    text1 = parsedNumber1;
                    if (text1 == 0)
                    {
                        tbStatus.Text = "zero divide";
                    }
                    else
                    {
                        double result = text / text1;
                        string resultString = result.ToString();
                        tbStatus.Text = " ";
                        tbStatus.Text = resultString;
                    }
                }
                else
                {
                   
                    tbStatus.Text = "Invalid input";
                }
             }
            }

            private void Button_Click_Dot(object sender, RoutedEventArgs e)
            {
                tbStatus.Text += ".";
            }


            private void Button_Click_AC(object sender, RoutedEventArgs e)
            {
                tbStatus.Text = "";
            }
        }
    }
