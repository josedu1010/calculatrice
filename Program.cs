using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*José David Ravines Huayta
             * ETML Papp stage 1
             * Programme : Initiales
             * 07.09.2023
             * */
            
            
            //DEF DE "A" AVEC DEBUT DE BOUCLE 
            bool a = true;//deffinir que "a" est true avant la boucle 
            do//debut de la boucle

            {
                //TEXTE 1
                Console.WriteLine("CALCULATRICE");
                Console.WriteLine("_____________________");
                Console.WriteLine();
                //DEMADE DE NUMERO
                Console.WriteLine("enter number");
                int num1 = Convert.ToInt32(Console.ReadLine());


                //EXPLIQUE a l'utilisateur comment ça marche les operations de la calculatrice
                
                //TEXTE 2 

                Console.WriteLine("a ou + = addition");
                Console.WriteLine();

                Console.WriteLine("s ou - = soustraction");
                Console.WriteLine();

                Console.WriteLine("m ou * = multiplication");
                Console.WriteLine();

                Console.WriteLine("d ou / =division");
                Console.WriteLine();

                int result = 0;

                string operateur = Console.ReadLine();

                //DEMANDE DE NUMERO 2 

                Console.WriteLine("enter number");//demande de nombre 

                int num2 = Convert.ToInt32(Console.ReadLine());//prendre ce que l'utilisateur met pour le converetir en numero
                                                               //puis le remettre en bas avec les methodes pour soustraire ou faire les autres fonctions

                // CASES DE OPERATIONS

                switch (operateur)//pour permettre de differencier les differentes touches pour faire les operations
                { 
                    case "a":
                        result = Add(num1, num2);

                        Console.WriteLine(result);
                        break;
                    case "+":                   // les +
                        result = Add(num1, num2);

                        Console.WriteLine(result);
                        break;
                    case "s":
                        result = sub(num1, num2);

                        Console.WriteLine(result);     // les -
                        break;
                    case "-":
                        result = sub(num1, num2);

                        Console.WriteLine(result);
                        break;
                    case "m":
                        result = mult(num1, num2);

                        Console.WriteLine(result);    // les *
                        break;
                    case "*":
                        result = mult(num1, num2);

                        Console.WriteLine(result);
                        break;
                    case "d":
                        result = div(num1, num2);

                        Console.WriteLine(result);    // les /
                        break;
                    case "/":
                        result = div(num1, num2);

                        Console.WriteLine(result);
                        break;
                    defaut: Console.WriteLine("veuillez ressayer");//cette ligne de code et thecniquement inutile 
                        Console.WriteLine();//Mais je la laisse pour me rapeller comment ça marche 
                        break;

                }



                Console.WriteLine("continuez?");//question pour l'utilisateur s'il veut refaire 

                char reponse = Convert.ToChar(Console.ReadLine());//pour convertir ce qu'on ecrit en char et le garder en tant que "reponse"
                //DEF DE FIN DE BOUCLE 
                switch (reponse)
                {
                    case 'N':// pour deffinir que de que on met "N" le programme finisse
                        a = false;
                        break;
                    case 'n':// pour deffinir que de que on met "N" le programme finisse
                        a = false;
                        break;

                } 

                Console.Clear();
            }
          
            while (a == true); //FIN de boucle
            


            Console.ReadLine(); //pour que quand la boucle finisse ça ne s'arrete pas 





        }
        //DEFINITONS DE METHODES
        private static int Add(int num1, int num2) // methodes pour chaque operation "private" et donc pour que utiliser cette derniere que dans cette page
        {// add est donc le nom de la methode 


            int result = num1 + num2;


            return result;// et result la maniere de l'appeler  
        }
        private static int sub(int num1, int num2)
        {


            int result = num1 - num2;


            return result;
        }

        private static int mult(int num1, int num2)
        {


            int result = num1 * num2;


            return result;
        }

        private static int div(int num1, int num2)
        {


            int result = num1 / num2;


            return result;
        }





    }
}
