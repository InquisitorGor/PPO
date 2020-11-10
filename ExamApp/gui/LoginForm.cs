using ExamApp.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
        }
    }
}
