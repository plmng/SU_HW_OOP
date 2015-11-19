using System;
using System.Text.RegularExpressions;


public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            else if (value.Trim() == "")
            {
                throw new ArgumentException("Name should not be empty", "name");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value >100)
            {
                throw new ArgumentException("A valud age should be in range [0..100]");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null && !validateEmail(value))
            {
                throw new ArgumentException("Invalid Email");
            }
            else
            {
                this.email = value;
            }
        }
    }
    
    public bool validateEmail(string email)
    {
        Regex regex = new Regex(@"^[0-9A-Za-z_%.]+@[0-9A-Za-z-_]+\.[A-Za-z]+$");
        return regex.IsMatch(email);

    }
    public override string ToString()
    {
        string result = string.Format("Name: {0}, Age: {1}", name, age);
        if (email!=null)
        {
            result = result + string.Format(", Email: {0}", email);
        }
        return result;
    }
}
