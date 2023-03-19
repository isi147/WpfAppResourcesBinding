using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //public string SomeText { get; set; } = "Hakunaa";


        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private string _someText;

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                NotifyPropertyChanged();
            }
        }





        //DependicyProperty  Way1
        //public string SomeText
        //{
        //    get { return (string)GetValue(SomeTextProperty); }
        //    set { SetValue(SomeTextProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SomeText.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SomeTextProperty =
        //    DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));





        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SomeText+='a';
            //MessageBox.Show(SomeText);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    grid.Resources["btnColor1"] = Brushes.DarkGreen;
        //}
    }
}
