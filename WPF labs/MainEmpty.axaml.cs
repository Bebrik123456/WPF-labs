using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;

namespace WPF_labs;

public partial class MainEmpty : Window
{
    public MainEmpty()
    {
        InitializeComponent();
    }

    private void SozdanieZadachi(object sender, RoutedEventArgs e)
    {
        Hide();
        CreateTask TaskWin = new CreateTask();
        TaskWin.Show();
        this.Close();
        
        
    }
}