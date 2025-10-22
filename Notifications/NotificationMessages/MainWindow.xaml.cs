using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace NotificationMessages;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Notifier _notifier;
    public MainWindow()
    {
        InitializeComponent();
        // 1. Initialize the Notifier with configuration
        _notifier = new Notifier(cfg =>
        {
            // // Position: Top right of the MainWindow
            // cfg.PositionProvider = new WindowPositionProvider(
            //     parentWindow: Application.Current.MainWindow,
            //     corner: Corner.TopRight,
            //     offsetX: 10,
            //     offsetY: 10);
            
            // Position: Top right of the screen
            cfg.PositionProvider = new PrimaryScreenPositionProvider(
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            // Lifetime: 3 seconds, maximum 5 toasts visible
            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            // Dispatcher: For thread safety
            cfg.Dispatcher = Application.Current.Dispatcher;
        });

        // 2. Dispose the notifier when the window closes to clean up resources
        this.Closed += (sender, args) => _notifier.Dispose();
    }

    // 3. Event handler for the button click
    private void ShowToast_Click(object sender, RoutedEventArgs e)
    {
        // Display a Success Toast
        _notifier.ShowSuccess("The operation was completed successfully! 🎉");

        // You can easily show other types:
        // _notifier.ShowError("Failed to connect to the server.");
        // _notifier.ShowWarning("Please review your changes.");
        // _notifier.ShowInformation("A new version is available.");
    }
}