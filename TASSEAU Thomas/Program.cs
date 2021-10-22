using System;
namespace TASSEAU_thomas
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalnote;
            int meilleurnote = 10;
            int note;
            int positif = 1;
            int negatif = 0;
            for (totalnote = 0; totalnote <= 10; totalnote++)
                {
                    Console.WriteLine("Donnez " + meilleurnote + " notes");
                    note = int.Parse(Console.ReadLine());
                    Console.Clear();
                    meilleurnote = meilleurnote--; if (note > 20)
                    {
                        Console.WriteLine("veuillez reprendre");
                    }
                    if (note < 0)
                    {
                        Console.WriteLine("veuillez reprendre");
                    }
                    if (note >= 10)
                    {
                        positif = positif + 1;
                        Console.WriteLine("Vous avez " + (positif) + " note postive");
                    }
                    if (note < 10)
                    {

                        negatif = negatif + 0;
                        Console.WriteLine("Vous avez " + (negatif) + " note(s) negative(s)");
                    }

                }




        }
    }
}


   
     
