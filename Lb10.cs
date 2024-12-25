/*06.12
    1
    класс которой имеет 2 поля 
    тип инт (описание либо свойства)
    три конструктора 
    1 инициализирует в 0 если параметров нет
    2 один параметр первое инициализирует а пустое в 0
    3 оба параметра инициализируется 
    четырее метода 
    1 сложение двух перменных
    2 вычитание из первого второй 
    3 деление 
    4 умножение 
    в майне создание трех объектов 
    для каждого объекта используем свои методы ((а,б),(б,а))- разность 

    2
    Создать массив из заданного количества объектов класса студент. Класс студент: ФИО (можно одно поле, можно разбить на три поля), год рождения, курс. (конструктор на инициализацию всех полей)
Реализовать меню, в котором пункты:
1.	Заполнение
2.	Модификация по ФИО
3.	Запрос1(вывод всех данных о студентах, заданного курса)
4.	Запрос2(вывод всех данных о студентах, рожденных в заданный год)
5.	Выход
После выбора и выполнения пункта меню, пользователь должен попадать обратно на меню, с возможностью выбора другого действия.
Предусмотреть обработку ошибки выбора пункта 2, 3, 4 при отсутствие данных. (выдать сообщение, что данных нет)


1.
using Microsoft.VisualBasic;
using System;

namespace programm1
{
    class Peremen
    {
        public int X;
        public int Y;
        public Peremen() { X = 0; Y = 0; }
        public Peremen(int x) { X = x; Y = 0; }
        public Peremen(int x, int y) { X = x; Y = y; }
        public void Print()
        {
            Console.WriteLine($"Первая переменная: {X} Вторая переменная: {Y}");
        }
        public void Sum()
        {
            int result = X + Y;
            Console.WriteLine($" {X}+{Y} = {result}");
        }
        public void Subt()
        {
            int result = X - Y, result1 = Y - X;
            Console.WriteLine($" {X}-{Y} = {result}");
            Console.WriteLine($" {Y}-{X} = {result1}");
        }
        public void Div()
        {
            if (Y == 0)
            {
                Console.WriteLine(" Нельзя делить на ноль!");
            }
            else
            {
                double result = X / Y;
                Console.WriteLine($" {X}/{Y} = {result}");
            }
        }
        public void Multip()
        {
            int result = X * Y;
            Console.WriteLine($" {X}*{Y} = {result}");
        }
        public static void Main()
        {
            Peremen One = new Peremen();
            Peremen Two = new Peremen(3);
            Peremen Three = new Peremen(66, 6);

            Three.Print();

            Three.Sum();
            Three.Subt();
            Three.Div();
            Three.Multip();

            Two.Print();

            Two.Sum();
            Two.Subt();
            Two.Div();
            Two.Multip();

            One.Print();

            One.Sum();
            One.Subt();
            One.Div();
            One.Multip();
        }
    }

    
}

   

2
using System;
using System.Collections.Generic;

class Student
{
    public string FullName { get; set; }
    public int BirthYear { get; set; }
    public int Course { get; set; }

    public Student(string fullName, int birthYear, int course)
    {
        FullName = fullName;
        BirthYear = birthYear;
        Course = course;
    }

    public override string ToString()
    {
        return $"ФИО: {FullName}, Год рождения: {BirthYear}, Курс: {Course}";
    }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Заполнение");
            Console.WriteLine("2. Модификация по ФИО");
            Console.WriteLine("3. Запрос1 (вывод всех данных о студентах, заданного курса)");
            Console.WriteLine("4. Запрос2 (вывод всех данных о студентах, рожденных в заданный год)");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите пункт меню: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FillStudents();
                    break;
                case "2":
                    ModifyByFullName();
                    break;
                case "3":
                    QueryByCourse();
                    break;
                case "4":
                    QueryByBirthYear();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный выбор! Попробуйте снова.");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void FillStudents()
    {
        Console.Write("Введите количество студентов для добавления: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Студент {i + 1}:");
                Console.Write("ФИО: ");
                string fullName = Console.ReadLine();
                Console.Write("Год рождения: ");
                int birthYear = int.Parse(Console.ReadLine());
                Console.Write("Курс: ");
                int course = int.Parse(Console.ReadLine());

                students.Add(new Student(fullName, birthYear, course));
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введите положительное целое число.");
        }
    }

    static void ModifyByFullName()
    {
        Console.Write("Введите ФИО студента для модификации: ");
        string fullName = Console.ReadLine();
        var student = students.Find(s => s.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));

        if (student != null)
        {
            Console.WriteLine("Студент найден. Введите новые данные:");
            Console.Write("Новый год рождения: ");
            student.BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Новый курс: ");
            student.Course = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Студент с таким ФИО не найден.");
        }
    }

    static void QueryByCourse()
    {
        Console.Write("Введите курс для запроса: ");
        int course;
        if (int.TryParse(Console.ReadLine(), out course))
        {
            var result = students.FindAll(s => s.Course == course);

            if (result.Count > 0)
            {
                Console.WriteLine($"Студенты на {course}-м курсе:");
                foreach (var student in result)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Студенты на данном курсе не найдены.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода курса.");
         }

    }
    static void QueryByBirthYear()
    {
        Console.Write("Введите год для запроса: ");
        int birthYear;
        if (int.TryParse(Console.ReadLine(), out birthYear))
        {
            var result = students.FindAll(s => s.BirthYear == birthYear);

            if (result.Count > 0)
            {
                Console.WriteLine($"Студенты {birthYear} года:");
                foreach (var student in result)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Студенты данного года не найдены.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода года.");
        }
    }
}
*/