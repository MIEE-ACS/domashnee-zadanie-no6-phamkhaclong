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

namespace HomeWork6
{
    class Listanounce
    {
        public string Shape { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Radius { get; set; }
        public string Largebottom { get; set; }
        public string Smallbottom { get; set; }
        public string Height { get; set; }
        public string Area { get; set; }
        public string Perimeter { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Rectangle obj2 = new Rectangle();
            //Rectangle obj1 = new Rectangle();
            //obj1.width = 1;
            //obj2.width = 1;
            //obj1.Equals(obj2);
            //resultarea.Text= $"{obj1.Equals(obj2)}";

        }
        List<Listanounce> items = new List<Listanounce>();


        private void Find_Click(object sender, RoutedEventArgs e)
        {
            int choice = figureCB.SelectedIndex;
            switch (choice)
            {
                case 0:
                    {
                        Rectangle rectangle = new Rectangle();
                        rectangle.length = int.Parse(iptb1.Text);
                        rectangle.width = int.Parse(iptb2.Text);
                        items.Add(new Listanounce { Shape = "Rectangle", Length =$"{rectangle.length}",Width=$"{rectangle.width}",Area=$"{rectangle.Area()}",Perimeter=$"{rectangle.Perimeter()}"});
                        Listresult.ItemsSource = items;
                        Listresult.Items.Refresh();
                        break;
                    }
                case 1:
                    {
                        Circle circle = new Circle();
                        circle.radius = int.Parse(iptb1.Text);
                        items.Add(new Listanounce { Shape = "Circle", Radius=$"{circle.radius}", Area = $"{circle.Area()}", Perimeter = $"{circle.Perimeter()}" });
                        Listresult.ItemsSource = items;
                        Listresult.Items.Refresh();
                        break;
                    }
                case 2:
                    {
                        Trapezoid trapezoid = new Trapezoid();
                        trapezoid.largebottom = int.Parse(iptb1.Text);
                        trapezoid.smallbottom = int.Parse(iptb2.Text);
                        trapezoid.height = int.Parse(iptb3.Text);
                        items.Add(new Listanounce { Shape = "Trapezoid", Largebottom = $"{trapezoid.largebottom}", Smallbottom = $"{trapezoid.smallbottom}",Height=$"{trapezoid.height}", Area = $"{trapezoid.Area()}", Perimeter = $"{trapezoid.Perimeter()}" });
                        Listresult.ItemsSource = items;
                        Listresult.Items.Refresh();
                        break;
                    }
            }
        }

        private void figureCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = figureCB.SelectedIndex;
            switch (choice)
            {
                case 0:
                    {
                        inputlb1.Content = "length";
                        inputlb2.Content = "width";
                        inputlb3.Content = "";
                        iptb2.Visibility = Visibility.Visible;
                        iptb3.Visibility = Visibility.Hidden;
                        break;
                    }
                case 1:
                    {
                        inputlb1.Content = "Radius";
                        inputlb2.Content = ""; 
                        inputlb3.Content = "";
                        iptb2.Visibility = Visibility.Hidden;
                        iptb3.Visibility = Visibility.Hidden;
                        break;
                    }
                case 2:
                    {
                        inputlb1.Content = "Largebottom";
                        inputlb2.Content = "Smallbottom";
                        inputlb3.Content = "Height";
                        iptb2.Visibility = Visibility.Visible;
                        iptb3.Visibility = Visibility.Visible;
                        break;
                    }
            }
        }
    }
}
