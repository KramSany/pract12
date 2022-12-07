using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Threading;

namespace pract12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CircleWithTwoRadius circle1;
        CircleWithTwoRadius circle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            circle = new(int.Parse(FirstRadiusTB.Text));
            circle1 = new(Int32.Parse(SecondRadiusTB.Text));
            resultTBCircle.Text = (circle1.AreaAllRinga(circle).ToString());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создатель: Поливода А.А\nЗадание:Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). " +
                "Найти площади \r\nэтих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен \r\nR1, " +
                "внутренний радиус равен R2: S1 = PI*(R1)2\r\n, S2 = PI*(R2)2\r\n, S3 = S1 – S2. В\r\nкачестве значения PI использовать" +
                " 3.14.\r\n Дан номер некоторого года (целое положительное число). Определить " +
                "\r\nсоответствующий ему номер столетия, учитывая, что, к примеру, началом 20 \r\nстолетия был 1901 год.");
        }

        private void ResultCenuty_Click(object sender, RoutedEventArgs e)
        {
            FindCentury find1 = new(Int32.Parse(YearTB.Text));
            resultTBFindCentury.Text = (find1.Find().ToString());
        }

        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            tbWatch.Text = dateTime.ToString("hh:mm:ss");
            tbDate.Text = dateTime.ToString("dd.MM.yyyy");
            tbTask.Text = "Практическая 12. Вариант 8";
        }
    }
}
