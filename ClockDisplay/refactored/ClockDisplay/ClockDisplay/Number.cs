
namespace ClockDisplay
{
    /// <summary>
    /// represents a component of a clock time
    /// e.g. hours or minutes or seconds
    /// </summary>
    public class Number
    {
        protected int limit;
        protected int value;

        public virtual int Limit
        {
            get { return limit; }
            set
            {
                if ((value >= 0) && (value <= 100))
                {
                    this.limit = value;
                }
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
        public virtual string GetDisplayValue()
        {
            if (value < 10)
            {
                return string.Format("0{0}", value);
            }
            else if (value < 100)
            {
                return string.Format("{0}", value);
            }
            else
            {
                return "##";
            }

            //return string.Format("{0:00}", value);      // simpler solution using custom text format
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
