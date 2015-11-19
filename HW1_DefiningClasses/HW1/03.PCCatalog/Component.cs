using System;
class Component
{
    private string name;
    private string compomentDetails;
    private double price;

    public Component(string name, double price, string componentdetails = null)
    {
        this.Name = name;
        this.Price = price;
        this.CompomentDetails = componentdetails;
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
                throw new ArgumentNullException("Parameter Component Name is required");
            }
            else if (value.Trim() == "")
            {
                throw new ArgumentException("Component Name cannot be an empty string");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("the prive cannot ne negative", "price");
            }
            else
            {
                this.price = value;
            }
        }
    }
    public string CompomentDetails
    {
        get { return this.compomentDetails; }
        set
        {
            if (value !=null && value.Trim() == "")
            {
                throw new ArgumentException("Compoment Details shoudl not be an empty string");
            }
            else
            {
                this.compomentDetails = value;
            }
        }
    }
}

