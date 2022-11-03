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
        private TextBox txtBoxAmountOfDays;
        private TextBox txtBoxAmountOfPeople;
        private CheckBox chckBxChildren;

        private DateTime DateTimeBeginOfTour;
        private DateTime DateTimeEndOfTour;
        private int AmountOfDays;
        private int AmountOfPeople;
        private bool AreThereAnyChildrens;

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
            txtBoxAmountOfDays = new TextBox();
            txtBoxAmountOfDays.Width = 40;
            txtBoxAmountOfDays.Height = 24;

            borderTxtBxAmountOfDays.Child = txtBoxAmountOfDays;



            // <TextBlock HorizontalAlignment="Left" Margin="48,133,0,0" TextWrapping="Wrap" Text="Количество человек" VerticalAlignment="Top" FontFamily="/Demoexamine;component/Document fonts/#Akrobat Bold" FontSize="16"/>
            TextBlock TxtBlckTxtBxAmountOfPeople = new TextBlock();
            TxtBlckTxtBxAmountOfPeople.HorizontalAlignment = HorizontalAlignment.Left;
            TxtBlckTxtBxAmountOfPeople.VerticalAlignment = VerticalAlignment.Top;
            TxtBlckTxtBxAmountOfPeople.Margin = new Thickness(48, 133, 0, 0);
            TxtBlckTxtBxAmountOfPeople.TextWrapping = TextWrapping.Wrap;
            TxtBlckTxtBxAmountOfPeople.Text = "Количество человек";
            TxtBlckTxtBxAmountOfPeople.FontSize = 14;

            // <Border BorderBrush="Black" BorderThickness="2" HorizontalAlignment="Left" Height="auto" Margin="190,130,0,0" VerticalAlignment="Top" Width="auto">
            // <TextBox Width="40" Height="24"></TextBox>
            Border borderTxtBxAmountOfPeople = new Border();
            borderTxtBxAmountOfPeople.BorderBrush = System.Windows.Media.Brushes.Black;
            borderTxtBxAmountOfPeople.BorderThickness = new Thickness(2);
            borderTxtBxAmountOfPeople.HorizontalAlignment = HorizontalAlignment.Left;
            borderTxtBxAmountOfPeople.VerticalAlignment = VerticalAlignment.Top;


            borderTxtBxAmountOfPeople.Margin = new Thickness(190, 130, 0, 0);

            // <TextBox Width="40" Height="24">
            txtBoxAmountOfPeople = new TextBox();
            txtBoxAmountOfPeople.Width = 40;
            txtBoxAmountOfPeople.Height = 24;

            borderTxtBxAmountOfPeople.Child = txtBoxAmountOfPeople;

            // <CheckBox Content="Дети" HorizontalAlignment="Left" Margin="265,137,0,0" VerticalAlignment="Top" FontFamily="/Demoexamine;component/Document fonts/#Akrobat Bold" FontSize="16"/>

            chckBxChildren = new CheckBox();
            chckBxChildren.Content = "Дети";
            chckBxChildren.HorizontalAlignment = HorizontalAlignment.Left;
            chckBxChildren.VerticalAlignment = VerticalAlignment.Top;
            chckBxChildren.Margin = new Thickness(265, 137, 0, 0);
            chckBxChildren.FontSize = 14;


            GridInputsAndDataOfStep.Children.Add(borderDatePckrBeginOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckDatePckrBeginOfTour);
            GridInputsAndDataOfStep.Children.Add(borderDatePckrEndOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckDatePckrEndOfTour);
            GridInputsAndDataOfStep.Children.Add(TxtBlckTxtBxAmountOfDays);
            GridInputsAndDataOfStep.Children.Add(borderTxtBxAmountOfDays);
            GridInputsAndDataOfStep.Children.Add(TxtBlckTxtBxAmountOfPeople);
            GridInputsAndDataOfStep.Children.Add(borderTxtBxAmountOfPeople);
            GridInputsAndDataOfStep.Children.Add(chckBxChildren);
        }

        private void DrawSecondStep()
        {
            BtnNextStep.IsEnabled = true;
            BtnSkipStep.IsEnabled = true;

            GridInputsAndDataOfStep.Children.Clear();

            EllpsFirstStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsSecondStep.Fill = System.Windows.Media.Brushes.Green;
            EllpsThirdStep.Fill = System.Windows.Media.Brushes.White;
            EllpsFourthStep.Fill = System.Windows.Media.Brushes.White;

            TxtBlckNameOfStep.Text = "Предпочтения";

            

        }

        private void DrawThirdStep()
        {
            BtnNextStep.IsEnabled = true;
            BtnSkipStep.IsEnabled = true;

            GridInputsAndDataOfStep.Children.Clear();

            EllpsFirstStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsSecondStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsThirdStep.Fill = System.Windows.Media.Brushes.Green;
            EllpsFourthStep.Fill = System.Windows.Media.Brushes.White;

            TxtBlckNameOfStep.Text = "Условия отеля";


        }

        private void DrawFourthStep()
        {
            BtnNextStep.IsEnabled = false;
            BtnSkipStep.IsEnabled = false;

            GridInputsAndDataOfStep.Children.Clear();

            EllpsFirstStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsSecondStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsThirdStep.Fill = System.Windows.Media.Brushes.Gray;
            EllpsFourthStep.Fill = System.Windows.Media.Brushes.Green;

            TxtBlckNameOfStep.Text = "Результаты поиска";


        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DateTimeBeginOfTour = DateTime.MinValue;
            DateTimeEndOfTour = DateTime.MinValue;
            AmountOfDays = -1;
            AmountOfPeople = -1;
            AreThereAnyChildrens = false;

            DrawFirstStep();
        }

        private void BtnNextStepSecond_Click(object sender, RoutedEventArgs e)
        {
            if (DatePckrBeginOfTour.SelectedDate != null && DatePckrEndOfTour.SelectedDate != null && DatePckrBeginOfTour.SelectedDate >= DatePckrEndOfTour.SelectedDate)
            {
                return;
            }

            if (DatePckrBeginOfTour.SelectedDate != null)
            {
                DateTimeBeginOfTour = (DateTime)DatePckrBeginOfTour.SelectedDate;
            }

            if (DatePckrEndOfTour.SelectedDate != null)
            {
                DateTimeEndOfTour = (DateTime)DatePckrEndOfTour.SelectedDate;
            }
            
            if (txtBoxAmountOfDays.Text != "" && !Int32.TryParse(txtBoxAmountOfDays.Text, out AmountOfDays))
            {
                return;
            }

            if (txtBoxAmountOfPeople.Text == "" || !Int32.TryParse(txtBoxAmountOfPeople.Text, out AmountOfPeople))
            {
                return;
            }

            AreThereAnyChildrens = (bool)chckBxChildren.IsChecked;

            BtnNextStep.Click -= BtnNextStepSecond_Click;
            BtnNextStep.Click += BtnNextStepThird_Click;
            DrawSecondStep();
        }

        private void BtnSkipStepFirst_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxAmountOfPeople.Text == "" || !Int32.TryParse(txtBoxAmountOfPeople.Text, out AmountOfPeople))
            {
                return;
            }

            BtnNextStep.Click -= BtnNextStepSecond_Click;
            BtnNextStep.Click += BtnNextStepThird_Click;
            DrawSecondStep();
        }

        private void BtnNextStepThird_Click(object sender, RoutedEventArgs e) 
        {
            BtnNextStep.Click -= BtnNextStepThird_Click;
            BtnNextStep.Click += BtnNextStepFourth_Click;

            DrawThirdStep();
        }
        private void BtnSkipStepSecond_Click(object sender, RoutedEventArgs e) 
        {
            BtnNextStep.Click -= BtnNextStepThird_Click;
            BtnNextStep.Click += BtnNextStepFourth_Click;

            DrawThirdStep();
        }

        private void BtnNextStepFourth_Click(object sender, RoutedEventArgs e) 
        {
            DrawFourthStep();
        }
        private void BtnSkipStepThird_Click(object sender, RoutedEventArgs e) 
        {
            DrawFourthStep();
        }

        private void BtnFind_Click(object sender, RoutedEventArgs e)
        {
            DateTimeBeginOfTour = DateTime.MinValue;
            DateTimeEndOfTour = DateTime.MinValue;
            AmountOfDays = -1;
            AmountOfPeople = -1;
            AreThereAnyChildrens = false;

            BtnNextStep.Click -= BtnNextStepSecond_Click;
            BtnNextStep.Click -= BtnNextStepThird_Click;
            BtnNextStep.Click -= BtnNextStepFourth_Click;
            BtnNextStep.Click += BtnNextStepSecond_Click;

            DrawFirstStep();
        }
    }
}
