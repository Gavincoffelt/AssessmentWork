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

namespace AssessmentWork
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


        private void FontChanged(object sender, SelectionChangedEventArgs e)
        {

            contact.FontFamily = (FontFamily)fonts.SelectedValue;
            name.FontFamily = (FontFamily)fonts.SelectedValue;


        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
           if(colors.Text == "Blue")
            {
                businessCard.Fill = Brushes.Blue;
            }
           if(colors.Text == "Red")
            {
                businessCard.Fill = Brushes.Red;
            }
            
            if(colors.Text == "Gray")
            {
                businessCard.Fill = Brushes.Gray;
            }
            if (colors.Text == "Yellow")
            {
                businessCard.Fill = Brushes.Yellow;
            }
            if(colors.Text == "Green")
            {
                businessCard.Fill = Brushes.Green;
            }
        }

        private void FontSizer(object sender, TextChangedEventArgs e)
        {   int fontsze = Convert.ToInt32(fontSize.Text);

          
            name.FontSize = fontsze;
            contact.FontSize = fontsze;
            
           
        }
    }
}