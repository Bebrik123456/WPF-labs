using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using WPF_labs.Models;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Templates;
using System.Collections.Immutable;
using System.Collections.ObjectModel;


namespace WPF_labs;

public partial class Main : Window
{
    
    public List<TaskModel> Tasks { get; set; }
    
    public Main()
    {
        InitializeComponent();
         Tasks = new List<TaskModel>
        {
            new TaskModel { Id =1, Name = "Задача 1",Description = "Sisi",Status = 1,DateTime = DateTime.Now, Type = 1}
            // Добавьте другие задачи по мере необходимости
        };
        DataContext = this;
        
        
    }
}