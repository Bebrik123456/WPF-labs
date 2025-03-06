using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using MySql.Data.MySqlClient;
using System.Linq;
namespace WPF_labs;

public partial class Registration : Window
{
    string stringconnection = "Server=localhost;Database=WPFLabs_DB;User Id=root;Password=;";
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

    public void RegisterClick(object sender, RoutedEventArgs e)
    {
        try
        {
            string query = "INSERT INTO User (Name,Email,Password) VALUES (@name,@email,@password)";
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextbox.Text;

            if (EmailCheckRepeat())
            {
                if (EmailCheck() && PassCheck())
                {

                    MySqlConnection connection = new MySqlConnection(stringconnection);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                    LabelVivod.Content = "Вы успешно зарегистрировались";
                    LabelVivod.Foreground = Brushes.Green;
                }
                else
                {
                    LabelVivod.Content = "Неправильно введена почта или пароль";
                    LabelVivod.Foreground = Brushes.Red;
                }
            }
            else
            {
                LabelVivod.Content = "Пользователь с такой почтой уже существует";
                LabelVivod.Foreground = Brushes.Red;
            }
        }
        catch (Exception ex)
        {
            LabelVivod.Content = ex.Message;
        }
    }

    private bool EmailCheckRepeat()
    {
        MySqlConnection connection = new MySqlConnection(stringconnection);
        var query = "SELECT COUNT(*) FROM User WHERE Email = @Email";
        connection.Open();
        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                LabelVivod.Content = "Почта уже существует в базе данных";
                LabelVivod.Foreground = Brushes.Red;
                return false;
            }
            else
            {
               return true;
            }
        }
        connection.Close();
    }

    public bool PassCheck()
    {
        string pass1 = PasswordTextbox.Text;
        string pass2 = PassCheckBox.Text;
        var a = pass1.ToCharArray();

        if (pass1 == pass2 && a.Length >=6)
        {
            return true;
        }
        else
        {
            LabelVivod.Content = "Длина пароля меньше 6 символов или пароли не совпадают";
            LabelVivod.Foreground = Brushes.Red;
            return false;
        }
    }

    public bool  EmailCheck()
    {
        string eml = EmailTextBox.Text;
        var a = eml.ToCharArray();
        if (a.Length<=6 )
        {
            return false;
        }
        else
        {
            return true;
        }
    }


}