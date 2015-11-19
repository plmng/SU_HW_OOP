using System;
using System.Collections.Generic;

class Computer
{
    private string name;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
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

    public List<Component> Components { get; set; }

    public double Price
    {
        get
        {
            return CalcComputerPrice();
        }

    }

    public double CalcComputerPrice()
    {
        double totalPrice = 0; ;
        foreach (var component in Components)
        {
            totalPrice = totalPrice + component.Price;
        }
        return totalPrice;
    }
    public override string ToString()
    {
        string result = "Computer Name: " + this.Name;
        foreach (var component in Components)
        {
            result = result + ", Component Name: " + component.Name + ", Component Price: " + component.Price;
        }
        result = result + ", Total Price: " + this.Price;
        return result;
    }
}

