using ExamApp.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp.gui
{
    public partial class InternationalPassportForm : Form
    {

        private international_passports passport { get; }
        public InternationalPassportForm(international_passports passport)
        {
            InitializeComponent();
            this.passport = passport;
            fillBoxes();
        }
        private void fillBoxes()
        {
            iPNumber.Text = passport.number;
            iPIssueBox.Value = passport.date_of_issue;
            iPExpirationBox.Value = passport.expirition_date;
            iPCountryBox.DataSource = DBConnect.Entities.countries.ToList();
            if(passport.id > 0) iPCountryBox.Text = passport.country.ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            passport.number = iPNumber.Text;
            passport.date_of_issue = iPIssueBox.Value;
            passport.expirition_date = iPExpirationBox.Value;
            passport.country = iPCountryBox.SelectedItem as country; 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnect.Entities.international_passports.Remove(passport);
            iPNumber.Clear();
            iPIssueBox.Value = DateTime.Now;
            iPExpirationBox.Value = DateTime.Now;
        }
    }
}
