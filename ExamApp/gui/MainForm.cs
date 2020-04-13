using ExamApp.database;
using ExamApp.gui.images;
using System;
using System.ComponentModel;
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
            dataGridView.ReadOnly = true;
            setDGVHeaders();     
        }
        //установка заголовков DGV
        private void setDGVHeaders()
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Фамилия";
            dataGridView.Columns[2].HeaderText = "Имя";
            dataGridView.Columns[3].HeaderText = "Отчество";
            dataGridView.Columns[4].HeaderText = "Возраст";
            dataGridView.Columns[5].HeaderText = "Дата отбытия";
            dataGridView.Columns[6].HeaderText = "Дата прибытья";
            dataGridView.Columns[7].HeaderText = "Наличие визы";
        }
        //соединение с БД
        private void autoConnectToDB()
        {
            dataRepository.connectToDatabase();
            this.bList = dataRepository.getBindingList();
            dataGridView.DataSource = bList;
            
            
        }
        //слушатель для DGV
        private void DataGridViewCellMouseDoubleClickListener(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ID = (dataGridView.Rows[e.RowIndex].Cells[0].Value).ToString();
            FormForInteracting formForInteracting = new FormForInteracting(bList, dataRepository, Convert.ToInt32(ID));
            formForInteracting.Show();
            formForInteracting.FormClosed += formClosedListener;
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
            BindingList<Entity> newBList = new BindingList<Entity>();
            foreach (Entity en in bList)
            {
                if (en.SecondName.Contains(str)) newBList.Add(en);
            }
            dataGridView.DataSource = newBList;
            dataGridView.Update();
        }
        //слушатель кнопки "Добавить"
        private void createEntityListener(object sender, EventArgs e)
        {
            new FormForInteracting(bList,dataRepository).Show();
            dataGridView.Update();
            dataGridView.Refresh();
        }
    }
}
