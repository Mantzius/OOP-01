using System;
namespace Application
{
    public class Person
    {
        private readonly string FirstName;
        private readonly string LastName;
        private readonly int Age;
        private Person Father;
        private Person Mother;

        public Person(string FirstName, string LastName, int Age, Person Father = null, Person Mother = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Father = Father;
            this.Mother = Mother;
        }

        public void SetFather(Person Father)
        {
            this.Father = Father ?? throw new ArgumentNullException();
        }

        public void SetMother(Person Mother)
        {
            this.Mother = Mother ?? throw new ArgumentNullException();
        }

        public void PrintPerson(int RecursionLevel=0)
        {
            string Spaces = "";
            for (int i = 0; i < RecursionLevel * 4; i++)
            {
                Spaces = Spaces + " ";
            }

            Console.WriteLine(String.Format("{0} Fornavn: {1} Efternavn: {2} Alder: {3}", Spaces, FirstName, LastName, Age));
            if (Father != null)
            {
                Father.PrintPerson(RecursionLevel+1);
            }
            if (Mother != null)
            {
                Mother.PrintPerson(RecursionLevel+1);
            }
        }

    }
}
