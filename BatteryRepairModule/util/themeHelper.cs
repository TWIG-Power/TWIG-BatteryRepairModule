public static class ThemeHelper
{
    public static void ApplyTheme(Form form)
    {
        form.BackColor = Color.Gainsboro;

        foreach (Control control in form.Controls)
        {
            if (control is ComboBox)
            {
                //control.BackColor = Color.White;
                //control.ForeColor = Color.Black;
            }
            else if (control is TextBox)
            {
                //control.BackColor = Color.LightYellow;
                //control.ForeColor = Color.Black;
            }
            else if (control is ListBox)
            {
                //control.BackColor = Color.LightBlue;
                //control.ForeColor = Color.Black;
            }
            else if (control is Button)
            {
                //control.BackColor = Color.LightGreen;
                //control.ForeColor = Color.Black;
            }
        }
    }
}