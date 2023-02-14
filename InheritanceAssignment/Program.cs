using System;

namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new  student(101, "Sravya", "vzm", 92534566760, "B.tech ", 93, "A", 65000);
            Console.WriteLine("Student Information:");
            s.details();
            Console.WriteLine();

            teachingstaff t = new teachingstaff(201, "hari", "vishakapatnam", 3464576398, "professor", 100000, "M.tech", "English");
            Console.WriteLine("Teaching Staff Information:");
            t.details();
            Console.WriteLine();

            nonteachingstaff nt = new nonteachingstaff(202, "anji", "sklm", 3468570086, "lab technician", 10000, "b.tech", "Electonic and communication", 2929);
            Console.WriteLine("Non teaching staff Information:");
            nt.details();
            Console.WriteLine();
        }
    }
}
