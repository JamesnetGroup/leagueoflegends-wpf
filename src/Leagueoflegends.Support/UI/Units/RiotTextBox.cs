using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotTextBox : TextBox
{
    public RiotTextBox()
    {
        this.DefaultStyleKey = typeof(RiotTextBox);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        var deleteButton = GetTemplateChild("DeleteButton") as RiotTextBoxCloseButton;
        if (deleteButton != null)
        {
            deleteButton.Click += DeleteButton_Click;
        }
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        this.Text = string.Empty;
    }
}
