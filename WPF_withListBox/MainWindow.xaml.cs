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

namespace WPF_withListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SensorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxSensors.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)ListBoxSensors.SelectedItem;
                string selectedContent = selectedItem.Name;
                MessageWindow.Text = "Selected Item: " + selectedContent;

                // Enable clicking the button when a specific item is selected
                if (selectedContent == "Temp")
                {
                    Button.IsEnabled = true;
                    RadioButtonOption.IsChecked = false;
                    RadioButtonOption.IsEnabled = false;
                    
                }
                else
                {
                    Button.IsEnabled = false;

                }

                // Enable clicking the radio button when a specific item is selected
                if (selectedContent == "Humidity")
                {
                    RadioButtonOption.IsEnabled = true;
                    Button.IsEnabled = false;
                }
                else
                {
                    RadioButtonOption.IsEnabled = false;

                }
            }
        }

        private void Button_Click_Handler(object sender, RoutedEventArgs e)
        {
            MessageWindow.Text = "Button is Clicked!!";
        }

        private void RadioButton_Checked_Handler(object sender, RoutedEventArgs e)
        {
            MessageWindow.Text = "Radio Button is Checked!!";
        }
    }
}
