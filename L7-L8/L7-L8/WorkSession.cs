using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_L8
{
    public class WorkSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan GetRawDuration()
        {
            return EndTime - StartTime;
        }

        public void PrintFormattedDuration()
        {
            TimeSpan duration = GetRawDuration();

            int totalHours = (int)duration.TotalHours;
            int minutes = duration.Minutes;

            Console.WriteLine($"Сессия продлилась: “{totalHours} часа и {minutes} минут”");
        }
    }
}
