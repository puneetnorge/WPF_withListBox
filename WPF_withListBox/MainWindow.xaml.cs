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

            // Create a List of items
            List<string> manufacturing_city = new List<string>
            {
                "Tromsø",
                "Bergen",
                "Oslo",
                "Kristiansand",
                "Gjøvik"
            };

            // Set the ComboBox's item source to the List
            ComboBoxTH.ItemsSource = manufacturing_city;

            RadioButtonOption.IsEnabled = false;
            Button.IsEnabled = false;
            CheckOption.IsEnabled = false;
            ComboBoxTH.IsEnabled = false;

        }


        private void SwitchCase_Handler(string str)
        {
            switch(str)
            {
                case "Temp":
                    // if selectedContent or Selected name of the sensor is Temp
                    Button.IsEnabled = true;
                    RadioButtonOption.IsEnabled = false;
                    RadioButtonOption.IsChecked = false;
                    CheckOption.IsEnabled = false;
                    CheckOption.IsChecked = false;
                    ComboBoxTH.IsEnabled = false;
                    break;
                case "Humidity":
                    // if humidity is selected then enable the Radio button to be checked or unchecked                    RadioButtonOption.IsEnabled = true;
                    Button.IsEnabled = false;
                    RadioButtonOption.IsEnabled = true;
                    CheckOption.IsEnabled = false;
                    CheckOption.IsChecked = false;
                    ComboBoxTH.IsEnabled = false;
                    break;
                
                case "CO2":
                    // If CO2 then enable CheckOption to be Checked or Unchecked
                    RadioButtonOption.IsEnabled = false;
                    RadioButtonOption.IsChecked = false;
                    Button.IsEnabled = false;
                    CheckOption.IsEnabled = true;
                    ComboBoxTH.IsEnabled = false;
                    break;
                case "Temp_Humidity":
                    // If temp and humidity enable ComboBox and selection of City
                    RadioButtonOption.IsEnabled = false;
                    RadioButtonOption.IsChecked = false;// IsChecked is set of false to remove the check
                    Button.IsEnabled = false;
                    CheckOption.IsEnabled = false;
                    CheckOption.IsChecked = false;// CheckOption is set of false to remove the check
                    ComboBoxTH.IsEnabled = true;
                    break;


                default:
                    MessageWindow.Text = "Nothing Selected";
                    RadioButtonOption.IsEnabled = false;
                    RadioButtonOption.IsChecked = false;// IsChecked is set of false to remove the check
                    Button.IsEnabled = false;
                    CheckOption.IsEnabled = false;// CheckOption is set of false to remove the check
                    ComboBoxTH.IsEnabled = false;
                    break;




            }
        }
        private void SensorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxSensors.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)ListBoxSensors.SelectedItem;
                string selectedContent = selectedItem.Name;
                MessageWindow.Text = "Selected Item: " + selectedContent;
                SwitchCase_Handler(selectedContent);                
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

        // Handler method for ComboBoxTX Selection Changed Event
        private void ComboBoxTH_SelectionChanged_Handler(object sender, SelectionChangedEventArgs e)
        {
            // Make sure that it is not null
            if (ComboBoxTH.SelectedItem != null)
            {
                string selectedCity = (string) ComboBoxTH.SelectedItem;
                MessageWindow.Text = "Manufacturing City is "+ selectedCity;
            }
        }

        
        private void CheckOption_Checked_Handler(object sender, RoutedEventArgs e)
        {
            MessageWindow.Text = "Check Option is checked!";
        }

        private void CheckOption_UnChecked_Handler(object sender, RoutedEventArgs e)
        {
            MessageWindow.Text = "Check Option is UN-checked!";
        }
    }
}
