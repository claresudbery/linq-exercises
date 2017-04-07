using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Exercises
{
    static class Extensions
    {
        public static bool Something(this TestData2.Person thing)
        {
            return thing.FirstName.StartsWith("J");
        }

        public static bool SomethingElse(this TestData2.Address thing)
        {
            return thing.PostCode == "M12";
        }
    }
}
