using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysDoc.Models
{
    public class ValidationResult<T>
    {
        public T Model { get; set; }
        public IList<string> ValidationErrors { get; set; }
        public bool IsValid { get { return !ValidationErrors.Any(); } }

        public ValidationResult()
        {
            ValidationErrors = new List<string>();
        }
    }
}
