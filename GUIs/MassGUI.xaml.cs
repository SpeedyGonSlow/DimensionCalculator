using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class MassGUI : Page {
        public MassGUI() {
            this.InitializeComponent();
        }

        // My Vairables
        public string upTextBox = "0";
        public string downTextBox = "0";
        public double upNumber = 0;
        public double downNumber = 0;
        private string lastActive = "Top";
        private bool frameHasLoad = false;

        // Convertion from one unit to the other
        private void DoConvertion(int upcombobox, int downcombobox) {
            if ((NumberTest(upTextBox) == true) && (NumberTest(downTextBox) == true)) {
                upTextBox = TxtBxUp.Text;
                downTextBox = TxtBxDown.Text;
                upNumber = double.Parse(upTextBox);
                downNumber = double.Parse(downTextBox);

                if (lastActive.Equals("Top")) {
                    TxtBxUp.Text = upNumber + "";
                    switch (downcombobox) {
                        case 0:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber * 1000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber * 1000000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber / 0.035274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber / 0.0022046;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber / 0.00015747;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                        case 1:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber / 1000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber * 1000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber / 35.274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber / 2.2046;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber / 0.15747;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                        case 2:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber / 1000000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber / 1000;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber / 35274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber / 2204.6;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber / 157.47;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                        case 3:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber * 0.035274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber * 35.274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber * 35274;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber * 16;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber * 224;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                        case 4:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber * 0.0022046;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber * 2.2046;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber * 2204.6;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber / 16;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber * 14;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                        case 5:
                            switch (upcombobox) {
                                case 0:
                                    downNumber = upNumber * 0.00015747;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 1:
                                    downNumber = upNumber * 0.15747;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 2:
                                    downNumber = upNumber * 157.47;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 3:
                                    downNumber = upNumber / 224;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 4:
                                    downNumber = upNumber / 14;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                                case 5:
                                    downNumber = upNumber;
                                    TxtBxDown.Text = downNumber + "";
                                    break;
                            }
                            break;
                    }   // All possible option test for upper textbox
                } else if (lastActive.Equals("Bottom")) {
                    TxtBxDown.Text = downNumber + "";
                    switch (upcombobox) {
                        case 0:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber * 1000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber * 1000000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber / 0.035274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber / 0.0022046;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber / 0.00015747;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                        case 1:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber / 1000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber * 1000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber / 35.274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber / 2.2046;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber / 0.15747;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                        case 2:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber / 1000000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber / 1000;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber / 35274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber / 2204.6;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber / 157.47;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                        case 3:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber * 0.035274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber * 35.274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber * 35274;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber * 16;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber * 224;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                        case 4:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber * 0.0022046;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber * 2.2046;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber * 2204.6;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber / 16;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber * 14;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                        case 5:
                            switch (downcombobox) {
                                case 0:
                                    upNumber = downNumber * 0.00015747;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 1:
                                    upNumber = downNumber * 0.15747;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 2:
                                    upNumber = downNumber * 157.47;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 3:
                                    upNumber = downNumber / 224;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 4:
                                    upNumber = downNumber / 14;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                                case 5:
                                    upNumber = downNumber;
                                    TxtBxUp.Text = upNumber + "";
                                    break;
                            }
                            break;
                    }     // All possible option test for lower textbox
                }
            }
        }

        // Test is number is equal to zero
        private bool NumberTest(string number) {
            bool flag = false;
            try {
                double tmp = double.Parse(number);
                flag = true;
            } catch (FormatException) {
                flag = false;
            }
            return flag;
        }

        // Typed key to be added to textbox
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

        // Clear all textboxes and viarables
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

        // Event for when text change in textbox
        private void TxtBxUp_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Top";
            frameHasLoad = true;
        }

        // Event for when pointer enters object
        private void TxtBxDown_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Bottom";
            frameHasLoad = true;
        }

        private void TxtBxUp_TextChanged(object sender, TextChangedEventArgs e) {
            DoConvertion(CmbBxUp.SelectedIndex, CmbBxDown.SelectedIndex);
        }

        private void TxtBxDown_TextChanged(object sender, TextChangedEventArgs e) {
            DoConvertion(CmbBxUp.SelectedIndex, CmbBxDown.SelectedIndex);
        }

        // Event for when selection changes in combobox
        private void CmbBxUp_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (frameHasLoad == true) {
                DoConvertion(CmbBxUp.SelectedIndex, CmbBxDown.SelectedIndex);
            }
        }

        private void CmbBxDown_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (frameHasLoad == true) {
                DoConvertion(CmbBxUp.SelectedIndex, CmbBxDown.SelectedIndex);
            }
        }
    }
}
