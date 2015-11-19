using System;

public class Battery
{
    private string batteryType;
    private double? batteryLife;
    public Battery(string batteryType = null, double? batteryLife = null)
    {
        this.BatteryType = batteryType;
        this.BatteryLife = batteryLife;
    }
    public string BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("Battery type could not be an empty string", "battery type");
            }
            this.batteryType = value;
        }
    }
    public double? BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Battery life should be a positive number");
            }
            this.batteryLife = value;
        }
    }
    
}

