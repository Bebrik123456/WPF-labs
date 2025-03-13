using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using WPF_labs;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Avalonia.Input;
using MySql.Data.MySqlClient;
using WPF_labs.Components;
namespace WPF_labs;

public partial class MainWindow : Window
{
    private vsyakieMetodi _textBoxHelper;
    public MainWindow()
    {
        InitializeComponent();
        _textBoxHelper = new vsyakieMetodi();
    }
    private void MyTextBox_PointerPressed(object sender)
    {
        var textBox = sender as TextBox;
        if (textBox != null)
        {
            _textBoxHelper.ClearTextBoxOnFirstClick(textBox);
        }
    }

    private void Reg_Button(object? sender, RoutedEventArgs e)
    {
        Hide();
        Registration reg = new Registration();
        reg.Show();
        this.Close();

    }

    private async void LoginButton(object sender, RoutedEventArgs e)
    {
      await MailCheck();
    }

    private async Task MailCheck()
    {
            string email = PochtaTextbox.Text;
            var a = email.ToCharArray();
            if (a.Contains('@')||a.Contains('.')|| a.Length>=5)
            {
                var password = PasswordTextBox.Text;
                var b = password.ToCharArray();
        
                if (b.Length>=6)
                {
                    string stringconnection = "Server=localhost;Database=WPFLabs_DB;User Id=root;Password=;";
                    string query = "SELECT Email,Password  FROM User WHERE `Email` = @username AND `Password` = @password";
                    string passwordDB = PasswordTextBox.Text;
                    string loginDB = PochtaTextbox.Text;
                    
                    MySqlConnection con = new MySqlConnection(stringconnection);
                     await con.OpenAsync();
        
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", loginDB);
                    cmd.Parameters.AddWithValue("@password", passwordDB);
            
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Hide();
                        MainEmpty empty = new MainEmpty();
                        empty.Show();
                        this.Close();
                    }
                    else
                    {
                        OshibkaLabel.Content = "Неверно введена почта или пароль";
                    }



                }
                else
                {
                    OshibkaLabel.Content = "Неверно введена почта или пароль";
                }
            }
            else
            {
                OshibkaLabel.Content = "Неверно введена почта или пароль";
            }
        
    }


    private void PasswordTextBox_OnKeyDown(object? sender, KeyEventArgs e)
    {
        PasswordTextBox.Text = "";
    }

    
}