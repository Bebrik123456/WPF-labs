using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using WPF_labs;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPF_labs;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Reg_Button(object? sender, RoutedEventArgs e)
    {
        Hide();
        Registration reg = new Registration();
        reg.Show();
        this.Close();

    }

    private void LoginButton(object sender, RoutedEventArgs e)
    {
       MailCheck();
       
       
       
       
    }

    private void MailCheck()
    {
            string email = PochtaTextbox.Text;
            var a = email.ToCharArray();
            if (a.Contains('@')||a.Contains('.'))
            {
                var password = PasswordTextBox.Text;
                var b = password.ToCharArray();

                if (b.Length>=6)
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

  


}