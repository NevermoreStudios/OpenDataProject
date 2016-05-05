using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenDataProject
{
    static class Core
    {
        public static List<Skola> Skole = new List<Skola>();
        public static Dictionary<string, List<Skola>> Queries = new Dictionary<string, List<Skola>>();
        public static Dictionary<string, Vocab> Dict = new Dictionary<string, Vocab>();
        public static string CurrentLanguage = "English";

        public static List<Skola> GetFilter(string FilterKeyword)
        {
            Vocab vocab = GetVocab();
            if (FilterKeyword == vocab.all) return Skole;
            else if (FilterKeyword == vocab.none) return new List<Skola> { };
            else return Queries[FilterKeyword]; // TO DO: Implement
        }

        public static Vocab GetVocab()
        {
            Vocab a;
            if(Dict.TryGetValue(CurrentLanguage, out a)) return a;
            else
            {
                MessageBox.Show("Unable to get language, closing");
                Application.Exit();
                return null;
            }

        }
    }
}