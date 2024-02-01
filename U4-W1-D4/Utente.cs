using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D4
{
    public static class Utente
    {
        // Proprietà e campi statici per memorizzare lo stato dell'utente
        private static string username;
        private static string password;
        private static DateTime? dataOraLogin; // DateTime? /////
        private static List<DateTime> storicoAccessi = new List<DateTime>(); //////

        // Metodo per verificare se un utente è autenticato
        public static bool IsUtenteAutenticato()
        {
            return !string.IsNullOrEmpty(username) && dataOraLogin.HasValue;
        }

        // Metodo per effettuare il login
        public static void Login(string inputUsername, string inputPassword, string confermaPassword)
        {
            // Verifica che l'username non sia vuoto e che la password coincida con la conferma
            if (!string.IsNullOrEmpty(inputUsername) && inputPassword == confermaPassword)
            {
                // Imposta le informazioni dell'utente e registra l'accesso
                username = inputUsername;
                password = inputPassword;
                dataOraLogin = DateTime.Now;
                storicoAccessi.Add(dataOraLogin.Value);
                Console.WriteLine("Login effettuato con successo.");
            }
            else
            {
                Console.WriteLine("Errore durante il login. Controlla le credenziali.");
            }
        }

        // Metodo per effettuare il logout
        public static void Logout()
        {
            if (IsUtenteAutenticato())
            {
                Console.WriteLine($"Logout effettuato per l'utente {username}.");
                // Resetta le informazioni dell'utente durante il logout
                username = null;
                password = null;
                dataOraLogin = null;
            }
            else
            {
                Console.WriteLine("Errore durante il logout. Nessun utente loggato.");
            }
        }

        // Metodo per verificare l'ora e la data del login
        public static void VerificaOraDataLogin()
        {
            if (IsUtenteAutenticato())
            {
                Console.WriteLine($"Utente loggato alle {dataOraLogin.Value}.");
            }
            else
            {
                Console.WriteLine("Errore durante la verifica. Nessun utente loggato.");
            }
        }

        // Metodo per visualizzare la lista degli accessi
        public static void ListaAccessi()
        {
            if (storicoAccessi.Count > 0)
            {
                Console.WriteLine("Storico accessi:");
                foreach (var accesso in storicoAccessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun accesso registrato.");
            }
        }
    }
}
