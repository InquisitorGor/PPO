
using ExamApp.database;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ExamApp.gui.images
{
    public partial class FormForInteracting : Form
    {
        
        private client client { get; }

        private bool isShown { get; }


        public FormForInteracting(client client)
        {
            InitializeComponent();
            this.client = client;
            isShown = false;
            fillBoxes();
            setDGVDatasourse();
            setDGVHeaders();
            isShown = true;

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            if (client.id <= 0)
            {
                DBConnect.Entities.clients.Add(client);
            }
            else
            {
                refreshClient();
                DBConnect.Entities.SaveChanges();
                setDGVDatasourse();
                MessageBox.Show("Данные сохранены");
            }
        }
        private void refreshClient()
        {
            client.surname = surnameBox.Text;
            client.name = nameBox.Text;
            client.last_name = lastNameBox.Text;
            client.birthday = birthday.Value;
        }
    }
}
