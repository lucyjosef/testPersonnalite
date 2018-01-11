//Sans méthode code répétitif
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDePersoPro
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("QUEL PROFESSIONNEL ÊTES-VOUS ?" + Environment.NewLine + "Pour répondre pressez A, B ou C sur votre clavier en fonction de la réponse.");
            Console.ResetColor();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("QUESTION 1 : Vous aimez rire, " + Environment.NewLine + "A - Beaucoup !! Hahahaha" + Environment.NewLine + "B - Un petit peu, oui" + Environment.NewLine + "C - Pas vraiment, non");
            ConsoleKeyInfo reponse = Console.ReadKey(true);
            if (reponse.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 2 : Vous faite beaucoup de compliment" + Environment.NewLine + "A - Au moins 10 par jour" + Environment.NewLine + "B - Quand c'est mérité seulement" + Environment.NewLine + "C - Très rarement, pour ne pas dire, jamais");
            ConsoleKeyInfo reponse2 = Console.ReadKey(true);
            if (reponse2.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse2.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse2.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 3 : Chez vos collaborateurs, vous appréciez surtout " + Environment.NewLine + "A - Leur fiabilité, leur volonté et leur curiosité" + Environment.NewLine + "B - Leur relationnel et gentillesse" + Environment.NewLine + "C - Leur résultats et rigueure");
            ConsoleKeyInfo reponse3 = Console.ReadKey(true);
            if (reponse3.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse3.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse3.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 4 : Votre dresscode idéalement " + Environment.NewLine + "A - \"smart casual\" décontracté sans en faire trop" + Environment.NewLine + "B - Freestyle, jean troué et chaussettes Calimero" + Environment.NewLine + "C - Costume 3 pièces ou tailleur, cravate serrée, et chignon/lunettes");
            ConsoleKeyInfo reponse4 = Console.ReadKey(true);
            if (reponse4.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse4.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse4.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 5 : Votre petit-déjeuner idéal " + Environment.NewLine + "A - Une boisson chaude puor se réveiller, une collation et c'est parti !" + Environment.NewLine + "B - Bière / redbull et le reste de pizza d'hier" + Environment.NewLine + "C - Muesli complet, pomme grany et jus de fruit tous les jours à 7h15 pétantes");
            ConsoleKeyInfo reponse5 = Console.ReadKey(true);
            if (reponse5.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse5.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse5.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 6 : Les décisions importantes dans votre entreprise idéale " + Environment.NewLine + "A - Sont prises en collaboration avec 100% des employés" + Environment.NewLine + "B - Sont très souvent prises sur le tas par l'employé concerné" + Environment.NewLine + "C - Sont imposées par la direction. Point.");
            ConsoleKeyInfo reponse6 = Console.ReadKey(true);
            if (reponse6.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse6.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse6.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 7 : Vos locaux, dans l'idéal " + Environment.NewLine + "A - Spacieux et propices à un travail de qualité" + Environment.NewLine + "B - Confortables avec une immense salle de repos !" + Environment.NewLine + "C - Fonctionnels");
            ConsoleKeyInfo reponse7 = Console.ReadKey(true);
            if (reponse7.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse7.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse7.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 8 : Votre métier, " + Environment.NewLine + "A - Vous l'avez choisi par passion, il vous anime" + Environment.NewLine + "B - Il est trop cool, presque pas besoin de faire d'effort pour y arriver !" + Environment.NewLine + "C - Il me fait gagner beaucoup d'argent en tout cas");
            ConsoleKeyInfo reponse8 = Console.ReadKey(true);
            if (reponse8.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse8.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse8.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 9 : Vos collègues, " + Environment.NewLine + "A - Sont les meilleurs ! Vous savez faire régner une bonne ambiance productive" + Environment.NewLine + "B - Sont aussi vos potes" + Environment.NewLine + "C - Fournissent un bon travail");
            ConsoleKeyInfo reponse9 = Console.ReadKey(true);
            if (reponse9.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse9.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse9.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();

            Console.WriteLine("QUESTION 10 : Si vous êtes/êtiez le bigboss " + Environment.NewLine + "A - Vous feriez progresser toute l'équipe pour que l'activité reste en croissance sur le long terme" + Environment.NewLine + "B - Vous augmenteriez vos amis/employés chaque mois sans raison, pour le fun" + Environment.NewLine + "C - Vous féliciteriez l'employé du mois et le récompenseriez d'un coupon réduction de chez Kiabi");
            ConsoleKeyInfo reponse10 = Console.ReadKey(true);
            if (reponse10.Key == ConsoleKey.A)
            {
                A++;
            }
            else if (reponse10.Key == ConsoleKey.B)
            {
                B++;
            }
            else if (reponse10.Key == ConsoleKey.C)
            {
                C++;
            }
            else
            {
                Console.WriteLine("Veuillez répondre par A, B ou C");
            }
            Console.Clear();



            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.ReadLine();
        }
    }
}

