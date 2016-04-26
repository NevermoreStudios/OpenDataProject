using System.Collections.Generic;

namespace OpenDataProject
{
    static class Core
    {
        public static List<Skola> Skole = new List<Skola>();
        public static Dictionary<string, List<Skola>> Queries= new Dictionary<string, List<Skola>>();

        public static List<Skola> GetFilter(string FilterKeyword)
        {
            if (FilterKeyword == "All") return Skole;
            else if (FilterKeyword == "None") return new List<Skola> { };
            else return Queries[FilterKeyword];
        }
    }
}