using Avalonia.Controls;
namespace WPF_labs.Components;

public class vsyakieMetodi
{
    private bool _isFirstClick = true;

    public void ClearTextBoxOnFirstClick(TextBox textBox)
    {
        if (_isFirstClick)
        {
            textBox.Text = string.Empty; // Очищаем текст
            _isFirstClick = false; // Устанавливаем флаг, чтобы текст больше не убирался
        }
    }
}