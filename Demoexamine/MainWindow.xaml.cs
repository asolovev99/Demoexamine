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

            // <TextBlock HorizontalAlignment="Left" Margin="42,13,0,0" TextWrapping="Wrap" Text="Дата начала периода" VerticalAlignment="Top" FontFamily="/Demoexamine;component/Document fonts/#Akrobat Bold" FontSize="14"/>
            TextBlock TxtBlckDatePckrBeginOfTour = new TextBlock();
            TxtBlckDatePckrBeginOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            TxtBlckDatePckrBeginOfTour.VerticalAlignment = VerticalAlignment.Top;
            TxtBlckDatePckrBeginOfTour.Margin = new Thickness(42, 13, 0, 0);
            TxtBlckDatePckrBeginOfTour.TextWrapping = TextWrapping.Wrap;
            TxtBlckDatePckrBeginOfTour.Text = "Дата начала периода";
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily("file:///C:/Users/199930/source/repos/Demoexamine/Demoexamine/Document fonts/Akrobat-Bold_1.otf");
            //new Uri( "FRE3OF9X.TTF", UriKind.Absolute ), "Free 3 of 9 Extended"
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily(new Uri("C:\\Users\\199930\\source\\repos\\Demoexamine\\Demoexamine\\Document fonts\\Akrobat-Bold_1.otf", UriKind.Relative), "Akrobat Bold");
            TxtBlckDatePckrBeginOfTour.FontSize = 14;


            // <Border BorderBrush="Black" BorderThickness="2" HorizontalAlignment="Left" Height="auto" Margin="190,10,0,0" VerticalAlignment="Top" Width="auto">
            Border borderDatePckrEndOfTour = new Border();
            borderDatePckrEndOfTour.BorderBrush = System.Windows.Media.Brushes.Black;
            borderDatePckrEndOfTour.BorderThickness = new Thickness(2);
            borderDatePckrEndOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            borderDatePckrEndOfTour.VerticalAlignment = VerticalAlignment.Top;


            borderDatePckrEndOfTour.Margin = new Thickness(190, 50, 0, 0);

            // <DatePicker HorizontalAlignment="Left" Margin="0,0,0,0" VerticalAlignment="Top" Width="160" Height="24"/>
            DatePckrEndOfTour = new DatePicker();
            DatePckrEndOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            DatePckrEndOfTour.VerticalAlignment = VerticalAlignment.Top;
            DatePckrEndOfTour.Margin = new Thickness(0, 0, 0, 0);
            DatePckrEndOfTour.Width = 160;
            DatePckrEndOfTour.Height = 24;

            borderDatePckrEndOfTour.Child = DatePckrEndOfTour;

            // <TextBlock HorizontalAlignment="Left" Margin="42,13,0,0" TextWrapping="Wrap" Text="Дата начала периода" VerticalAlignment="Top" FontFamily="/Demoexamine;component/Document fonts/#Akrobat Bold" FontSize="14"/>
            TextBlock TxtBlckDatePckrEndOfTour = new TextBlock();
            TxtBlckDatePckrEndOfTour.HorizontalAlignment = HorizontalAlignment.Left;
            TxtBlckDatePckrEndOfTour.VerticalAlignment = VerticalAlignment.Top;
            TxtBlckDatePckrEndOfTour.Margin = new Thickness(20, 53, 0, 0);
            TxtBlckDatePckrEndOfTour.TextWrapping = TextWrapping.Wrap;
            TxtBlckDatePckrEndOfTour.Text = "Дата окончания периода";
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily("file:///C:/Users/199930/source/repos/Demoexamine/Demoexamine/Document fonts/Akrobat-Bold_1.otf");
            //new Uri( "FRE3OF9X.TTF", UriKind.Absolute ), "Free 3 of 9 Extended"
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily(new Uri("C:\\Users\\199930\\source\\repos\\Demoexamine\\Demoexamine\\Document fonts\\Akrobat-Bold_1.otf", UriKind.Relative), "Akrobat Bold");
            TxtBlckDatePckrEndOfTour.FontSize = 14;


            // <TextBlock HorizontalAlignment="Left" Margin="69,93,0,0" TextWrapping="Wrap" Text="Количество дней" VerticalAlignment="Top" FontFamily="/Demoexamine;component/Document fonts/#Akrobat Bold" FontSize="16"/>
            TextBlock TxtBlckTxtBxAmountOfDays = new TextBlock();
            TxtBlckTxtBxAmountOfDays.HorizontalAlignment = HorizontalAlignment.Left;
            TxtBlckTxtBxAmountOfDays.VerticalAlignment = VerticalAlignment.Top;
            TxtBlckTxtBxAmountOfDays.Margin = new Thickness(69, 93, 0, 0);
            TxtBlckTxtBxAmountOfDays.TextWrapping = TextWrapping.Wrap;
            TxtBlckTxtBxAmountOfDays.Text = "Количество дней";
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily("file:///C:/Users/199930/source/repos/Demoexamine/Demoexamine/Document fonts/Akrobat-Bold_1.otf");
            //new Uri( "FRE3OF9X.TTF", UriKind.Absolute ), "Free 3 of 9 Extended"
            //TxtBlckDatePckrBeginOfTour.FontFamily = new FontFamily(new Uri("C:\\Users\\199930\\source\\repos\\Demoexamine\\Demoexamine\\Document fonts\\Akrobat-Bold_1.otf", UriKind.Relative), "Akrobat Bold");
            TxtBlckTxtBxAmountOfDays.FontSize = 14;

            Border borderTxtBxAmountOfDays = new Border();
            borderTxtBxAmountOfDays.BorderBrush = System.Windows.Media.Brushes.Black;
            borderTxtBxAmountOfDays.BorderThickness = new Thickness(2);
            borderTxtBxAmountOfDays.HorizontalAlignment = HorizontalAlignment.Left;
            borderTxtBxAmountOfDays.VerticalAlignment = VerticalAlignment.Top;


            borderTxtBxAmountOfDays.Margin = new Thickness(190, 90, 0, 0);

            // <TextBox Width="40" Height="24">
            TextBox txtBoxAmountOfDays = new TextBox();
            txtBoxAmountOfDays.Width = 40;
            txtBoxAmountOfDays.Height = 24;

            borderTxtBxAmountOfDays.Child = txtBoxAmountOfDays;












            GridInputsAndDataOfStep.Children.Add(borderDatePckrBeginOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckDatePckrBeginOfTour);
            GridInputsAndDataOfStep.Children.Add(borderDatePckrEndOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckDatePckrEndOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckTxtBxAmountOfDays);
            GridInputsAndDataOfStep.Children.Add(borderTxtBxAmountOfDays);



        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DrawFirstStep();
        }


    }
}
