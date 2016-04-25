using System.Collections.Generic;

namespace OpenDataProject
{
    static class Core
    {
        public static List<Skola> Skole = new List<Skola>();
        public static List<List<Skola>> Queries= new List<List<Skola>>();
        public static List<string> Linker = new List<string>();

        public static List<Skola> GetFilter(string FilterKeyword)
        {
            if (FilterKeyword == "All") return Skole;
            else if (FilterKeyword == "None") return new List<Skola> { };
            else return Queries[Linker.IndexOf(FilterKeyword)];
        }
    }
}