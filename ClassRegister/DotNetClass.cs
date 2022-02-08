using System;

namespace ClassRegister
{
    public class DotNetClass 
    {
        public DotNetClass(Student[] students)
        {
            Students = students;
            ClassSize = students.Length;
        }

        public int ClassSize { get; }
        public Student[] Students { get; }

        public void PrintClassDetails()
        {
            foreach (Student dev in Students)
            {
                Console.WriteLine(dev.ToString());
            }
        }
    }
}