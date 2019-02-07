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

        public void PrintPerson()
        {
            Console.WriteLine("Fornavn: " + Fornavn + " Efternavn: " + Efternavn + " Alder: " + Alder);
            if (Far != null)
            {
                Far.PrintPerson();
            }
            if (Mor != null)
            {
                Mor.PrintPerson();
            }
        }

    }
}
