using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using WPF_labs.Models;
using MySql.Data.MySqlClient;


namespace WPF_labs;

public partial class Main : Window
{
    
    public List<TaskModel> Tasks { get; set; }
    
    public Main()
    {
        InitializeComponent();
        
    }


    private void Window_Loaded()
    {
        
        
    }

}