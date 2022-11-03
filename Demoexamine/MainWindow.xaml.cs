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

namespace Demoexamine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatePicker DatePckrBeginOfTour;
        private DatePicker DatePckrEndOfTour;
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawFirstStep()
        {
            BtnNextStep.IsEnabled = true;
            BtnSkipStep.IsEnabled = true;

            GridInputsAndDataOfStep.Children.Clear();

            EllpsFirstStep.Fill = System.Windows.Media.Brushes.Green;
            EllpsSecondStep.Fill = System.Windows.Media.Brushes.White;
            EllpsThirdStep.Fill = System.Windows.Media.Brushes.White;
            EllpsFourthStep.Fill = System.Windows.Media.Brushes.White;

            TxtBlckNameOfStep.Text = "Основная информация";

            // <Border BorderBrush="Black" BorderThickness="2" HorizontalAlignment="Left" Height="auto" Margin="190,10,0,0" VerticalAlignment="Top" Width="auto">
            Border borderDatePckrBeginOfTour = new Border();
            borderDatePckrBeginOfTour.BorderBrush = System.Windows.Media.Brushes.Black;
            borderDatePckrBeginOfTour.BorderThickness = new Thickness(2);
            borderDatePckrBeginOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            borderDatePckrBeginOfTour.VerticalAlignment = VerticalAlignment.Top;


            borderDatePckrBeginOfTour.Margin = new Thickness(190, 10, 0, 0);

            // <DatePicker HorizontalAlignment="Left" Margin="0,0,0,0" VerticalAlignment="Top" Width="160" Height="24"/>
            DatePckrBeginOfTour = new DatePicker();
            DatePckrBeginOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            DatePckrBeginOfTour.VerticalAlignment = VerticalAlignment.Top;
            DatePckrBeginOfTour.Margin = new Thickness(0, 0, 0, 0);
            DatePckrBeginOfTour.Width = 160;
            DatePckrBeginOfTour.Height = 24;

            borderDatePckrBeginOfTour.Child = DatePckrBeginOfTour;








            GridInputsAndDataOfStep.Children.Add(borderDatePckrBeginOfTour);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DrawFirstStep();
        }


    }
}
