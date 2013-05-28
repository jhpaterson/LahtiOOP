using System;
using System.Text;

namespace ClockDisplay
{
    /// <summary>
    /// represents a component of a clock time
    /// e.g. hours or minutes or seconds
    /// </summary>
    public class Number
    {
        private int limit;
        private int value;
        private string displayFormat;

        public int Limit
        {
            get { return limit; }
            set
            {
                this.limit = value;
                if (limit < 2)
                    limit = 2;       // can't have limit < 2, limit=2 works for binary 

                // calculate number of digits 
                double log10 = Math.Log10((double)(limit - 1));    
                int digits = (int)log10 + 1;     // casting double to int rounds down

                // set custom format from number of digits
                StringBuilder sb = new StringBuilder("{0:");
                for (int i = 0; i < digits; i++)
                {
                    sb.Append("0");
                }
                sb.Append("}");
                displayFormat = sb.ToString();
            }
        }

        /// <summary>
        /// the current value for this time component
        /// </summary>
        public int Value
        {
            get { return this.value; }
            set
            {
                if ((value >= 0) && (value < limit))
                {
                    this.value = value;
                }
            }
        }

        /// <summary>
        /// constructor for a Number object
        /// </summary>
        /// <param name="limit">the maximum value allowed for this time component</param>
        public Number(int limit)
        {
            this.Limit = limit;
            this.Value = 0;
        }

        /// <summary>
        /// returns the current value as a string 
        /// </summary>
        /// <returns>the current value</returns>
        public string GetDisplayValue()
        {
            return string.Format(displayFormat, value);
        }

        /// <summary>
        /// move the time value on by one unit
        /// </summary>
        public void Increment()
        {
            value = (value + 1) % limit;
        }
    }
}
