namespace pr3_CompanyHierarchy.Classes
{
    using System;
    using Interfaces;

    public abstract class Person:IPerson
    {
        private string _firstName;
        private string _lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (value != null)
                {
                    this._firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("First Name" + "Could not be null");
                }
            }
        }

        public string LastName
        {
            get { return this._lastName; }
            set
            {
                if (value != null)
                {
                    this._lastName = value;
                }
                else
                {
                    throw new ArgumentNullException("Last Name" + "Could not be null");
                }
            }
        }

        public override string ToString()
        {
            var result = string.Format("Obgect:{3} Id: {0}, FullName: {1} {2}", this.Id, this.FirstName, this.LastName, this.GetType().Name);
            return result;
        }
    }
}
