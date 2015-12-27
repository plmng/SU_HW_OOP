namespace Problem3and4.GenericListandVersionAttribute
{
    using System.Text;

    [System.AttributeUsage(System.AttributeTargets.Struct |
                           System.AttributeTargets.Class |
                           System.AttributeTargets.Interface |
                           System.AttributeTargets.Enum|
                           System.AttributeTargets.Method,
                           AllowMultiple = true)
]
    public class VersionAttribute : System.Attribute
    {
        private int _major;
        private int _minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        public int Major 
        {
            get
            {
                return this._major;
            }

            private set
            {
                this._major = value;
            }
        }
        public int Minor
        {
            get
            {
                return this._minor;
            }

            private set
            {
                this._minor = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Major + "." + this.Minor);
            return result.ToString();
        }
    }
}
