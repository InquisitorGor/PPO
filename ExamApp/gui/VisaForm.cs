using System;
using ExamApp.database;
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
    public partial class VisaForm : Form
    {
        private visa visa { get; }

        public VisaForm(visa visa)
        {
            InitializeComponent();
            this.visa = visa;
            fillBoxes();
        }
        private void fillBoxes()
        {
            visaNumberBox.Text = visa.number;
            visaIssueBox.Value = visa.date_of_issue;
            visaExpirationBox.Value = visa.expirition_date;
            visaRateBox.DataSource = DBConnect.Entities.visa_rates.ToList();
            if (visa.id > 0) visaRateBox.Text = visa.visa_rates.ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            visa.number = visaNumberBox.Text;
            visa.date_of_issue = visaIssueBox.Value;
            visa.expirition_date = visaExpirationBox.Value;
            visa.visa_rates = visaRateBox.SelectedItem as visa_rates;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnect.Entities.visas.Remove(visa);
            visaNumberBox.Clear();
            visaIssueBox.Value = DateTime.Now;
            visaExpirationBox.Value = DateTime.Now;

        }
    }
}
