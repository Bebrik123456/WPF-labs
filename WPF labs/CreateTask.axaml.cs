using System;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;  
namespace WPF_labs;

public partial class CreateTask : Window
{
    public CreateTask()
    {
        InitializeComponent();
    }
    
    public void SdelatZapis(object sender, RoutedEventArgs e)
    {
        try
        {
            string stringconnection = "Server=localhost;Database=WPFLabs_DB;UserId=root;Password=;";
            string query = "INSERT INTO Task (Name,Description,Status,Category,UsrID) VALUES (@name,@description,@status,@category,@usrID)";
            string Name = TaskName.Text;
            string Description = TaskDescription.Text;
            var Categorys = Category.SelectedItem;
            
            var item = (ComboBoxItem)Categorys;
            
            string parse = item.Content.ToString();

            MySqlConnection connection = new(stringconnection);
            connection.Open();
            MySqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@category", parse);
            command.Parameters.AddWithValue("@status", 0);
            command.Parameters.AddWithValue("@usrID", 0);
            Vivid.Content = "Вы добавили новую задачу";
            Vivid.Foreground = Brushes.Green;
            command.ExecuteNonQuery();

        }
        catch (Exception z)
        {
            
        Vivid.Content = z.Message;
        }
    }
    
    private void BackButton(object sender, RoutedEventArgs e)
    {
        Hide();
        MainEmpty mainWindow = new MainEmpty ();
        mainWindow.Show();
        this.Close();
    }
}