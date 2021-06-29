using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
   public class Startwithcheck:IValidator
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
