using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Avalonia;
using WPF_labs.Models;
using MySql.Data.MySqlClient;
using WPF_labs.Components;
using WPF_labs.Data;


namespace WPF_labs;


public partial class HistoryTask : Window
{
   

    public HistoryTask()
    {
        InitializeComponent();
    }

    private void BackButton(object? sender, RoutedEventArgs e)
    {
        Hide();
        Main main = new Main();
        main.Show();
        this.Close();
    }
}