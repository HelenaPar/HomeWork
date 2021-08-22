using System;
using static System.Math;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11
{
    public class Math
    {
        private int a;
        private int b;

        public void ConsoleAB()
        {
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
        public void Change(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Sum()
        {
            int sum = 0;
            sum = a + b;
            Console.WriteLine("Сумма = " + sum);
        }
        public void Max()
        {
            int max = 0;
            if (a > b)
            {
                max = a;
                Console.WriteLine("Наибольшей является А = " + max);
            }
            else if (b > a)
            {
                max = b;
                Console.WriteLine("Наибольшей ялвяется В = " + max);
            }
            else Console.WriteLine("Числа равны!");
        }
    }
    public struct Student
    {
        private string surname;
        private string init;
        private int number;
        public int[] marks;
        public void Marks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
        }
        public void Mark()
        {
            int num = 1;
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[0] == marks[i] && marks[i] == 4 && marks[0] == 4)
                {
                    continue;
                    num++;
                }
                if (marks[0] == marks[i] && marks[i] == 5 && marks[0] == 5)
                {
                    continue;
                    num++;
                }
                else break;
            }
            if (num == marks.Length)
            {
                Console.WriteLine(surname + ", номер группы: " + number);
            }

        }
        public void Sr()
        {
            int sum = 0;
            int kol = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum = sum + marks[i];
                kol++;
                
            }
            sum = sum / kol;
            Console.Write(sum);
        }
        public Student(string surname, string init, int number, int[] marks)
        {
            this.surname = surname;
            this.init = init;
            this.number = number;
            this.marks = marks;

        }
        public void Enter()
        {
            Console.WriteLine();
            Console.Write(surname + " " + init[0] + "." + init[1] + ", номер группы: " + number + ", успеваемость: "); Marks();
        }
       
    }
    public class StudentJournal
    {
        
        private List<Student> stud;
        Student student;
        public StudentJournal()
        {
            stud = new List<Student> { };
        }
        public void Add(Student student)
        {
            stud.Add(student);
        }
        public void Print()
        {
            foreach (var m in stud)
            {
                m.Enter();
            }
        }
        public void Sort()
        {
            stud.Sort((a, b) => a.marks.Average().CompareTo(b.marks.Average()));
            foreach (var m in stud)
            {
                m.Enter();
            }
        }
        public void Sort2()
        {
            student.Mark();
            foreach (var m in stud)
            {
                m.Enter();
            }
        }
    }
    public class Compl
    {
        private int a;
        private int b;
        private int[][] nums;
        public Compl()
        {
            nums = new int[6][];
        }
        public void Enter(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Com()
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    Console.WriteLine("Ваше комплексное число: " + a + " + " + b + "i");
                }
            }
        }
        public void Add(int a, int b)
        {
            int n = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            nums[n] = new int[] { a, b };
            n++;
            //    }
            //}
            Console.WriteLine("Ваше комплексное число: " + a + " + " + b + "i");
        }
        public void Sum(int a, int b, int c, int d)
        {
            int sumA = a + c;
            int sumB = b + d;
            nums[2] = new int[] { sumA, sumB };

            Console.WriteLine("Сумма чисел: " + nums[2][0] + " + " + nums[2][1] + "i");
        }

        public void Razn(int a, int b, int c, int d)
        {
            int razA = a - c;
            int razB = b - d;
            nums[3] = new int[] { razA, razB };

            Console.WriteLine("Вычитание чисел: " + nums[3][0] + " + " + nums[3][1] + "i");
        }
        public void Proiz(int a, int b, int c, int d)
        {
            int prA = a * c - b * d;
            int prB = a * d - c * b;
            nums[4] = new int[] { prA, prB };

            Console.WriteLine("Произведение чисел: " + nums[4][0] + " + " + nums[4][1] + "i");
        }
        public void Del(int a, int b, int c, int d)
        {
            double delA = (a * c + b * d) / (c * c + d * d);
            Console.WriteLine(delA);
            double delB = (b * c - a * d) / (c * c + d * d);
            nums[5] = new int[] { (int)delA, (int)delB };

            Console.WriteLine("Деление чисел: " + nums[5][0] + " + " + nums[5][1] + "i");
        }
        public void Per(int a, int b)
        {
            double p = Sqrt(a * a + b * b);
            double fi = 0;
            if (a < 0 && b < 0)
            {
                fi = -PI + Atan(b / a);
            }
            else if (a < 0 && b > 0)
            {
                fi = PI + Atan(b / a);
            }
            else if (a > 0)
            {
                fi = Atan(b / a);
            }
            Console.WriteLine(fi);
        }
    }
    //public class Strings
    //{
    //    char[] str;

    //    public Strings()
    //    {
    //        str = new char[] { };
    //    }
    //    public void Concat(char[] str)
    //    {
           
    //    }
    //}
    class Program
        {
            static void Main(string[] args)
            {

                while (true)
                {
                Console.WriteLine();
                    Console.WriteLine("Введите номер задания (1-3): ");
                    int numZ = Convert.ToInt32(Console.ReadLine());
                switch (numZ)
                {
                    case 1:
                        Console.WriteLine("Введите значение переменной А: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение переменной В: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Math math = new Math();
                        math.Change(a, b);
                        char r = 'r';
                        while (r == 'r')
                        {

                            Console.WriteLine("Меню");
                            Console.WriteLine("1 - Вывести на экран");
                            Console.WriteLine("2 - Изменить значения переменных");
                            Console.WriteLine("3 - Найти сумму значений переменных");
                            Console.WriteLine("4 - Найти наибольшую из переменных");
                            Console.WriteLine("5 - Назад");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 1:
                                    math.ConsoleAB();
                                    break;
                                case 2:
                                    math.ConsoleAB();
                                    Console.WriteLine("Введите новое значение переменной А: ");
                                    int newA = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите новое значение переменной В: ");
                                    int newB = Convert.ToInt32(Console.ReadLine());
                                    math.Change(newA, newB);
                                    break;
                                case 3:
                                    math.Sum();
                                    break;
                                case 4:
                                    math.Max();
                                    break;
                                case 5:
                                    r = 'e';
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Student student = new Student();
                        StudentJournal journal = new StudentJournal();
                        char ab = 'b';
                        while (ab == 'b')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Меню");
                            Console.WriteLine("1 - Вывести список студентов");
                            Console.WriteLine("2 - Добавить нового студента");
                            Console.WriteLine("3 - Упорядочить записи по возрастанию среднего балла");
                            Console.WriteLine("4 - Вывести записи о студентах имеющих оценки только 4 или 5");
                            Console.WriteLine("5 - Назад");
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    journal.Print();
                                    break;
                                case 2:
                                    Console.WriteLine("Введите фамилию студента: ");
                                    string sur = Console.ReadLine();
                                    Console.WriteLine("Введите инициалы: ");
                                    string init = Console.ReadLine();
                                    Console.WriteLine("Введите номер группы: ");
                                    int number = Convert.ToInt32(Console.ReadLine());
                                    int[] mas = new int[5];
                                    Console.WriteLine("Введите 5 оценок студента:");
                                    string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                                    for (int i = 0; i < 5; ++i)
                                    {
                                        mas[i] = Convert.ToInt32(str[i]);
                                    }
                                    Student stud = new Student(sur, init, number, mas);
                                    journal.Add(stud);
                                    stud.Enter();
                                    break;
                                case 3:
                                    journal.Sort();
                                    break;
                                case 4:
                                    journal.Sort2();
                                    break;
                                case 5:
                                    ab = 'a';
                                    break;

                            }
                        }
                            break;
                        
                        case 3:
                            Console.WriteLine("Форма записи комплексного числа: A + B*i в алгебраической форме");
                            Console.WriteLine("Введите A для первого числа: ");
                            int a1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите B для первого числа: ");
                            int b1 = Convert.ToInt32(Console.ReadLine());
                            Compl compl = new Compl();
                            compl.Enter(a1, b1);
                            compl.Add(a1, b1);
                            Console.WriteLine("Введите A для второго числа: ");
                            int a2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите B для второго числа: ");
                            int b2 = Convert.ToInt32(Console.ReadLine());
                            compl.Enter(a2, b2);
                            compl.Add(a2, b2);
                            char d = 'r';
                            while (d == 'r')
                            {
                                Console.WriteLine("Меню");
                                Console.WriteLine("1 - Сложение");
                                Console.WriteLine("2 - Вычитание");
                                Console.WriteLine("3 - Умножение");
                                Console.WriteLine("4 - Деление");
                              //Console.WriteLine("5 - Перевод в другую форму"); //не поняла, как это сделать :\
                                Console.WriteLine("5 - Назад");
                                int o = Convert.ToInt32(Console.ReadLine());
                                switch (o)
                                {
                                    case 1:
                                        compl.Sum(a1, b1, a2, b2);
                                        break;
                                    case 2:
                                        compl.Razn(a1, b1, a2, b2);
                                        break;
                                    case 3:
                                        compl.Proiz(a1, b1, a2, b2);
                                        break;
                                    case 4:
                                        compl.Del(a1, b1, a2, b2);
                                        break;
                                    //case 5:
                                    //    compl.Per(a1, b1);
                                    //    break;
                                    case 5:
                                        d = 'e';
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
        }
    }



