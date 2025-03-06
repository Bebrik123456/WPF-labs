using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;

namespace WPF_labs;

public partial class MainEmpty : Window
{
    public MainEmpty()
    {
        InitializeComponent();
      Border1.IsVisible = false;
    }

    private void SozdanieZadachi(object sender, RoutedEventArgs e)
    {
        Hide();
        CreateTask TaskWin = new CreateTask();
        TaskWin.Show();
        this.Close();
    }
    

    private void InputElement_OnTapped(object? sender, TappedEventArgs e)
    {
        Border1.IsVisible = !Border1.IsVisible;
    }

    private void TextBlock1Element_OnTapped(object? sender, TappedEventArgs e)
    {
        Hide();
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
}