using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Yesterday
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        int mounth = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        var dt = new DateTime(year, mounth, day);
        var oneDayBefore = dt.AddDays(-1);
        Console.WriteLine(oneDayBefore.ToString("d-MMM-yyyy"));
    }
}
