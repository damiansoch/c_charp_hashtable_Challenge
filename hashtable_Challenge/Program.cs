using System;
using System.Collections;

namespace hashtable_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[6];
            students[0] = new Student(1, "Olaf", 98);
            students[1] = new Student(2, "Ana", 76);
            students[2] = new Student(3, "Brad", 90);
            students[3] = new Student(4, "John", 91);
            students[4] = new Student(5, "Gienek", 92);
            students[5] = new Student(5, "Gienek", 92);

            Hashtable studentsTable = new Hashtable();

            for (int i = 0; i < students.Length; i++)
            {
                if (studentsTable.ContainsKey(students[i].Id))
                {
                    Console.WriteLine("student with the Id of {0} already exists", students[i].Id);
                    continue;
                }
                studentsTable.Add(students[i].Id, students[i]);

            }

            foreach (Student entry in studentsTable.Values)
            {
                Console.WriteLine("2) id:{0}, name:{1}, GPA: {2}", entry.Id, entry.Name, entry.GPA);
            }
            Console.ReadLine();
        }
    }
}

