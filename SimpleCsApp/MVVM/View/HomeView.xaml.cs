using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary2;

namespace SimpleCsApp.MVVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void ButtonClock_Click(object sender, RoutedEventArgs e)
        {
            Field12.Text = Class1.CheckAm(System.Convert.ToInt32(Field0.Text)).ToString();
            Field6.Text = Class1.CheckTime(System.Convert.ToInt32(Field0.Text)).ToString();
            int hours = System.Convert.ToInt32(Field6.Text);
            Field8.Text = Field2.Text;
            Field10.Text = Field4.Text;
            hourButton.Angle = hourButton.Angle + ((360 / 12) * hours);
            minuteButton.Angle = minuteButton.Angle + ((360 / 60) * System.Convert.ToInt32(Field2.Text));
            secondButton.Angle = secondButton.Angle + ((360 / 60) * System.Convert.ToInt32(Field4.Text));
        }
    }
}