using System;
using System.Windows;
using System.Windows.Threading;

namespace ClockDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clock clock;
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            clock = new Clock();
            timeDisplay.Content = clock.DisplayString;

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(delegate(object s, EventArgs a)
            {
                clock.TimeTick();
                timeDisplay.Content = clock.DisplayString;
            });
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromMilliseconds(0);
            timer.Start();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            clock.Reset();
            timeDisplay.Content = clock.DisplayString;
        }
    }
}
