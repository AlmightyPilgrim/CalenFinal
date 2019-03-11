using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarMethod
{
    public class CalendarMethod
    {
        public int ScheduleMonth(int month)
        {
            char enter = 'Y';
            bool tracker = true;
            while (tracker == true)
            {
                Console.WriteLine("Which month do you wish to schedule?");
                string select = "Options:\n\t1 - Janurary\n\t2 - February\n\t3 - March\n\t4 - April \n\t5 - May\n\t6 " +
                                "- June\n\t7 - July\n\t8 - August\n\t9 - September\n\t10 - October\n\t11 - November\n\t12" +
                                " - December\nChoice: ";
                Console.WriteLine(select);
                month = int.Parse(Console.ReadLine());
                Console.WriteLine($"{month}, is this the month you wish to enter in?\n\t Options\n\tY - Yes\n\tN - No\nChoice");
                enter = char.Parse(Console.ReadLine());
                tracker = (enter == 'N');
            }
            return month;
        }

        public int ScheduleDay(int month, int date)
        {
            switch (month)
            {
                case 1:
                    switch (date)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            break;
                        case 4:

                            break;
                    }
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
            return date;
        }

    }
}
