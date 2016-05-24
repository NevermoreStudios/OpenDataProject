using System.Collections.Generic;

namespace OpenDataProject
{
    class Vocab
    {
        public string viewData, filter, sort, chart, map, changeLanguage, error, loaderTitle,
                      other, language, help, about, tools, queryPickerTitle, use, all, none,
                      view, id, name, address, control, website, phone, fax, type, numClasses,
                      location, county, ok, version, appdesc, teammembers, mentor, at, and, professor,
                      mg, rg, grade, addAsQuery, increase, decrease, add, viewer;
        public string[] chartOptions1, chartOptions2;
        public Dictionary<string, string> errors;
        public string Error(string reason)
        {
            string realReason;
            if (errors.TryGetValue(reason, out realReason)) return error + " " + realReason;
            else return null;
        }
        public string[] GetRow()
        {
            return new string[] { id, name, address, chartOptions1[0], chartOptions1[1], chartOptions1[2], chartOptions1[3], chartOptions1[4], website, phone, fax, chartOptions1[5], numClasses, location };
        }
    }
}
