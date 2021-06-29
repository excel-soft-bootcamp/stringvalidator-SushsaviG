using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string data = "8";
            LengthValidator length = new LengthValidator();
            StringValidator _string = new StringValidator(length);
            _string.IsValidString(data);
            NullValidator _null = new NullValidator();
            StringValidator stringvalidator = new StringValidator(_null);
            stringvalidator.IsValidString(data);


   
        }
    }
}
