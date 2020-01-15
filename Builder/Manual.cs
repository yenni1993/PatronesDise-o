using System.Collections.Generic;

namespace Builder
{
    public class Manual
    {
        public List<string> lstCarManualBuilder = new List<string>();

        public List<string> Add(string _cPart)
        {
            lstCarManualBuilder.Add(_cPart);
            return lstCarManualBuilder;
        }
    }
}
