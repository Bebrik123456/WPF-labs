using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using WPF_labs;

namespace WPF_labs;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Reg_Button(object? sender, RoutedEventArgs e)
    {
        Hide();
        Registration reg = new Registration();
        reg.Show();
        this.Close();
        
    }

    private void LoginButton(object sender, RoutedEventArgs e)
    {
        Hide();
        MainEmpty empty = new MainEmpty();
        empty.Show();
        this.Close();
    }
}