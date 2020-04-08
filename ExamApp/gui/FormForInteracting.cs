using ExamApp.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp.gui.images
{
    public partial class FormForInteracting : Form
    {
        private BindingList<Entity> bList;
        private DataRepository dataRepository;
        private Entity entity;
        private int entityID;
        private int entityIndex;
        private bool isForUpdate = false;

        public FormForInteracting(BindingList<Entity> bList, DataRepository dataRepository)
        {
            InitializeComponent();
            this.bList = bList;
            this.dataRepository = dataRepository;
        }
        //for editing
        public FormForInteracting(BindingList<Entity> bList, DataRepository dataRepository, int entityID)
        {
            InitializeComponent();
            this.bList = bList;
            this.dataRepository = dataRepository;
            this.entityID = entityID;
            this.isForUpdate = true;
            fillBoxes(entityID);
        }
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (isForUpdate) editEntity();
            else addEntity();       
        }
        private void addEntity()
        {
            Entity entity = new Entity(Convert.ToString(bList.Count), surnameBox.Text, nameBox.Text, lastNameBox.Text, ageBox.Text, departmentBox.Text, arrivalBox.Text, visaBox.Text);
            bList.Add(entity);
            dataRepository.addEntity(entity);
            clearBoxes();
        }
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

        private void deleteButtonListener(object sender, EventArgs e)
        {
            if (isForUpdate) deleteEntity();
            else clearBoxes();
        }
        private void deleteEntity()
        {
            bList.RemoveAt(Convert.ToInt32(entityID));
            dataRepository.removeEntity(bList);
            clearBoxes();
            this.Close();
        } 
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
