using System.Windows;
using System.Windows.Controls;
using ClassLibrary2;

namespace SimpleCsApp.MVVM.View
{
    public partial class Distances : UserControl
    {
        public Distances()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.KgToLbs(Field.Text) + " lbs";

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.LbsToKg(Field.Text) + " kg";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.KmToMiles(Field.Text) + " miles";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.MilesToKm(Field.Text) + " km";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.FtoC(Field.Text) + " Celsius degrees";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.CtoF(Field.Text) + " Fahrenheit degrees";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.MeterToFeet(Field.Text) + " meters";        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.FeetToMeter(Field.Text) + " feet";        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.MphToKph(Field.Text) + " mph";        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Field.Text = "that is " + Class1.KphToMph(Field.Text) + " kph";        }
    }
}