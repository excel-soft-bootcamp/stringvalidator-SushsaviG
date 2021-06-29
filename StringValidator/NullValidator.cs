using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class NullValidator:IValidator
    {
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }
}
