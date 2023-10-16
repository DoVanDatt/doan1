using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOL
{
    public class setDate
    {

        public static string ConvertDateTime(string date)
        {
            string c = date.Remove(10);
            string[] elements = c.Split('/');
            string dt = string.Format("{2}/{0}/{1}", elements[0], elements[1], elements[2]);

            return dt;
        }
    }
}
