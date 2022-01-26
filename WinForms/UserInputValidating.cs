using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    internal class UserInputValidating
    {
        public static void ValidateUser(string regex, TextBox txbx, Label lbl, string lblName)
        {
            if (txbx.Text.Equals(""))
                lbl.Text = @"Empty Field";
            else if (!Regex.Match(txbx.Text, regex).Success)
                lbl.Text = @"Invalid " + lblName;
            else
                lbl.Text = "";
        }
    }
}