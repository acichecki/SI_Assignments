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
using System.Windows.Threading;

namespace TimerEvents
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += new EventHandler(dispatcherTimer_Tick);
            _timer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            myProgressBar.Value += 5;
            if (myProgressBar.Value >= 100)
            {
                _timer.Stop();
            }
        }
    }
}
