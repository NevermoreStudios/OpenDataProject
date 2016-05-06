using System.Collections.Generic;

namespace OpenDataProject
{
    class Vocab
    {
        public string viewData, filter, sort, chart, map, changeLanguage, error, loaderTitle,
                      other, language, help, about, tools, queryPickerTitle, use, all, none,
                      view, id, name, address, control, website, phone, fax, type, numClasses,
                      location, county;
        public string[] chartOptions1, chartOptions2;
        public Dictionary<string, string> errors;
        public string Error(string reason)
        {
            string realReason;
            if (errors.TryGetValue(reason, out realReason)) return error + " " + realReason;
            else return null;
        }
    }
}
