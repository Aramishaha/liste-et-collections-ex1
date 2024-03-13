using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_et_collections_ex1
{
    using System;
    using System.Collections.Generic;
    class Program
    {

        static void Main(string[] args)
        {
            List<string> lesComposants = new List<string> { "Intel Core i5 13600KF", "Gigabyte B760 DS3H", "Western Digital WD Blue SN580 - 1 To", "Gygabyte Geforce RTX 3060" };
            int option=0;
           

            bool ok = true;
            
            do
            {
                Console.Clear();

                Console.WriteLine("Menu : \n" +

               "  Taper 1 pour ajouter un composant :\n" +

               "  Taper 2 pour modifier un composant :\n" +

               "  Taper 3 pour supprimer un composant :\n" +

               "  Taper 4 pour afficher la liste et le nombre de composant :                    \n  " +

               "  Taper 5 pour sortir :                    \n  ");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisissez un nombre existant de 0 à nombres de composants : ");
                    ok = false;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie ");
                    ok = false;

                }
                
                if (option == 1)
                {
                    foreach (string composant in lesComposants)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(composant);
                        Console.WriteLine(" ");
                    }






                    Console.WriteLine("Saisissez le composant que vous voulez ajouter :\n");
                    string ajout = Console.ReadLine();
                    lesComposants.Add(ajout);




                    foreach (string composant in lesComposants)
                    {

                        Console.WriteLine(" ");
                        Console.WriteLine(composant);
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine("Voici la nouvelle liste : ");

                }

                if (option == 2)
                {
                    foreach (string composant in lesComposants)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(composant);
                        Console.WriteLine(" ");
                    }


                    do
                    {
                        try
                        {
                            Console.WriteLine("Saisissez l' index que vous voulez modifier :\n");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Saisissez ce que vous voulez :\n");
                            string ajout = Console.ReadLine();
                            lesComposants[index] = ajout;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Saisissez un index existant de 0 à nombres de composants : ");
                            ok = false;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie ");
                            ok = false;
                        }
                       
                    

                    } while (ok == false);
                    

                    foreach (string composant in lesComposants)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(composant);
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine("Vous avez modifiez le composant : \n\n");

                }


                if (option == 3)
                {
                    foreach (string composant in lesComposants)
                    {
                        Console.WriteLine(composant);
                    }


                    Console.WriteLine("Ecrivez l'index de l'élément à supprimer : ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    lesComposants.RemoveAt(index);

                    do
                    {
                        try
                        {
                            Console.WriteLine("Saisissez l' index que vous voulez modifier :\n");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Saisissez ce que vous voulez :\n");
                            string ajout = Console.ReadLine();
                            lesComposants[index] = ajout;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Saisissez un index existant de 0 à nombres de composants : ");
                            ok = false;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie ");
                            ok = false;
                        }



                    } while (ok == false);

                }

                if (option == 4)
                {

                    Console.WriteLine("Voici la liste : ");

                    foreach (string composant in lesComposants)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(composant);
                        Console.WriteLine(" ");


                    }
                    int nombre = lesComposants.Count();
                    Console.WriteLine(" On a " + nombre + " composants " );
                    ok = false;
                }

                if (option == 5)
                {
                    ok = true;
                }
               

                Console.ReadKey();


            } while (ok == false);

        }
    }
}
