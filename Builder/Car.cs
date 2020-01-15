using System.Collections.Generic;

namespace Builder
{
    public class Car
    {
        public List<string> lstCarBuilder { get; set; }

        public Car()
        {
            lstCarBuilder = new List<string>();
        }

        public List<string> Add(string _cPart)
        {
            lstCarBuilder.Add(_cPart);
            return lstCarBuilder;
        }
    }
}
