using System.Collections.Generic;
using System.IO;
using PONTODIGITAL.Models;

namespace PONTODIGITAL.Repositorios {
    public class FaqRepositorio {
        private const string PATH = "Database/Comentario.csv";

        public static uint CONT = 0;

        private const string PATH_FAQ = "Database/FAQ_Id.csv";

        // private const string PATH_FAQ = "Database/Comentario.csv";

        private List<Faq> clientes = new List<Faq> ();

        public FaqRepositorio () {
            if (!File.Exists (PATH_FAQ)) {
                File.Create (PATH_FAQ).Close ();
            }

            var ultimoIndice = File.ReadAllText (PATH_FAQ);
            uint indice = 0;
            uint.TryParse (ultimoIndice, out indice);
            CONT = indice;
        }
        public bool Inserir (Faq coment) {
            CONT++;
            File.WriteAllText (PATH_FAQ, CONT.ToString ());

            string linha = PrepararRegistroCSV (coment);
            File.AppendAllText (PATH, linha);

            return true;
        }
        private string PrepararRegistroCSV (Faq coment) {
            return $"Comentario = {coment}\n";
        }
    }
}