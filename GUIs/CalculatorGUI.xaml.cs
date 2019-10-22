using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class CalculatorGUI : Page {
        public CalculatorGUI() {
            this.InitializeComponent();
        }

        // My Viarables
        public double numberInUse = 0;
        public double numberInUse2 = 0;
        public double finalAnswer = 0;
        public string functionToString = "";
        public string functionToString2 = "";

        // My Constants
        public const double pi = 3.1415926535897932384626433832795;

        // Test if string is empty or "null"
        private bool NullTest(string number) {
            bool flag = false;

            if ((!number.Equals(null)) && (!number.Equals(""))) {
                flag = true;
            } else {
                flag = false;
            }
            return flag;
        }

        // Test if number is equal to zero
        private bool ZeroTest(string number) {
            bool flag = false;
            try {
                double tmp = double.Parse(number);
                if (tmp != 0) {
                    flag = true;
                } else {
                    flag = false;
                }
            } catch (FormatException) { // Exception for only numbers as input
                flag = false;
            }
            return flag;
        }

        // Removes any leading zeros if there are any
        private string RemoveLeadingZeros(string number) {
            bool flag = false;
            while (flag != true) {
                if (number.StartsWith('0')) {
                    number = number.Remove(0, 1);
                } else {
                    flag = true;
                }
            }
            return number;
        }

        // Default error message
        private async void ErrorMsg() {
            ContentDialog errorNumberDialog = new ContentDialog {
                Title = "Error Input!",
                Content = "Please input Valid Numbers!",
                Foreground = new SolidColorBrush(Colors.Red),
                CloseButtonText = "OK"
            };
            await errorNumberDialog.ShowAsync();
        }

        private void SquareRoot_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = "√(" + functionToString + ") = ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
                numberInUse = double.Parse(TxtBxInput.Text);
                finalAnswer = Math.Sqrt(numberInUse); // perform the squareroot function
                TxtBxInput.Text = finalAnswer + "";
            } else {
                ErrorMsg();
            }
        }

        private void XPowerY_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " ^ ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        private void PI_Click(object sender, RoutedEventArgs e) {
            functionToString = pi + "";
            TxtBxInput.Text = functionToString;
        }

        private void Factorial_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = "fact(" + functionToString + ") = ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
                numberInUse = double.Parse(TxtBxInput.Text);
                finalAnswer = numberInUse;
                for (int i = (int)numberInUse - 1; i >= 1; i--) {  // a for loop to calculate the factorial amount
                    finalAnswer = finalAnswer * i;
                }
                TxtBxInput.Text = finalAnswer + "";
            } else {
                ErrorMsg();
            }
        }

        private void Inverse_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = "1/" + functionToString;
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
                numberInUse = double.Parse(TxtBxInput.Text);
                finalAnswer = 1 / numberInUse;      // convert number to its inverse
                TxtBxInput.Text = finalAnswer + "";
            } else {
                ErrorMsg();
            }
        }

        private void NumSeven_Click(object sender, RoutedEventArgs e) {
            functionToString += "7";
            TxtBxInput.Text = functionToString;
        }

        private void NumEight_Click(object sender, RoutedEventArgs e) {
            functionToString += "8";
            TxtBxInput.Text = functionToString;
        }

        private void NumNine_Click(object sender, RoutedEventArgs e) {
            functionToString += "9";
            TxtBxInput.Text = functionToString;
        }

        private void Backspace_Click(object sender, RoutedEventArgs e) {
            if (functionToString.Length != 0) {
                functionToString = functionToString.Remove(functionToString.Length - 1);
                TxtBxInput.Text = functionToString;
            }
        }

        // Clears all textboxes
        private void AllClear_Click(object sender, RoutedEventArgs e) {
            TxtBxInput.Text = "";
            TxtBlckFunction.Text = "";
            functionToString = "";
            functionToString2 = "";
            numberInUse = 0;
            numberInUse2 = 0;
            finalAnswer = 0;
        }

        private void NumFour_Click(object sender, RoutedEventArgs e) {
            functionToString += "4";
            TxtBxInput.Text = functionToString;
        }

        private void NumFive_Click(object sender, RoutedEventArgs e) {
            functionToString += "5";
            TxtBxInput.Text = functionToString;
        }

        private void NumSix_Click(object sender, RoutedEventArgs e) {
            functionToString += "6";
            TxtBxInput.Text = functionToString;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " × ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " ÷ ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        private void NumOne_Click(object sender, RoutedEventArgs e) {
            functionToString += "1";
            TxtBxInput.Text = functionToString;
        }

        private void NumTwo_Click(object sender, RoutedEventArgs e) {
            functionToString += "2";
            TxtBxInput.Text = functionToString;
        }

        private void NumThree_Click(object sender, RoutedEventArgs e) {
            functionToString += "3";
            TxtBxInput.Text = functionToString;
        }

        private void Plus_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " + ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " - ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        private void NumZero_Click(object sender, RoutedEventArgs e) {
            functionToString += "0";
            TxtBxInput.Text = functionToString;
        }

        private void Point_Click(object sender, RoutedEventArgs e) {
            functionToString += ",";
            TxtBxInput.Text = functionToString;
        }

        private void Persentage_Click(object sender, RoutedEventArgs e) {
            Equal_Click(sender, e);

            functionToString = TxtBxInput.Text;
            if ((ZeroTest(functionToString) == true) && (NullTest(functionToString) == true)) {
                functionToString = RemoveLeadingZeros(functionToString);
                functionToString = functionToString + " percent of ";
                TxtBlckFunction.Text = functionToString;
                functionToString = "";
            } else {
                ErrorMsg();
            }
        }

        // When equal is clicked
        private void Equal_Click(object sender, RoutedEventArgs e) {
            functionToString = "0" + TxtBlckFunction.Text;
            if (NullTest(functionToString) == true) {
                if ((functionToString.Contains("^")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("^"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = Math.Pow(numberInUse, numberInUse2);  // perform power function
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
                if ((functionToString.Contains("+")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("+"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = numberInUse + numberInUse2; // perform plus function
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
                if ((functionToString.Contains("-")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("-"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = numberInUse - numberInUse2;  // perform minus function
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
                if ((functionToString.Contains("×")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("×"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = numberInUse * numberInUse2;  // perform multiply function
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
                if ((functionToString.Contains("÷")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("÷"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = numberInUse / numberInUse2;  // perform divide function
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
                if ((functionToString.Contains("percent")) && (!functionToString.Contains("="))) {
                    functionToString2 = "0" + TxtBxInput.Text;
                    if ((ZeroTest(functionToString2) == true) && (NullTest(functionToString2) == true)) {
                        functionToString = RemoveLeadingZeros(functionToString);
                        functionToString2 = RemoveLeadingZeros(functionToString2);
                        TxtBlckFunction.Text = functionToString + functionToString2 + " = ";
                        functionToString = functionToString.Remove(functionToString.IndexOf("p"));
                        numberInUse = double.Parse(functionToString);
                        numberInUse2 = double.Parse(functionToString2);
                        finalAnswer = numberInUse2 * (numberInUse / 100);  // calculate percentage
                        TxtBxInput.Text = finalAnswer + "";
                        functionToString = "";
                        functionToString2 = "";
                    } else {
                        ErrorMsg();
                    }
                }
            } else {
                ErrorMsg();
            }
        }
    }
}
