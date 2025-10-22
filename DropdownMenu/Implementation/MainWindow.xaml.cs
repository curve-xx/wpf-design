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

namespace Implementation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        lvNames.ItemsSource = new List<string>()
            {
                "Joe",
                "Sean",
                "Mary"
            };
    }

    private void OnEditClick(object sender, RoutedEventArgs e)
    {

    }

    private void OnDeleteClick(object sender, RoutedEventArgs e)
    {

    }
}