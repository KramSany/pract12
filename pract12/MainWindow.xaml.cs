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

namespace pract12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {

            //CircleWithTwoRadius circle1 = new (5,8,7);
            //CircleWithTwoRadius circle = new(5, 7, 4);
            FindCentury find = new(1567);
            MessageBox.Show(find.Find().ToString());
            InitializeComponent();
            //circle.AreaAllRinga(circle1);

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResultCenuty_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("maybe u don't want?","Вопрос", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                for (int i = 0; i < 10; i++)
                {
                    MessageBox.Show("u are gey"); 
                }
            }
            
        }
    }
}
