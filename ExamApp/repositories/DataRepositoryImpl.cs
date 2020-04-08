using System;
using System.IO;
using ExamApp.database;
using System.ComponentModel;

namespace ExamApp.repositories
{
    public class DataRepositoryImpl : DataRepository
    {
        private const String PATH = "..\\..\\database\\DataBase.txt";
        private const char DELIMETR = ';';
        private FileStream fileStream;

        private bool isConnected = false;

        public void connectToDatabase()
        {
            if (File.Exists(PATH)&&!isConnected)
            {
                isConnected = true;
            }
            else if(!isConnected)
            {
                File.Create(PATH);
            }
        }
        public void addEntity(Entity entity)
        {
            File.AppendAllText(PATH, entity.Id + DELIMETR + entity.FirstName + DELIMETR + entity.SecondName
                + DELIMETR + entity.LastName + DELIMETR + entity.Age + DELIMETR + entity.Department + DELIMETR
                + entity.Arrival + DELIMETR + entity.Visa + "\n");
        }

        public void editEntity(BindingList<Entity> bList)
        {
            File.Delete(PATH);
            foreach (Entity entity in bList)
            {
                File.AppendAllText(PATH, entity.Id + DELIMETR + entity.FirstName + DELIMETR + entity.SecondName
                + DELIMETR + entity.LastName + DELIMETR + entity.Age + DELIMETR + entity.Department + DELIMETR
                + entity.Arrival + DELIMETR + entity.Visa + "\n");
            }
        }

        public void removeEntity(BindingList<Entity> bList)
        {
            File.Delete(PATH);
            foreach (Entity entity in bList)
            {
                File.AppendAllText(PATH, entity.Id + DELIMETR + entity.FirstName + DELIMETR + entity.SecondName
                + DELIMETR + entity.LastName + DELIMETR + entity.Age + DELIMETR + entity.Department + DELIMETR
                + entity.Arrival + DELIMETR + entity.Visa + "\n");
            }
        }
        public BindingList<Entity> getBindingList()
        {
            fileStream = new FileStream(PATH, FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            BindingList<Entity> bL = new BindingList<Entity>();
            String str1 = String.Empty; 
            while ((str1 = sR.ReadLine()) != null && str1 != String.Empty)
            {
                String [] str = str1.Split(DELIMETR);
                bL.Add(new Entity(str));
            }
            sR.Close();
            fileStream.Close();
            return bL;
        }
        public String showAllData()
        {
            throw new NotImplementedException();
        }

        
    }
}
