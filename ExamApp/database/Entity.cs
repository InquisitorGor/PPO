using System;

namespace ExamApp.database
{
    public class Entity
    {
        private String id;
        private String secondName;
        private String firstName;    
        private String lastName;
        private String age;
        private String department;
        private String arrival;
        private String visa;

        

        public Entity(string id, string firstName, string secondName, string lastName, string age, string department, string arrival, string visa)
        {
            this.Id = id;
            this.SecondName = secondName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Department = department;
            this.Arrival = arrival;
            this.Visa = visa;
        }
        public Entity(String[] str)
        {
            this.Id = str[0];
            this.SecondName = str[1];
            this.FirstName = str[2];
            this.LastName = str[3];
            this.Age = str[4];
            this.Department = str[5];
            this.Arrival = str[6];
            this.Visa = str[7];
        }
        public string Id { get => id; set => id = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Age { get => age; set => age = value; }
        public string Department { get => department; set => department = value; }
        public string Arrival { get => arrival; set => arrival = value; }
        public string Visa { get => visa; set => visa = value; }
    }
}
