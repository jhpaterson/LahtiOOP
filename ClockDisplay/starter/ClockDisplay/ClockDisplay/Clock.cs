
namespace ClockDisplay
{
    /// <summary>
    /// represents a clock 
    /// can return its time as a string which can be
    /// displayed in a user interface
    /// </summary>
    public class Clock
    {
        private Number hours;
        private Number minutes;
        public string displayString;

        /// <summary>
        /// constructor for a Clock object
        /// </summary>
        public Clock()
        {
            hours = new Number(24);
            minutes = new Number(60);
            UpdateDisplay();
        }

        /// <summary>
        /// updates time by incrementing minutes 
        /// calculates new values for hours and minutes
        /// then updates display string
        /// </summary>
        public void TimeTick()
        {
            minutes.Increment();
            if (minutes.value == 0)
            {
                hours.Increment();
            }
            UpdateDisplay();
        }

        /// <summary>
        /// updates display string to show current hours and minutes values
        /// </summary>
        private void UpdateDisplay()
        {
            displayString = string.Format("{0}:{1}", hours.GetDisplayValue(), minutes.GetDisplayValue());
        }

        

        /// <summary>
        /// resets the time to 00:00 
        /// (not yet implemented)
        /// </summary>
        public void Reset()
        {
        }
    }
}
