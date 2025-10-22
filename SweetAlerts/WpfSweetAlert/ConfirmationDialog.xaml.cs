using System.Windows;

namespace WpfSweetAlert
{
    public partial class ConfirmationDialog : Window
    {
        // Constructor to set the message dynamically
        public ConfirmationDialog(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            // Set DialogResult to true for "Confirmed"
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Set DialogResult to false for "Canceled"
            this.DialogResult = false;
            this.Close();
        }
    }
}