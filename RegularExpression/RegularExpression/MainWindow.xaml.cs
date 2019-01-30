using System.Windows;
using System.Text.RegularExpressions;


namespace RegularExpression
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string phone = phoneBox.Text;
            string email = emailBox.Text;

            if (!ValidName(name))
            {
                MessageBox.Show(name + " is not a proper name.");
                if (!ValidPhone(phone))
                {
                    MessageBox.Show(phone + " is not a proper phone number.");
                    if (!ValidEmail(email))
                    {
                        MessageBox.Show(email + " is not a proper email address.");
                    }
                }
            }
            else
            {
                phoneBox.Text = ReformatPhone(phone);
            }
        }

        private bool ValidName(string name)
        {
            string nameRegex = "[a-zA-Z]+";
            string whitespace = @"\s";
            string pattern = "^(" + nameRegex + whitespace + "*)+$";
            return Regex.IsMatch(name, pattern);
        }

        private bool ValidPhone(string number)
        {
            string setOfDigits = "\\d{3}";
            string sign = "[*.]?";
            string pattern = setOfDigits + sign + setOfDigits + sign + setOfDigits;

            string phonePattern = "_^\\(?(\\d{3})\\)?[\\s\\-]?(\\d{3})\\-?(\\d{4})$_";

            return Regex.IsMatch(number, phonePattern);
        }

        private bool ValidEmail(string email)
        {
            string emailPrefix = "[a-zA-Z+-_.]+";
            string emailDomain = "[a-zA-Z0-9-]+";
            string emailPostFix = "[a-zA-Z0-9-.]+";
            string pattern = emailPrefix + "@" + emailDomain + "\\." + emailPostFix;
            return Regex.IsMatch(email, pattern);
        }

        private string ReformatPhone(string phone)
        {
            string phonePattern = "_^\\(?(\\d{3})\\)?[\\s\\-]?(\\d{3})\\-?(\\d{4})$_";
            return string.Format("({0}) {1}-{2}");
        }
    }
}
