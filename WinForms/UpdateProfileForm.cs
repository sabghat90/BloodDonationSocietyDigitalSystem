using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class UpdateProfileForm : Form
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void txbxUpdateName_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("^[A-Za-z - ]+$", txbxUpdateName, lblName, "Name");
        }

        private void cbUpdateBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (!(cbUpdateBloodGroup.Text.Equals("A+") || cbUpdateBloodGroup.Text.Equals("A-") ||
                  cbUpdateBloodGroup.Text.Equals("B+") || cbUpdateBloodGroup.Text.Equals("B-") ||
                  cbUpdateBloodGroup.Text.Equals("AB+") || cbUpdateBloodGroup.Text.Equals("AB-") ||
                  cbUpdateBloodGroup.Text.Equals("O+") || cbUpdateBloodGroup.Text.Equals("O-")))
                lblBloodGroup.Text = "Invalid";
            else
                lblBloodGroup.Text = "";
        }

        private void cbUpdateGender_TextChanged(object sender, EventArgs e)
        {
            if (cbUpdateGender.Text.Equals(""))
                lblGender.Text = "Empty Field";
            else if (!(cbUpdateGender.Text == "Male" || cbUpdateGender.Text == "Female" ||
                       cbUpdateGender.Text == "Custom"))
                lblGender.Text = "Invalid Gender";
            else
                lblGender.Text = "";
        }

        private void txbxUpdateCity_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("[A-Za-z - ]+$", txbxUpdateCity, lblCity, "City");
        }

        private void txbxUpdatePhone_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", txbxUpdatePhone, lblPhone,
                "Phone Number");
        }

        private void txbxUpdateAge_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[1-9]+$", txbxUpdateAge, lblAge, "Age");
        }

        private void rtxbxUpdateAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxbxUpdateAddress.Text.Equals(""))
                lblAddress.Text = @"Empty Filed";
            else if (Regex.Match(rtxbxUpdateAddress.Text, @"^\d+\s[A-z]+\s[A-z]+").Success)
                lblAddress.Text = @"Invalid Address...";
            else
                lblAddress.Text = "";
        }
    }
}