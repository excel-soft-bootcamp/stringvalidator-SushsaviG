using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
   public class StringValidator
    {
        IValidator _validate;
        public StringValidator(IValidator validate)
        {
            this._validate = validate;
        }
        public bool IsValidString(string data)
        {
            return _validate.IsValidString(data);
        }
    }
    public interface IValidator
    {
         bool IsValidString(string data);
    }
}
