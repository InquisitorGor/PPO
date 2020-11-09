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
    public partial class VisaForm : Form
    {
        private visa visa { get; }

        private bool isShown { get; }

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
            visaRateBox.SelectedItem = visa.visa_rates;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            visa.number = visaNumberBox.Text;
            visa.date_of_issue = visaIssueBox.Value;
            visa.expirition_date = visaExpirationBox.Value;
            visa.visa_rates = visaRateBox.SelectedItem as visa_rates;

        }
    }
}
