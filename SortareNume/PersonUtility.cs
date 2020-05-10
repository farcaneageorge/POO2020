using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SortareNume
{
    class PersonUtility
    {
        public static void SortNames(List<Person> persons)
        {
            StringComparer compare = StringComparer.Create(new CultureInfo("ro-RO"), true);


        }
    }
}