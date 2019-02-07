using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person Mor = new Person("asdasd", "", -32);
            Person Far = new Person("asdads", "asdsd", 22);
            Person Me = new Person("asdafafss", "asdadsadd", 0);
            Me.SetFar(Far); Me.SetMor(Mor);
            Me.PrintPerson();

            HelloWorld();
            float F = 33;
            float C = FtoC(F);
            Console.WriteLine(C);
            MicroToTime(1000 * 4200);

            FileStuffs FileStuff = new FileStuffs();
            FileStuff.ListDirectory("/home/nitrous/datalogi");

            Vector V = new Vector(3, -1);
            Vector Z = new Vector(2, 2);
            V.Add(Z);
            V.Print();
            V.Subtract(Z);
            V.Print();

            Vector X = V.Addition(Z);
            X.Print();
            X = X.Subtraction(Z);
            X.Print();

        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static float FtoC(float Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }

        public static void MicroToTime(int Nano)
        {
            int Seconds = Nano / 1000;
            int Minutes = Seconds / 60;
            Seconds = Seconds % 60;
            int Hours = Minutes / 60;
            Minutes = Minutes % 60;
            int Days = Hours / 24;
            Hours = Hours % 24;
            Console.WriteLine("Days: " + Days + " Hours: " + Hours + " Minutes: " + Minutes + " Seconds: " + Seconds);
        }
    }
}
