using System;
using System.Runtime.InteropServices;

namespace Chap_06_Structure
{
    class Program
    {
        #region Structure: 6-1
        /*
        public struct student
        {
            public int id;
            public string name;
        }
        */
        #endregion

        #region Structure: 6-4
        /*
        public struct student
        {
            public int id;
            public string name;
        }
        */
        #endregion

        #region Structure: 6-5
        /*
        public struct nametype
        {
            public string first;
            public string last;
        }

        public struct student
        {
            public int id;
            public nametype name;
        }
        */
        #endregion

        #region Structure: 6-6
        /*
        public struct nametype
        {
            public string first;
            public string last;
        }

        public struct studenttype
        {
            public int id;
            public nametype name;
        }
        */
        #endregion

        #region Structure: 6-7
        /*
        public struct nametype
        {
            public string first;
            public string last;
        }

        public struct studenttype
        {
            public int id;
            public string grade;
            public nametype name;
        }
        */
        #endregion

        #region Structure: 6-9
        /*
        public struct nametype
        {
            public string first;
            public string last;
        }

        public struct studenttype
        {
            public int id;
            public string grade;
            public nametype name;
        }
        */
        #endregion

        #region Structure: 6-9 Ex - 1
        /*
        public struct Rational
        {
            public int p { get; }
            public int q { get; }

            public Rational(int numerator, int denominator)
            {
                int gcd = GreatestCommonDivisor(numerator, denominator);
                p = numerator / gcd;
                q = denominator / gcd;
            }

            static int GreatestCommonDivisor(int x, int y)
            {
                int a, b, t, gcd;

                a = x;
                b = y;

                if (a == 0)
                {
                    gcd = a;
                }
                else if (b == 0)
                {
                    gcd = b;
                }
                else
                {
                    while (b != 0)
                    {
                        t = b;
                        b = a % b;
                        a = t;
                    }
                    gcd = a;
                }

                return gcd;
            }

            public Rational Add(Rational r)
            {
                return new Rational((p * r.q) + (r.p * q), (q * r.q));
            }

            public static Rational operator + (Rational r1, Rational r2)
            {
                return r1.Add(r2);
            }

            public Rational Sub(Rational r)
            {
                return new Rational((p * r.q) - (r.p * q), (q * r.q));
            }

            public static Rational operator - (Rational r1, Rational r2)
            {
                return r1.Sub(r2);
            }

            public Rational Mul(Rational r)
            {
                return new Rational((p * r.p), (q * r.q));
            }

            public static Rational operator * (Rational r1, Rational r2)
            {
                return r1.Mul(r2);
            }

            public Rational Div(Rational r)
            {
                int denom = (r.p * q);
                if (denom == 0) throw new DivideByZeroException();
                return new Rational((p * r.q), denom);
            }

            public static Rational operator / (Rational r1, Rational r2)
            {
                return r1.Div(r2);
            }

            public Rational Abs()
            {
                return new Rational(Math.Abs(p), Math.Abs(q));
            }

            public Rational Reduce()
            {
                int gcd = GreatestCommonDivisor(p, q);
                int numerator = p / gcd;
                int denominator = q / gcd;
                if (denominator < 0)
                {
                    return new Rational(-numerator, -denominator);
                }
                return new Rational(numerator, denominator);
            }
        }
        */
        #endregion

        #region Structure: 6-9 Ex - 2
        /*
        public struct NationalIDCard
        {
            public int ID;
            public string Name;
            public string FathersName;
            public string MothersName;
            public Date DateOfBirth;
        }

        public struct Date
        {
            public int Day;
            public int Month;
            public int Year;
        }
        */
        #endregion

        #region Structure: 6-12
        /*
        public struct s1
        {
            int n;
            double d;
            char c;
        }

        public struct s2
        {
            char c;
            int n;
            double d;
        }
        */
        #endregion

