// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            this.Output.Text += button.Content.ToString();
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }catch(Exception ex)
            {
                this.Output.Text=ex.Message;
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (this.Output.Text.Contains("+"))
            {
                iOp = this.Output.Text.IndexOf("+");
            }
            else if (this.Output.Text.Contains("-"))
            {
                iOp = this.Output.Text.IndexOf("-");
            }
            else if (this.Output.Text.Contains("/")) {
                iOp = this.Output.Text.IndexOf("/");
            }else if (this.Output.Text.Contains("*")){
                iOp = this.Output.Text.IndexOf("*");
            }
            op= this.Output.Text.Substring(iOp,1);
            double op1 = Convert.ToDouble(Output.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(Output.Text.Substring(iOp+1,Output.Text.Length-iOp-1));
            if (op == "+")
            {
                Result.Text+=Convert.ToString(op1+ op2);
            }
            else if(op == "-")
            {
                Result.Text += Convert.ToString(op1 - op2);
            }
            else if(op == "/")
            {
                Result.Text += Convert.ToString(op1 / op2);
            }
            else if(op == "*")
            {
                Result.Text += Convert.ToString(op1 *op2);
            }
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Output.Text =" ";
            Result.Text =" ";
        }
        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
