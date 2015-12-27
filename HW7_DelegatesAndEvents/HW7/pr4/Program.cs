namespace pr4
{
    using System;
    using System.ComponentModel;

    public class Program
    {
        private static void Main()
        {

            var st = new Student("Dragan", 20);



            st.OnPropertyChanged += (sender, eventArgs) =>
                Console.WriteLine("Property  cnaged: {0} (from {1} to {2})",
                    eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);


            st.Name = "Petkancho";
            st.Age = 2;


        }
    }
}
