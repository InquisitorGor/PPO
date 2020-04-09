using ExamApp.database;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ExamApp.gui.images
{
    public partial class FormForInteracting : Form
    {
        private BindingList<Entity> bList;
        private DataRepository dataRepository;
        private Entity entity;
        private int entityID;
        private bool isForUpdate = false; // флаг, определяющий поведение кнопки "Сохранить"

        //конструктор для добавления записи
        public FormForInteracting(BindingList<Entity> bList, DataRepository dataRepository)
        {
            InitializeComponent();
            this.bList = bList;
            this.dataRepository = dataRepository;
        }
        //конструктор для редактирования записи
        public FormForInteracting(BindingList<Entity> bList, DataRepository dataRepository, int entityID)
        {
            InitializeComponent();
            this.bList = bList;
            this.dataRepository = dataRepository;
            this.entityID = entityID;
            this.isForUpdate = true;
            fillBoxes(entityID);
        }
        //метод для заполнения ячеек значениями полученной записи
        private void fillBoxes(int entityID)
        {
            entity = bList.ElementAt(getEntityIndex(entityID));
            surnameBox.Text = entity.SecondName;
            nameBox.Text = entity.FirstName;
            lastNameBox.Text = entity.LastName;
            ageBox.Text = entity.Age;
            arrivalBox.Text = entity.Arrival;
            departmentBox.Text = entity.Department;
            visaBox.Text = entity.Visa;
        }
        //метод для получения индекса записи в рамках коллекции
        private int getEntityIndex(int entityID)
        {
            int i = 0;
            foreach (Entity entity in bList)
            {
                if (entity.Id == Convert.ToString(entityID))
                {
                    return i;
                }
                i++;
            }
            return 0;
        }
        //слушатель для кнопки сохранить
        private void saveButtonListener(object sender, EventArgs e)
        {
            if (isForUpdate) editEntity();  
            else addEntity();       
        }
        //добавление новой записи
        private void addEntity()
        {
            Entity entity = new Entity(Convert.ToString(bList.Count), 
                surnameBox.Text, nameBox.Text, lastNameBox.Text, 
                ageBox.Text, departmentBox.Text, arrivalBox.Text, visaBox.Text);
            bList.Add(entity);
            dataRepository.addEntity(entity);
            clearBoxes();
        }
        //редактирование уже существующей
        private void editEntity()   
        {
            int i = 0;
            foreach (Entity entity in bList)
            {
                if (entity.Id == Convert.ToString(entityID))
                {
                    entity.SecondName = surnameBox.Text;
                    entity.FirstName = nameBox.Text;
                    entity.LastName = lastNameBox.Text;
                    entity.Age = ageBox.Text;
                    entity.Arrival = arrivalBox.Text;
                    entity.Department = departmentBox.Text;
                    entity.Visa = visaBox.Text;
                    bList.RemoveAt(i);
                    bList.Insert(i, entity);
                    dataRepository.editEntity(bList);
                    break;
                }
                i++;
            }

        }
        //слушатель кнопки удалить
        private void deleteButtonListener(object sender, EventArgs e)
        {
            if (isForUpdate) deleteEntity();
            else clearBoxes();
        }
        //удаление записи
        private void deleteEntity()
        {
            bList.RemoveAt(Convert.ToInt32(getEntityIndex(entityID)));
            dataRepository.removeEntity(bList);
            clearBoxes();
            this.Close();
        } 
        //отчистка ячеек
        private void clearBoxes()
        {
            surnameBox.Clear();
            nameBox.Clear();
            lastNameBox.Clear();
            ageBox.Clear();
            departmentBox.Clear();
            arrivalBox.Clear();
            visaBox.Clear();
        }
    }
}
