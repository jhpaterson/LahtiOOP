
namespace ClockDisplay
{
    /// <summary>
    /// represents a component of a clock time
    /// e.g. hours or minutes
    /// </summary>
    public class Number
    {
        public int limit;
        public int value;


        /// <summary>
        /// constructor for a Number object
        /// </summary>
        /// <param name="limit">the maximum value allowed for this time component</param>
        public Number(int limit)
        {
            this.limit = limit;
            this.value = 0;
        }

        /// <summary>
        /// returns the current value as a string 
        /// </summary>
        /// <returns>the current value</returns>
        public string GetDisplayValue()
        {
            if (limit < 100)
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
            }
            else
            {
                if (value < 10)
                {
                    return string.Format("00{0}", value);
                }
                else if (value < 100)
                {
                    return string.Format("0{0}", value);
                }
                else if (value < 1000)
                {
                    return string.Format("{0}", value);
                }
                else
                {
                    return "###";
                }
            }
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
