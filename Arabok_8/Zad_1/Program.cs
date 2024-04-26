using System;
using System.Linq;

// Определение структуры STUDENT
struct STUDENT
{
    public string SurnameAndInitials;
    public int GroupNumber;
    public int[] Grades;
}

class Program
{
    static void Main()
    {
        STUDENT[] students = new STUDENT[2];

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Введите данные для студента {i + 1}:");

            Console.Write("Фамилия и инициалы: ");
            students[i].SurnameAndInitials = Console.ReadLine();

            Console.Write("Номер группы: ");
            students[i].GroupNumber = int.Parse(Console.ReadLine());

            students[i].Grades = new int[5];
            for (int j = 0; j < students[i].Grades.Length; j++)
            {
                Console.Write($"Оценка {j + 1}: ");
                students[i].Grades[j] = int.Parse(Console.ReadLine());
            }
        }

        Array.Sort(students, (a, b) => a.SurnameAndInitials.CompareTo(b.SurnameAndInitials));

        bool found = false;
        foreach (var student in students)
        {
            if (student.Grades.Contains(2))
            {
                Console.WriteLine($"Студент: {student.SurnameAndInitials}, Группа: {student.GroupNumber}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Нет студентов с оценкой 2.");
        }
    }
}
