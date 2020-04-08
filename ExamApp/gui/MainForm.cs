using ExamApp.database;
using ExamApp.gui;
using ExamApp.gui.images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class MainForm : Form
    {
        private readonly DataRepository dataRepository;
        private BindingList<Entity> bList;

        public MainForm(DataRepository dataRepository)
        {
            InitializeComponent();
            this.dataRepository = dataRepository;
            autoConnectToDB();
            dataGridView1.ReadOnly = false;
            setDGVHeaders();     
        }
        private void setDGVHeaders()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Возраст";
            dataGridView1.Columns[5].HeaderText = "Дата отбытия";
            dataGridView1.Columns[6].HeaderText = "Дата прибытья";
            dataGridView1.Columns[7].HeaderText = "Наличие визы";
        }
        private void autoConnectToDB()
        {
            dataRepository.connectToDatabase();
            this.bList = dataRepository.getBindingList();
            dataGridView1.DataSource = bList;
            
            
        }
        private void DataGridView1_CellMouseDoubleClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ID = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            FormForInteracting formForInteracting = new FormForInteracting(bList, dataRepository, Convert.ToInt32(ID));
            formForInteracting.Show();
            formForInteracting.FormClosed += formClosedListener;
        }

        private void formClosedListener(object sender, FormClosedEventArgs e)
        {
            this.textBoxSearch.Clear();
        }

        private void resetButtonListener(object sender, EventArgs e)
        {
            this.textBoxSearch.Clear();
        }
        private void textBoxSearchListener(object sender, EventArgs e)
        {
            filterDGV(textBoxSearch.Text.Trim());
        }
        private void filterDGV (String str)
        {
            BindingList<Entity> newBList = new BindingList<Entity>();
            foreach (Entity en in bList)
            {
                if (en.SecondName.Contains(str)) newBList.Add(en);
            }
            dataGridView1.DataSource = newBList;
            dataGridView1.Update();
        }

        private void createEntity(object sender, EventArgs e)
        {
            new FormForInteracting(bList,dataRepository).Show();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
