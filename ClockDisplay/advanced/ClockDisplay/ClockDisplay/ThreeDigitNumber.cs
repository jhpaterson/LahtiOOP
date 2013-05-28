
namespace ClockDisplay
{
    // <summary>
    /// represents a component of a clock time able to display three digits
    /// e.g. thousandths of a second
    /// </summary>
    public class ThreeDigitNumber : Number
    {

         /// <summary>
         /// the maximum value allowed for this time component
         /// </summary>
         public override int Limit
         {
             get { return limit; }
             set
             {
                 if ((value >= 0) && (value <= 1000))
                 {
                     this.limit = value;
                 }
             }
         }

        /// <summary>
        /// constructor for a Number object
        /// </summary>
        /// <param name="limit">the maximum value allowed for this time component</param>
        public ThreeDigitNumber(int limit) : base(limit)
        {
        }

        /// <summary>
        /// returns the current value as a string 
        /// </summary>
        /// <returns>the current value</returns>
        public override string GetDisplayValue()
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
}
