namespace pr4
{
    using System;

    public class PropertyChanged: EventArgs
    {
        public PropertyChanged( dynamic oldValue, dynamic newValue, string property)
        {
            this.Property = property;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string Property { get; private set; }

        public dynamic OldValue { get; private set; }

        public dynamic NewValue { get; private set; }
    }
}
