namespace Pr2
{
    using System;
    using System.Collections.Generic;

    public class Customer: ICloneable,IComparable<Customer>
    {
       public Customer(string firstName, string middleName, string lastName, int id, string pernAddress, string phone, string email, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = pernAddress;
            this.Phone = phone;
            this.Email = email;
            this.CustomerType = customerType;
            this.Payments = new List<Payment>();

        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public CustomerType CustomerType { get; set; }


        public void AddPayment(params Payment[] payment)
        {
            foreach (var pmnt in payment)
            {
                this.Payments.Add(pmnt);
            }
        }

        public int CompareTo(Customer other)
        {
            return this.FirstName != other.FirstName ? String.Compare(this.FirstName, other.FirstName, StringComparison.Ordinal) : this.Id.CompareTo(other.Id);
        }

        public object Clone()
        {
            var newCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Address,
                this.Phone,
                this.Email,
                this.CustomerType);

            foreach (var payment in this.Payments)
            {
                newCustomer.AddPayment(payment);
            }

            return newCustomer;
        }

        public static bool operator ==(Customer furstCusttomer,
                                 Customer secontCustomer)
        {
            return Customer.Equals(furstCusttomer, secontCustomer);
        }
        
        public static bool operator !=(Customer furstCusttomer,
                           Customer secontCustomer)
        {
            return !(Customer.Equals(furstCusttomer, secontCustomer));
        }



        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.Id.GetHashCode();
        }

        public override string ToString()
        {
            string payment = String.Join(")(", this.Payments);
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", this.FirstName, this.MiddleName, this.LastName, this.Id, this.Address, this.Phone, this.Email, this.CustomerType, payment);
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if (customer != null)
            {
                return object.Equals(this.FirstName, customer.FirstName) &&
                       object.Equals(this.LastName, customer.LastName)
                       && object.Equals(this.Id, customer.Id);
            }
            return false;
        }

        

       

       
    }
}
