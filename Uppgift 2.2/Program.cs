using System;

namespace School_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade du Elin? Svara i meter.");
            string ElinLängd = Console.ReadLine();
            Console.WriteLine("Okej, hur långt hoppade du då Alma? Svara i meter.");
            string AlmaLängd = Console.ReadLine();
            int Elin = int.Parse(ElinLängd);
            int Alma = int.Parse(AlmaLängd);
            int Resulatat = Elin - Alma;
            Console.WriteLine(Resulatat + " meter, är längd skillnad mellan Alma och Elin");
        }
    }
}