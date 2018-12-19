using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionnelle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votre Age?");
            int birth = int.Parse(Console.ReadLine());
            Console.WriteLine("homme ou femme?");
            string sexe = (Console.ReadLine());
            //if (birth >= 18 && birth <= 100 && sexe == "homme")
            //{
            //    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
            //}
            //if (birth < 18 && birth > 0 && sexe == "homme")
            //{
            //    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
            //}
            //if (birth >= 18 && birth <= 100 && sexe == "femme")
            //{
            //    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            //}
            //if (birth < 18 && birth > 0 && sexe == "femme")
            //{
            //    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            //}
            //else
            //{
            //    Console.WriteLine("Vous êtes une erreur");
            //}
            if (sexe == "femme")
            {
                if (birth > 17 && birth <= 120)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeur");
                }
                else if (birth < 18 && birth >= 1)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure");
                }
                else
                {
                    Console.WriteLine("Il doit y avoir une erreur");
                }
            }
            else if (sexe == "homme")
            {
                if (birth > 17 && birth <= 120)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur");
                }
                else if (birth < 18 && birth >= 1)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineure");
                }
                else
                {
                    Console.WriteLine("Il doit y avoir une erreur d'âge");
                }
            }
            else
            {
                Console.WriteLine("Il doit y avoir une erreur de sexe");
            }

            }
        }
    }


