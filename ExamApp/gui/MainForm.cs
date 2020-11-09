using ExamApp.database;
using ExamApp.gui.images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class MainForm : Form
    {

        

        public MainForm()
        {
            InitializeComponent();
            dataGridView.ReadOnly = true;
            
            setDGVDatasource();
           setDGVHeaders();
        }
        //установка заголовков DGV
        private void setDGVHeaders()
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Фамилия";
            dataGridView.Columns[2].HeaderText = "Имя";
            dataGridView.Columns[3].HeaderText = "Отчество";
            dataGridView.Columns[4].HeaderText = "Дата рождения";
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
        }

        private void setDGVDatasource()
        {
            //var data = (from s in DBConnect.Entities.clients
            //            join v in DBConnect.Entities.visas on s.id equals v.client_id
            //            join ip in DBConnect.Entities.international_passports on s.id equals ip.client_id
            //            select new
            //            {
            //                s.id, s.name, s.surname, s.last_name,
            //                visa_number = v.number, visa_date_of_issue = v.date_of_issue, visa_expiration_date = v.expirition_date,
            //                ip_number = ip.number, ip_date_of_issue = ip.date_of_issue, ip_expiration_date = ip.expirition_date, ip.country.country1
            //            }
            //            ).ToList();
            this.dataGridView.DataSource = DBConnect.Entities.clients.ToList();

        }

        //слушатель для DGV
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; };
            client c = dataGridView.Rows[e.RowIndex].DataBoundItem as client;
            FormForInteracting form = new FormForInteracting(c);
            form.ShowDialog();
            setDGVDatasource();

        }
        //слушатель для сброса фильтра при закрытии формы
        private void formClosedListener(object sender, FormClosedEventArgs e)
        {
            this.textBoxSearch.Clear();
        }
        //слушатель кнопки "Сброс"
        private void resetButtonListener(object sender, EventArgs e)
        {
            this.textBoxSearch.Clear();
        }
        //слушатель для фильтра
        private void textBoxSearchListener(object sender, EventArgs e)
        {
            filterDGV(textBoxSearch.Text.Trim());
        }
        // динамическая фильтрация DGV
        private void filterDGV (String str)
        {
       
            //dataGridView.DataSource
            dataGridView.Update();
        }
        //слушатель кнопки "Добавить"
        private void createEntityListener(object sender, EventArgs e)
        {
            //new FormForInteracting().Show();
            dataGridView.Update();
            dataGridView.Refresh();
        }

        
    }
}
