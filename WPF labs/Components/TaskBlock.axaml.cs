using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using WPF_labs.Models;

namespace WPF_labs.Components;

public partial class TaskBlock : UserControl
{
    public delegate void OnClickHandler(TaskBlock taskBlock);
    
    public event OnClickHandler OnClick;

    private TaskModel _task;
    
    public TaskBlock()
    {
        InitializeComponent();
        PointerPressed += OnPointerPressed;
    }

    void OnPointerPressed(object sender, PointerPressedEventArgs e)
    {
        OnClick?.Invoke(this);
    }

    public void LoadData(TaskModel task)
    {
        Title.Text = task.TaskName;
        Subtitle.Text = task.TaskDescription;
        _task = task;
    }
}