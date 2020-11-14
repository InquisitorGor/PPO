
using ExamApp.database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace ExamApp.gui.images
{
    public partial class FormForInteracting : Form
    {
        
        private client client { get; }

        public FormForInteracting(client client)
        {
            InitializeComponent();
            this.client = client;
            fillBoxes();
            setDGVDatasourse();
            setDGVHeaders();

        }
        private void setDGVHeaders()
        {
            visaDGV.Columns[0].Visible = false;
            visaDGV.Columns[1].HeaderText = "Номер визы";
            visaDGV.Columns[2].HeaderText = "Дата получения";
            visaDGV.Columns[3].HeaderText = "Дата окончания";
            visaDGV.Columns[4].Visible = false;
            visaDGV.Columns[5].Visible = false;
            visaDGV.Columns[6].Visible = false;
            visaDGV.Columns[7].Visible = false;

            iPDGV.Columns[0].Visible = false;
            iPDGV.Columns[1].HeaderText = "Номер загранпаспорта";
            iPDGV.Columns[2].HeaderText = "Дата получения";
            iPDGV.Columns[3].HeaderText = "Дата окончания";
            iPDGV.Columns[4].Visible = false;
            iPDGV.Columns[5].Visible = false;
            iPDGV.Columns[6].Visible = false;
            iPDGV.Columns[7].Visible = false;
        }

        private void fillBoxes()
        {
            surnameBox.Text = client.surname;
            nameBox.Text = client.name;
            lastNameBox.Text = client.last_name;
            birthday.Value = client.birthday;

  
        }
        
        private void setDGVDatasourse()
        {
            visaDGV.DataSource = client.visas.ToList();
            iPDGV.DataSource = client.international_passports.ToList();
        }

        private void visaDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; };
            visa v = visaDGV.Rows[e.RowIndex].DataBoundItem as visa;
            VisaForm visaForm = new VisaForm(v);
            visaForm.ShowDialog();
            setDGVDatasourse();
        }
        private void iPDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; };
            international_passports ip = iPDGV.Rows[e.RowIndex].DataBoundItem as international_passports;
            InternationalPassportForm passportForm = new InternationalPassportForm(ip);
            passportForm.ShowDialog();
            setDGVDatasourse();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            if (client.id <= 0)
            {
                refreshClient();
                DBConnect.Entities.clients.Add(client);
                MessageBox.Show("Данные добавленны");
            }
            else
            {
                refreshClient();
                MessageBox.Show("Данные отредактированы");
            }
            try
            {
                DBConnect.Entities.SaveChanges();
            } catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {

                        MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                        MessageBox.Show("");

                        foreach (DbValidationError err in validationError.ValidationErrors)
                        {
                        MessageBox.Show(err.ErrorMessage + "");
                        }
                }
            }
            setDGVDatasourse();
        }
        private void refreshClient()
        {
            client.surname = surnameBox.Text;
            client.name = nameBox.Text;
            client.last_name = lastNameBox.Text;
            client.birthday = birthday.Value;
        }

        private void addVisa_Click(object sender, EventArgs e)
        {
            visa v = new visa { date_of_issue = DateTime.Now, expirition_date = DateTime.Now };
            VisaForm visaForm = new VisaForm(v);
            visaForm.ShowDialog();
            client.visas.Add(v);
            setDGVDatasourse();
        }

        private void addPassport_Click(object sender, EventArgs e)
        {
            international_passports ip = new international_passports { date_of_issue = DateTime.Now, expirition_date = DateTime.Now };
            InternationalPassportForm passportForm = new InternationalPassportForm(ip);
            passportForm.ShowDialog();
            client.international_passports.Add(ip);
            setDGVDatasourse();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (client.id > 0)
            {
                List<visa> visaList = DBConnect.Entities.visas.ToList();
                visaList.ForEach(delegate (visa v) {
                    if (v.client_id == client.id) 
                        DBConnect.Entities.visas.Remove(v);
                });

                List<international_passports> passportList 
                    = DBConnect.Entities.international_passports.ToList();
                passportList.ForEach(delegate (international_passports ip) {
                    if (ip.client_id == client.id) 
                        DBConnect.Entities.international_passports.Remove(ip);
                });

                DBConnect.Entities.clients.Remove(client);
                DBConnect.Entities.SaveChanges();
            }
            this.Close();
        }
    }
}
