using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] timeSeparate = Console.ReadLine().Split(':');

                int timeHour = int.Parse(timeSeparate[0]);
                int timeMinute = int.Parse(timeSeparate[1]);

                Console.Clear();

                string hour = null;

                string minute = null;

                for (int i = 0; i <= timeHour; i++)
                {
                    hour = i.ToString();
                    int count = 0;

                    for (int j = 0; j < 60; j++)
                    {
                        if (i == timeHour && j > timeMinute)
                        {
                            break;
                        }

                        count++;

                        minute = j.ToString();
                        if (j < 10)
                        {
                            minute = string.Concat("0", minute);
                        }

                        Console.Write(hour + ":" + minute + " ");

                        if (count % 7 == 0)
                        {
                            Console.Write("\n");
                        }
                    }
                    Console.Write("\n");
                }
                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
        }
    }
}
