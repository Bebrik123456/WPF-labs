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


public partial class Main : Window
{
    private DatabaseHelper _databaseHelper;
    public List<TaskModel> Tasks { get; set; }
    
    public Main()
    {
        InitializeComponent();
        _databaseHelper = new DatabaseHelper();
        LoadTasks();
       
    }


    private void  LoadTasks()
    {
        var tasks = _databaseHelper.GetTasks(); // Получаем список задач из базы данных

        foreach (var task in tasks)
        {
            var taskBlock = new TaskBlock();
            taskBlock.Margin = new Thickness(0, 10, 0, 0);
            taskBlock.LoadData(task);
            taskBlock.OnClick += (taskBlock) =>
            {
                previewTitle.Text = taskBlock.Title.Text;
                previewSubtitle.Text = taskBlock.Subtitle.Text;
            };
            
            TasksStackPanel.Children.Add(taskBlock);
        }
    }

}