using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSweetAlert;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void PerformAction_Click(object sender, RoutedEventArgs e)
    {
        // 1. Instantiate the custom dialog with the specific message
        string actionMessage = "This will permanently delete the selected user data. Do you wish to continue?";
        ConfirmationDialog dialog = new ConfirmationDialog(actionMessage);

        // 2. Show the dialog modally and store the result
        // ShowDialog() blocks execution until the custom window is closed.
        bool? result = dialog.ShowDialog();

        // 3. Process the result
        if (result == true)
        {
            // User clicked 'Yes, Proceed!'
            ResultTextBlock.Text = "Status: Action Confirmed! Deleting data...";
            ResultTextBlock.Foreground = new SolidColorBrush(Colors.Green);
            // **Place your actual confirmation logic (e.g., database call) here.**
        }
        else
        {
            // User clicked 'Cancel' or pressed Esc/closed the window (result is null or false)
            ResultTextBlock.Text = "Status: Action Cancelled.";
            ResultTextBlock.Foreground = new SolidColorBrush(Colors.Red);
            // **Place your cancellation logic here.**
        }
    }
}