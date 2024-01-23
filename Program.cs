using System;



namespace Assignment
{




    public class Program
    {

        static void Main(string[] args)
        {

            //Övningar 3


            //Skapar en array med 5 värden
            int[] Hej = { 1, 2, 3, 4, 5, };


            //Skriver ut arrayn med en for loop
            for (int i = 0; i < Hej.Length; i++)
            {
                Console.WriteLine(Hej[i]);
            }

            //Skapar en tom variabel
            int Hej2 = 0;


            //For loop som adderar in varje värde av arrayn i den tomma variabeln 
            for (int i = 0; i < Hej.Length; i++)
            {
                Hej2 += Hej[i];

            }

            //Skriver ut den förredetta tomma variabeln som nu är hela arryan sammlad
            Console.WriteLine(Hej2);


            //For loop där man använder i index för att enkelt kunna få fram varje tal i arryan. 
            for (int i = 0; i < Hej.Length; i++)
            {
                Hej[i] = Hej[i] * 2;
                Console.WriteLine(Hej[i]);
            }

            //kallar på metod och skriver ut den för uppgift 1 övning 4
            Assignment2 pris = new Assignment2();

            Console.WriteLine(pris.pris());




        }
}

    //klass och metod för uppgift 1 av olika priser
public class Assignment2
{ 
         public int pris()
        {
            var age = 0;

            var price = 0;

            age += int.Parse(Console.ReadLine());

            if (age < 18)
            {
                price = 12 * age + 30;
                return price;
            }
            else if (age > 18 && age < 65)
            {
                price = 25 * age + 30;
                return price;
            }
            else if (age >= 65)
            {
                price = 20 * age + 30;
                return price;
            }
            return price;
        }



    }














}