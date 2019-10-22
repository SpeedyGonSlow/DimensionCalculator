using DimensionCalculator.GUIs;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DimensionCalculator {
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
            FocusFrame.Navigate(typeof(HomeGUI));   // set initial frame
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e) {
            if (FocusFrame.CanGoBack) { // test if can go back
                FocusFrame.GoBack();
            }
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e) {
            FocusFrame.UpdateLayout();  // refresh the GUI
        }

        private void ButtonForward_Click(object sender, RoutedEventArgs e) {
            if (FocusFrame.CanGoForward) {  // test if can go forward
                FocusFrame.GoForward();
            }
        }

        private void NavHomeGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(HomeGUI));
        }

        private void NavBasicCalculatorGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(CalculatorGUI));
        }

        private void NavInterestGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(InterestGUI));
        }

        private void NavExchangeGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(ExchangeGUI));
        }

        private void NavMassGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(MassGUI));
        }

        private void NavBubbleSortGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(BubbleSortGUI));
        }

        private void NavQuickSortGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(QuickSortGUI));
        }

        private void NavAboutGUI_Tapped(object sender, TappedRoutedEventArgs e) {
            FocusFrame.Navigate(typeof(AboutGUI));
        }
    }
}
