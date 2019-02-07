using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person Mormor = new Person("Mormor", "MormorEfternavn", 99);
            Person Morfar = new Person("Morfar", "MorfarEfternavn", 98);
            Person Farmor = new Person("Farmor", "FarmorEfternavn", 97);
            Person Farfar = new Person("Farfar", "FarfarEfternavn", 96);

            Person Mor = new Person("Mor", "MorEfternavn", -32);
            Person Far = new Person("Far", "FarEfternavn", 22);
            Person Me = new Person("Mig", "MitEfternavn", 0);
            Mor.SetFather(Morfar); Mor.SetMother(Mormor);
            Far.SetFather(Farfar); Far.SetMother(Farmor);
            Me.SetFather(Far); Me.SetMother(Mor);
            Me.PrintPerson();

            HelloWorld();
            float F = 33;
            float C = FtoC(F);
            Console.WriteLine(C);
            MicroToTime( (int) Math.Pow(4200, 9));

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

            return;
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static float FtoC(float Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }

        public static void MicroToTime(int Micro)
        {
            int Seconds = Micro/ 1000;
            int Minutes = Seconds / 60;
            Seconds = Seconds % 60;
            int Hours = Minutes / 60;
            Minutes = Minutes % 60;
            int Days = Hours / 24;
            Hours = Hours % 24;
            Console.WriteLine(String.Format("Days: {0} Hours: {1} Minutes: {2} Seconds {3}",
                                            Days, Hours, Minutes, Seconds));
        }
    }
}
