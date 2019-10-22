using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class HomeGUI : Page {
        public HomeGUI() {
            this.InitializeComponent();
        }

        private void ButtonBasicCalculator_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(CalculatorGUI));
        }

        private void ButtonExchange_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ExchangeGUI));
        }

        private void ButtonInterest_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(InterestGUI));
        }

        private void ButtonMass_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MassGUI));
        }

        private void ButtonBubbleSort_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(BubbleSortGUI));
        }

        private void ButtonQuickSort_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(QuickSortGUI));
        }
    }
}
