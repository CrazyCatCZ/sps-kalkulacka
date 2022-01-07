using System;
using System.Diagnostics;
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
using System.Data;


namespace Kalkulačka
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

        private void Evaluate()
        {
            DataTable dt = new DataTable();
            string outputString = Convert.ToString(output.Text);
            object result = dt.Compute(outputString, "");

            Debug.WriteLine(result);


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string lastClickedButton;
            Button clickedButton = (Button)sender;
            string content = (string)clickedButton.Content;

            if (content == "DEL") {
                Debug.WriteLine(output.Text);
                output.Text = output.Text.Remove(0,1);
            }
            else if (content == "=") {
                Evaluate();
            }
            else
            {
                // Zobrazení co uživatel zadal
                output.Text += content;
            }
            
        }
    }
}
