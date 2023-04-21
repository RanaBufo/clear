using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Lab2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        double n1 = 0, n2 = 0, n3 = 0, k = 0, p = 0, m = 0, n = 1, np = 0, z = 0;
        string st = "1", st2 = "rt";
        int  i = 0;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (this.Width != 505)
            {
                this.Width -= 550;
                CL.Visibility = Visibility.Hidden;
                Clear.Visibility = Visibility.Hidden;
                ch1.Visibility = Visibility.Hidden;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.Width += 550;
            CL.Visibility = Visibility.Visible;
            Clear.Visibility = Visibility.Visible;
            ch1.Visibility = Visibility.Visible;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            t2.Text = "";
        }

        private void CL_Click(object sender, RoutedEventArgs e)
        {
            if(t2.Text != "" & t2.Text.Contains("\n"))
            {
                i = t2.Text.IndexOf("\n");
                t2.Text = t2.Text.Substring(i + 1);
            }
            else if(t2.Text != "")
            {
                t2.Text = "";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Contains("E+") || z == 1 || (t1.Text == "На ноль делить нельзя"))
            {
                t1.Text = "0";
                n = 1;
                np = 0;
                p = 0;
                m = 0;
                z = 0;
                k = 0;
            }
            else if(t1.Text != "0")
            {
                if (m == 1)
                {
                    t1.Text = t1.Text.Substring(1);
                }
                if( k == 0)
                {
                    t1.Text = "0";
                    n = 1;
                    np = 0;
                    p = 0;
                    m = 0;
                    k = 0;
                }
                else if(n==0)
                {
                    t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                    if(p == 1)
                    {
                        i = t1.Text.IndexOf(',');
                        np = t1.Text.Substring(i + 1).Length;
                        n = i - 1;

                    }
                    else
                    {
                        n = t1.Text.Length;
                    }
                    k = 0;
                }
                else
                {
                    if (t1.Text.Contains("+"))
                    {
                        i = t1.Text.IndexOf("+");
                        t1.Text = t1.Text.Substring(0, i + 1);
                        n = 0;
                        np = 0;
                        p = 0;
                    }
                    else if (t1.Text.Contains("-"))
                    {
                        i = t1.Text.IndexOf("-");
                        t1.Text = t1.Text.Substring(0, i + 1);
                        n = 0;
                        np = 0;
                        p = 0;
                    }
                    else if (t1.Text.Contains("x"))
                    {
                        i = t1.Text.IndexOf("x");
                        t1.Text = t1.Text.Substring(0, i + 1);
                        n = 0;
                        np = 0;
                        p = 0;
                    }
                    else if (t1.Text.Contains("/"))
                    {
                        i = t1.Text.IndexOf("/");
                        t1.Text = t1.Text.Substring(0, i + 1);
                        n = 0;
                        np = 0;
                        p = 0;
                
                    }
                    
                }
                if (m == 1 & t1.Text != "0")
                {
                    t1.Text = "-" + t1.Text;
                }
            }
            
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            t1.Text = "0";
            n = 1;
            p = 0;
            np = 0;
            m = 0;
            k = 0;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Contains("E+") || z == 1 || t1.Text == "" || t1.Text.Length == 1 || (t1.Text == "На ноль делить нельзя") || t1.Text == "0")
            {
                t1.Text = "0";
                n = 1;
                np = 0;
                p = 0;
                m = 0;
                z = 0;
                k = 0;
            }
            else {
                
                if (m == 1)
                {
                    t1.Text = t1.Text.Substring(1);
                }
                if (t1.Text == "" & m == 1)
                {
                    t1.Text = "0";
                    n = 0;
                    p = 0;
                    m = 0;
                    np = 0;
                    k = 0;
                }
                else if (n != 0)
                {
                    if (np == 0 & p == 1)
                    {
                        p = 0;
                        t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                    }
                    else if (np != 0 & p == 1)
                    {
                        np -= 1;
                        t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                    }
                    else
                    {
                        t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                        n--;
                    }
                }
                else if (k != 0)
                {
                    t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                    k = 0;
                    if (p == 1)
                    {
                        i = t1.Text.IndexOf(",");
                        np = t1.Text.Substring(i + 1).Length;
                        n = i - 1;
                    }
                    else
                    {
                        n = t1.Text.Length;
                    }


                }
                if (m == 1)
                {
                    t1.Text = "-" + t1.Text;
                }
                
            }
        }


        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            if((z == 1) || (t1.Text == "На ноль делить нельзя") || t1.Text.Contains('E'))
            {
                t1.Text = "0";
                z = 0;
                n = 1;
                p = 0;
                np = 0;
                m = 0;
            }
            else 
            {
                st2 = t1.Text;
                Button b = (Button)sender;
                if (k == 0)
                {
                    if (b.Content.ToString() == "-" & t1.Text == "0")
                    {
                        m++;
                        t1.Text = b.Content.ToString();
                        n = 0;
                    }
                    else if (b.Content.ToString() == "=")
                    {
                        t1.Text = t1.Text;
                    }
                    else
                    {
                        t1.Text += b.Content.ToString();
                        n = 0;
                        np = 0;
                        k++;
                        p = 0;

                    }
                }
                else if(k != 0 & n != 0)  
                {
                    if (m == 1)
                    {
                        t1.Text = t1.Text.Substring(1);
                    }
                    

                        if (t1.Text.Contains('+'))
                        {
                            i = t1.Text.IndexOf("+");
                            n1 = double.Parse(t1.Text.Substring(0, i));
                            if (m == 1)
                            {
                                n1 *= (-1);
                            }
                            n2 = double.Parse(t1.Text.Substring(i + 1));
                            n3 = n1 + n2;
                            if (n3 < 0)
                            {
                                m = 1;
                            }
                            t1.Text = n3.ToString();
                        }
                        else if (t1.Text.Contains('-'))
                        {
                            i = t1.Text.IndexOf("-");
                            n1 = double.Parse(t1.Text.Substring(0, i));
                            if (m == 1)
                            {
                                n1 *= (-1);
                            }
                            n2 = double.Parse(t1.Text.Substring(i + 1));
                            n3 = n1 - n2;
                            if (n3 < 0)
                            {
                                m = 1;
                            }
                            t1.Text = n3.ToString();
                        }
                        else if ((t1.Text.Contains('x')))
                        {
                            i = t1.Text.IndexOf("x");
                            n1 = double.Parse(t1.Text.Substring(0, i));
                            if (m == 1)
                            {
                                n1 *= (-1);
                            }
                            n2 = double.Parse(t1.Text.Substring(i + 1));
                            n3 = n1 * n2;
                            if (n3 < 0)
                            {
                                m = 1;
                            }
                            t1.Text = n3.ToString();

                        }
                        else if (t1.Text.Contains('/'))
                        {
                            i = t1.Text.IndexOf("/");
                            n1 = double.Parse(t1.Text.Substring(0, i));
                            if (m == 1)
                            {
                                n1 *= (-1);
                            }
                            n2 = double.Parse(t1.Text.Substring(i + 1));
                            if (n2 == 0)
                            {
                                t1.Text = "На ноль делить нельзя";
                                z = 1;
                            }
                            else
                            {
                                n3 = n1 / n2;
                                if (n3 < 0)
                                {
                                    m = 1;
                                }
                                t1.Text = n3.ToString();
                            }
                        }
                        if (b.Content.ToString() == "=")
                        {
                            k = 0; 
                        if (t1.Text.Contains("E+"))
                        {
                            n = 1;
                            np = 0;
                            p = 0;
                            m = 0;
                            z = 1;
                        }
                        else
                        {
                            if (m == 1)
                            {
                                t1.Text = t1.Text.Substring(1);
                            }
                            if (t1.Text.Contains(','))
                            {
                                i = t1.Text.IndexOf(',');
                                if (t1.Text.Substring(i + 1).Length > 6)
                                {
                                    t1.Text = t1.Text.Substring(0, i + 7);
                                    np = 6;
                                }
                                else
                                {
                                    np = t1.Text.Length - i;
                                }
                                if (i > 10)
                                {
                                    z = 1;

                                    
                                }
                                else
                                {
                                    n = i;
                                }
                            }
                            else
                            {
                                if (t1.Text.Length > 10)
                                {
                                    z = 1;
                                    n = 1;
                                    np = 0;
                                    p = 0;
                                    m = 0;
                                }
                            }
                            if (m == 1)
                            {
                                t1.Text = "-" + t1.Text;
                            }
                        }
                        }
                        else if (!(t1.Text.Contains("E+")))
                        {
                            if (t1.Text.Contains("E+"))
                            {
                                n = 1;
                                np = 0;
                                p = 0;
                                m = 0;
                            }
                            else
                            {
                                if (m == 1)
                                {
                                    t1.Text = t1.Text.Substring(1);
                                }
                                if (t1.Text.Contains(','))
                                {
                                    i = t1.Text.IndexOf(',');
                                    if (t1.Text.Substring(i + 1).Length > 6)
                                    {
                                        t1.Text = t1.Text.Substring(0, i + 7);
                                        np = 6;
                                    }
                                    else
                                    {
                                        np = t1.Text.Length - i;
                                    }
                                    if (i > 10)
                                    {
                                        z = 1;
                                    }
                                    else
                                    {
                                        n = i;
                                    }

                            }
                                else
                                {
                                    if (t1.Text.Length > 10)
                                    {
                                        z = 1;
                                        n = 1;
                                        np = 0;
                                        p = 0;
                                        m = 0;
                                    }
                                }
                                if (m == 1)
                                {
                                    t1.Text = "-" + t1.Text;
                                }
                                if (z == 0)
                                {
                                    t1.Text += b.Content.ToString();
                                    np = 0;
                                    p = 0;
                                    n = 0;
                                }
                            }
                    }
                    if (ch1.IsChecked == true)
                    {
                        if (t1.Text.Contains("-") | t1.Text.Contains("+") | t1.Text.Contains("x") | t1.Text.Contains("/"))
                        {
                            st2 += "=" + t1.Text.Substring(0, t1.Text.Length - 1);
                        }
                        else { st2 += "=" + t1.Text.Substring(0, t1.Text.Length); }
                        if (t2.Text != "")
                        {
                            t2.Text = st2 +"\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = st2;
                        }
                    }
                    
                }
                
            }
        }






        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Contains("E+") || z == 1 || (t1.Text == "На ноль делить нельзя"))
            {
                t1.Text = "0";
                n = 1;
                np = 0;
                p = 0;
                m = 0;
                z = 0;
                k = 0;
            }
            else            {
                Button b = (Button)sender;
                if (n < 10 & np == 0 & p == 0)
                {
                    if (t1.Text == "0")
                    {
                        t1.Text = b.Content.ToString();
                    }
                    else if (n == 0)
                    {
                        t1.Text += b.Content.ToString(); n++;
                    }
                    else if((n == 1 & t1.Text.Substring( t1.Text.Length - 1) != "0") || n>1 ) { t1.Text += b.Content.ToString(); n++; }
                }
                else if ((np > 0 & np != 6)  )
                {
                    t1.Text += b.Content.ToString();
                    np++;
                }
            }
        }

    }
}
