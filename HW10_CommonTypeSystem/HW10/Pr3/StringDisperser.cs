namespace Pr3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;


    public class StringDisperser:ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        public StringDisperser(params string[] strings)
        {
            this.InputStrings(strings);
        }

        public string ConcatenatedStrings { get; private set; }

        private void InputStrings(IEnumerable<string> inputStrings)
        {
            var result = new StringBuilder();
            foreach (var str in inputStrings)
            {
                result.Append(str);
            }
            this.ConcatenatedStrings = result.ToString();
        }
       
        public object Clone()
        {
            return new StringDisperser(this.ConcatenatedStrings);
        }  

        public int CompareTo(StringDisperser other)
        {
            return string.Compare(this.ConcatenatedStrings, other.ConcatenatedStrings, StringComparison.Ordinal);
        }

        

        public static bool operator ==(StringDisperser strFirst, StringDisperser strSecond)
        {
            return Equals(strFirst, strSecond);
        }

        public static bool operator !=(StringDisperser strFirst, StringDisperser strSecond)
        {
            return !(strFirst == strSecond);
        }
        public IEnumerator<char> GetEnumerator()
        {
            return ((IEnumerable<char>)this.ConcatenatedStrings).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            var str = (StringDisperser)obj;
            return object.Equals(this.ConcatenatedStrings, str.ConcatenatedStrings);
        }

        public override int GetHashCode()
        {
            return this.ConcatenatedStrings.GetHashCode();
        }
        public override string ToString()
        {
            return this.ConcatenatedStrings;
        }

    }
}
