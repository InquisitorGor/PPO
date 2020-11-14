using ExamApp.database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ExamApp.gui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void connectButton(object sender, EventArgs e)
        {
            String login = loginBox.Text;
            String password = passwordBox.Text;


            SqlConnectionStringBuilder c = new SqlConnectionStringBuilder
            {
                DataSource = @"desktop-9kjr25d\sqlexpress",
                InitialCatalog = "exam_bd",
                IntegratedSecurity = false,
                Password = password,
                UserID = login
            };
            DBConnect.Entities = new EgorEntities(c.ConnectionString);

            try
            {
                List <visa> testConnection = DBConnect.Entities.visas.ToList();
                this.Close();
            } catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show("Данные невалидные");
            }

            
        }
    }
}
