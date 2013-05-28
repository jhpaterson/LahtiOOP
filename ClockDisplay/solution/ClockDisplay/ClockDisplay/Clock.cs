﻿
namespace ClockDisplay
{
    /// <summary>
    /// represents a clock 
    /// can return its time as a string which can be
    /// displayed in a user interface
    /// </summary>
    public class Clock
    {
        private Number minutes;
        private Number seconds;
        private Number thousandths;
        public string displayString;


        /// <summary>
        /// constructor for a Clock object
        /// </summary>
        public Clock()
        {
            minutes = new Number(60);
            seconds = new Number(60);
            thousandths = new Number(1000);
            UpdateDisplay();
        }

        /// <summary>
        /// updates time by incrementing minutes 
        /// calculates new values for hours and minutes
        /// then updates display string
        /// </summary>
        public void TimeTick()
        {
            thousandths.Increment();
            if (thousandths.value == 0)
            {
                seconds.Increment();
                if (seconds.value == 0)
                {
                    minutes.Increment();
                }
            }
            UpdateDisplay();
        }

        /// <summary>
        /// updates display string to show current hours and minutes values
        /// </summary>
        private void UpdateDisplay()
        {
            displayString = string.Format("{0}:{1}.{2}", 
                minutes.GetDisplayValue(),
                seconds.GetDisplayValue(),
                thousandths.GetDisplayValue());
        }

        /// <summary>
        /// resets the time to zero
        /// </summary>
        public void Reset()
        {
            minutes.value = 0;
            seconds.value = 0;
            thousandths.value = 0;
            UpdateDisplay();
        }
    }
}
