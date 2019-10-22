using DimensionCalculator.Classes;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class ExchangeGUI : Page {
        public ExchangeGUI() {
            this.InitializeComponent();
            TxtBxDown.Text = exchangeClass.CurrencyConversion(upNumber, 0, 1) + "";
        }

        // My Vairables
        CExchange exchangeClass = new CExchange();

        public string upTextBox = "0";
        public string downTextBox = "0";
        public double upNumber = 0;
        public double downNumber = 0;

        // Private 
        private string lastActive = "Top";
        private bool frameHasLoad = false;

        // Convertion of the currencies entered by user
        public void SetFromAndToCurrencies() {
            int indexOfCmboxUp = CmbBxUp.SelectedIndex;
            int indexOfCmboxDown = CmbBxDown.SelectedIndex;

            if ((NumberTest(upTextBox) == true) && (NumberTest(downTextBox) == true)) {  // test for numbers
                upTextBox = TxtBxUp.Text;
                downTextBox = TxtBxDown.Text;
                upNumber = double.Parse(upTextBox);
                downNumber = double.Parse(downTextBox);

                if (lastActive.Equals("Top")) {
                    TxtBxUp.Text = upNumber + "";
                    TxtBlckTypeUp.Text = exchangeClass.GetUpTxtblckValue(); // sets the value for upper textblock
                    TxtBlckTypeDown.Text = exchangeClass.GetDownTxtblckValue(); // sets the value for lower textblock

                    // set specified textbox to returned amount
                    TxtBxDown.Text = exchangeClass.CurrencyConversion(upNumber, indexOfCmboxUp, indexOfCmboxDown) + "";
                } else if (lastActive.Equals("Bottom")) {
                    TxtBxDown.Text = downNumber + "";
                    TxtBlckTypeUp.Text = exchangeClass.GetDownTxtblckValue(); // sets the value for lower textblock
                    TxtBlckTypeDown.Text = exchangeClass.GetUpTxtblckValue(); // sets the value for upper textblock

                    // sets the value for upper textblock
                    TxtBxUp.Text = exchangeClass.CurrencyConversion(downNumber, indexOfCmboxDown, indexOfCmboxUp) + "";
                }
            }
        }

        // Number test method
        private bool NumberTest(string number) {
            bool flag = false;
            try {
                double tmp = double.Parse(number);
                flag = true;
            } catch (FormatException) {  // Number input Exception
                flag = false;
            }
            return flag;
        }

        // Adds typed key to string
        private void KeypressedReturn(string tmpressed) {
            if (lastActive.Equals("Top")) {
                upTextBox += tmpressed;
                TxtBxUp.Text = upTextBox;
            } else if (lastActive.Equals("Bottom")) {
                downTextBox += tmpressed;
                TxtBxDown.Text = downTextBox;
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn(",");
        }

        // reset all values
        private void AllClear_Click(object sender, RoutedEventArgs e) {
            TxtBxUp.Text = "0";
            TxtBxDown.Text = "0";
            upTextBox = "0";
            downTextBox = "0";
            upNumber = 0;
            downNumber = 0;
        }

        private void Backspace_Click(object sender, RoutedEventArgs e) {
            if (lastActive.Equals("Top")) {
                if (upTextBox.Length != 0) {
                    upTextBox = upTextBox.Remove(upTextBox.Length - 1);
                    TxtBxUp.Text = upTextBox;
                }
            } else if (lastActive.Equals("Bottom")) {
                if (downTextBox.Length != 0) {
                    downTextBox = downTextBox.Remove(downTextBox.Length - 1);
                    TxtBxDown.Text = downTextBox;
                }
            }
        }

        private void NumTrZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("000");
        }

        private void NumSeven_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("7");
        }

        private void NumEight_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("8");
        }

        private void NumNine_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("9");
        }

        private void NumDuZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("00");
        }

        private void NumFour_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("4");
        }

        private void NumFive_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("5");
        }

        private void NumSix_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("6");
        }

        private void NumZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("0");
        }

        private void NumOne_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("1");
        }

        private void NumTwo_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("2");
        }

        private void NumThree_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("3");
        }

        private void TxtBxUp_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Top";
            frameHasLoad = true;
        }

        private void TxtBxDown_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Bottom";
            frameHasLoad = true;
        }

        private void TxtBxUp_TextChanged(object sender, TextChangedEventArgs e) {
            SetFromAndToCurrencies();
        }

        private void TxtBxDown_TextChanged(object sender, TextChangedEventArgs e) {
            SetFromAndToCurrencies();
        }

        private void CmbBxUp_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (frameHasLoad == true) {  // test if frame has loaded yet
                SetFromAndToCurrencies();
            }
        }

        private void CmbBxDown_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (frameHasLoad == true) {  // test if frame has loaded yet
                SetFromAndToCurrencies();
            }
        }
    }
}
