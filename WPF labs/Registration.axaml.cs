using Avalonia.Controls;
using Avalonia.Interactivity;

namespace WPF_labs;

public partial class Registration : Window
{
    public Registration()
    {
        InitializeComponent();
    }

    public void BackClick(object sender, RoutedEventArgs e)
    {
        Hide();
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
}