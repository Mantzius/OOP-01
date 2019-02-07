using System;
namespace Application
{
    public class Person
    {
        private readonly string Fornavn;
        private readonly string Efternavn;
        private readonly int Alder;
        private Person Far;
        private Person Mor;

        public Person(string FirstName, string LastName, int Age, Person Father = null, Person Mother = null)
        {
            Fornavn = FirstName;
            Efternavn = LastName;
            Alder = Age;
            Far = Father;
            Mor = Mother;
        }

        public void SetFar(Person Far)
        {
            this.Far = Far ?? throw new ArgumentNullException();
        }

        public void SetMor(Person Mor)
        {
            this.Mor = Mor ?? throw new ArgumentNullException();
        }

        public void PrintPerson(int RecursionLevel=0)
        {
            string Spaces = "";
            for (int i = 0; i < RecursionLevel * 4; i++)
            {
                Spaces = Spaces + " ";
            }

            Console.WriteLine(String.Format("{0} Fornavn: {1} Efternavn: {2} Alder: {3}", Spaces, Fornavn, Efternavn, Alder));
            if (Far != null)
            {
                Far.PrintPerson(RecursionLevel+1);
            }
            if (Mor != null)
            {
                Mor.PrintPerson(RecursionLevel+1);
            }
        }

    }
}
