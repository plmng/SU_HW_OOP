using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
   public class Student
    {
        public delegate void PropertyChangedEventHendlerer(object sender, PropertyChanged eventArgs);
        public event PropertyChangedEventHendlerer OnPropertyChanged;

        private string _name;
        private int _age;
       
        public Student(string name, int age)
        {

            this.Name = name;
            this.Age = age;
        }

        public string Name {
            get { return this._name; }
            set
            {
                this.IsPropertyChanged(this._name, value, "Name");
                this._name = value;
            }
        }

       public int Age
       {
           get { return this._age; }
           set
           {
               this.IsPropertyChanged(this._age, value, "Age");
               this._age = value;
           }
       }

        private void IsPropertyChanged(dynamic oldValue, dynamic newValue, string prop)
        {

            if (this.OnPropertyChanged != null)
            {

                OnPropertyChanged(this, new PropertyChanged(oldValue, newValue, prop));
            }
        }

    }
}