        static void Main(string[] args)
        {
            #region Code: 6-1
            /*
            Student one;

            one.id = 1;
            one.name = "Tahmid Tafi";

            Console.WriteLine($"ID: {one.id}");
            Console.WriteLine($"Name: {one.name}");
            */
            #endregion

            #region Code: 6-2 and 6-3
            // Program 6-2.c and 6-3 ara not not posibol in this Langulage.
            #endregion

            #region Code: 6-4
            /*
            student one;

            one.id = int.Parse(Console.ReadLine());
            one.name = Console.ReadLine();

            Console.WriteLine($"ID: {one.id}");
            Console.WriteLine($"Name: {one.name}");
            */
            #endregion

            #region Code: 6-5
            /*
            student one;

            one.id = int.Parse(Console.ReadLine());
            one.name.first = Console.ReadLine();
            one.name.last = Console.ReadLine();

            Console.WriteLine($"ID: {one.id}");
            Console.WriteLine($"Name: {one.name.first} {one.name.last}");
            */
            #endregion

            #region Code: 6-6
            /*
            studenttype[] student = new studenttype[5];

            for (int i = 0; i < student.Length; i++)
            {
                Console.Write($"Enter the ID for student {i+1}: ");
                student[i].id = int.Parse(Console.ReadLine());

                Console.Write($"Enter the first name for student {i + 1}: ");
                student[i].name.first = Console.ReadLine();

                Console.Write($"Enter the last name for student {i + 1}: ");
                student[i].name.last = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Output: \n\n");

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"ID: {student[i].id}");
                Console.WriteLine($"Name: {student[i].name.first} {student[i].name.last}");
            }
            */
            #endregion

            #region Code: 6-7
            /*
            studenttype[] student = new studenttype[3];
            int[] marks = { 72, 82, 60 };

            for (int i = 0; i < student.Length; i++)
            {
                Console.Write($"Enter the ID for student {i + 1}: ");
                student[i].id = int.Parse(Console.ReadLine());

                Console.Write($"Enter the first name for student {i + 1}: ");
                student[i].name.first = Console.ReadLine();

                Console.Write($"Enter the last name for student {i + 1}: ");
                student[i].name.last = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < student.Length; i++)
            {
                CalculateGrade(student[i], marks[i]);
            }

            Console.WriteLine("Output: \n\n");

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"ID: {student[i].id}");
                Console.WriteLine($"Name: {student[i].name.first} {student[i].name.last}");
                Console.WriteLine($"Grade: {student[i].grade}");
            }
            */
            #endregion

            #region Code: 6-8
            /*
            unsafe
            {
                void PlusTen2(int* a)
                {
                    *a = (*a) + 10;
                }

                int a = 5;

                PlusTen(a);
                Console.WriteLine($"a = {a}");

                PlusTen2(&a);
                Console.WriteLine($"a = {a}");
            }
            */
            #endregion

            #region Code: 6-9
            /*
            studenttype[] student = new studenttype[5];
            int[] marks = { 72, 82, 60, 20, 50 };

            for (int i = 0; i < student.Length; i++)
            {
                Console.Write($"Enter the ID for student {i + 1}: ");
                student[i].id = int.Parse(Console.ReadLine());

                Console.Write($"Enter the first name for student {i + 1}: ");
                student[i].name.first = Console.ReadLine();

                Console.Write($"Enter the last name for student {i + 1}: ");
                student[i].name.last = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < student.Length; i++)
            {
                CalculateGrade(ref student[i], marks[i]);
            }

            Console.WriteLine("Output: \n\n");

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"ID: {student[i].id}");
                Console.WriteLine($"Name: {student[i].name.first} {student[i].name.last}");
                Console.WriteLine($"Grade: {student[i].grade}");
                Console.WriteLine();
            }
            */
            #endregion

            #region Code: 6-9 Ex - 1
            /*
            var x = new Rational(1, 2);
            var y = new Rational(2, 3);

            Console.WriteLine($"x = {x.p}/{x.q} and y = {y.p}/{y.q}");
            Console.WriteLine($"Add: {(x + y).p}/{(x + y).q}");
            Console.WriteLine($"Sub: {(x - y).p}/{(x - y).q}");
            Console.WriteLine($"Div: {(x / y).p}/{(x / y).q}");
            Console.WriteLine($"Mul: {(x * y).p}/{(x * y).q}");
            Console.WriteLine($"Equal: {Equals(x, y)}");

            x = new Rational(5, 7);
            y = new Rational(5, 7);

            Console.WriteLine($"x = {x.p}/{x.q} and y = {y.p}/{y.q}");
            Console.WriteLine($"Equal: {Equals(x, y)}");
            */
            #endregion

            #region Code: 6-9 Ex - 2
            /*
            NationalIDCard card = new NationalIDCard();

            Console.Write($"Enter your name: ");
            card.Name = Console.ReadLine();

            Console.Write($"Enter your father's name: ");
            card.FathersName = Console.ReadLine();

            Console.Write($"Enter your mother's name: ");
            card.MothersName = Console.ReadLine();

            Console.Write($"Enter your birth day: ");
            card.DateOfBirth.Day = int.Parse(Console.ReadLine());

            Console.Write($"Enter your birth month: ");
            card.DateOfBirth.Month = int.Parse(Console.ReadLine());

            Console.Write($"Enter your birth year: ");
            card.DateOfBirth.Year = int.Parse(Console.ReadLine());
            */
            #endregion

            #region Code: 6-10 and 6-11
            // C# doesn't natively support the C/C++ notion of unions. 
            #endregion

            #region Code: 6-12
            /*
            Console.WriteLine($"char size: {sizeof(char)} bytes");
            Console.WriteLine($"int size: {sizeof(int)} bytes");
            Console.WriteLine($"double size: {sizeof(double)} bytes");

            Console.WriteLine($"s1 size: {Marshal.SizeOf(typeof(s1))} bytes");
            Console.WriteLine($"s2 size: {Marshal.SizeOf(typeof(s2))} bytes");
            */
            #endregion
        }

        #region Function: 6-7
        /*
        static void CalculateGrade(studenttype student, int mark)
        {
            if (mark >= 80)
            {
                student.grade = new String("A+");
            }
            else if (mark >= 70)
            {
                student.grade = new String("A");
            }
            else if (mark >= 60)
            {
                student.grade = new String("A-");
            }
            else if (mark >= 50)
            {
                student.grade = new String("B");
            }
            else if (mark >= 40)
            {
                student.grade = new String("C");
            }
            else
            {
                student.grade = new String("F");
            }
        }
        */
        #endregion

        #region Function: 6-8
        /*
        static void PlusTen(int a)
        {
            a = a + 10;
        }
        */
        #endregion

        #region Function: 6-9
        /*
        static void CalculateGrade(ref studenttype student, int mark)
        {
            if (mark >= 80)
            {
                student.grade = new String("A+");
            }
            else if (mark >= 70)
            {
                student.grade = new String("A");
            }
            else if (mark >= 60)
            {
                student.grade = new String("A-");
            }
            else if (mark >= 50)
            {
                student.grade = new String("B");
            }
            else if (mark >= 40)
            {
                student.grade = new String("C");
            }
            else
            {
                student.grade = new String("F");
            }
        }
        */
        #endregion
    }
}
