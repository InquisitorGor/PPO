using ExamApp.database;
using System.ComponentModel;

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
