using System;
public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private double? ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private double? price;

    public Laptop(string model, string manufacturer, string processor = null, double? ram = null, string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null, double? price = null)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Laptop model is required");
            }
            else if (value.Trim() == "")
            {
                throw new ArgumentException("laptop model could not be an empty string", "model");
            }
            else
            {
                this.model = value;
            }
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Laptop manufacturer is required");
            }
            else if (value.Trim() == "")
            {
                throw new ArgumentException("laptop manufacturer could not be an empty string", "manufacturer");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value!=null && value.Trim() == "")
            {
                throw new ArgumentException("laptop processor could not be an empty string", "processor");
            }
            else
            {
                this.processor = value;
            }
        }
    }
    public double? Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("RAM should be a positive number", "RAM");
            }
            else
            {
                this.ram = value;
            }
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("laptop graphicsCard could not be an empty string", "graphicsCard");
            }
            else
            {
                this.graphicsCard = value;
            }
        }
    }
    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("laptop HDD could not be an empty string", "HDD");
            }
            else
            {
                this.hdd = value;
            }
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("laptop screen could not be an empty string", "screen");
            }
            else
            {
                this.screen = value;
            }
        }
    }
    public double? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("RAM price be a positive number", "price");
            }
            else
            {
                this.price = value;
            }
        }
    }
    public Battery Battery { get; set; }
    
    public override string ToString()
    {
        string result = string.Format(" Model: {0}, Manufacturer: {1}", this.Model, this.Manufacturer);
        if (this.Processor!=null)
        {
            result = result + ", Processor: " + this.Processor;
        }
        if (this.Ram != null)
        {
            result = result + ", Ram: " + this.Ram + " GB";
        }
        if (this.GraphicsCard != null)
        {
            result = result + ", GraphicsCard: " + this.GraphicsCard;
        }
        if (this.Hdd != null)
        {
            result = result + ", Hdd: " + this.Hdd;
        }
        if (this.Screen != null)
        {
            result = result + ", Screen: " + this.Screen;
        }
        if (Battery != null && Battery.BatteryType != null)
        {
            result = result + ", BatteryType: " + Battery.BatteryType;
        }
        if (Battery != null && Battery.BatteryLife != null)
        {
            result = result + ", BatteryLife: " + Battery.BatteryLife + " hours";
        }
        if (this.Price != null)
        {
            result = result + ", Price: " + this.Price + " lv.";
        }
        return result;
    }
}

