using ExamApp.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public interface DataRepository
    {
        void connectToDatabase();
        void addEntity(Entity entity);
        void editEntity(BindingList<Entity> bList);
        void removeEntity(BindingList<Entity> bList);
        BindingList<Entity> getBindingList();
       
    }
}
