using ExamApp.database;
using ExamApp.gui;
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
            setConnection();
            dataGridView.ReadOnly = true;
            setDGVDatasource();
            setDGVHeaders();
            this.Visible = true;
        }

        private void setConnection()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
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
        //слушатель для фильтра
        private void textBoxSearchListener(object sender, EventArgs e)
        {
            filterDGV(textBoxSearch.Text.Trim());
        }
        // динамическая фильтрация DGV
        private void filterDGV (String str)
        {
            dataGridView.DataSource = (DBConnect.Entities.clients.ToList()).Where(x => x.surname.StartsWith(str)).ToList();
            dataGridView.Update();
        }
        //слушатель кнопки "Добавить"
        private void createEntityListener(object sender, EventArgs e)
        {
            client c = new client { birthday = DateTime.Now };
            FormForInteracting form = new FormForInteracting(c);
            form.ShowDialog();
            setDGVDatasource();
        }

        
    }
}
