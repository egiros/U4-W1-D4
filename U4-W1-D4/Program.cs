using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;

            // Loop principale per presentare il menu e interagire con l'utente
            do
            {
                Console.WriteLine("\n\n===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                Console.Write("Inserisci la tua scelta: ");

                Console.WriteLine("\n\n\n");

                // Verifica che l'input sia un numero
                if (int.TryParse(Console.ReadLine(), out scelta))
                {
                    switch (scelta)
                    {
                        case 1:
                            Console.Write("Inserisci username: ");
                            string inputUsername = Console.ReadLine();
                            Console.Write("Inserisci password: ");
                            string inputPassword = Console.ReadLine();
                            Console.Write("Conferma password: ");
                            string confermaPassword = Console.ReadLine();
                            Utente.Login(inputUsername, inputPassword, confermaPassword);
                            break;
                        case 2:
                            Utente.Logout();
                            break;
                        case 3:
                            Utente.VerificaOraDataLogin();
                            break;
                        case 4:
                            Utente.ListaAccessi();
                            break;
                        case 5:
                            Console.WriteLine("Vai già via? Premi invio per confermare.");
                            break;
                        default:
                            Console.WriteLine("Scelta non valida. Riprova.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci un numero valido.");
                }

            } while (scelta != 5);

            Console.ReadLine(); 
        }
    }
}
