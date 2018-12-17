using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Framework
{
    public class ColumnDescriptionAttribute: Attribute
    {
        public string _description;
        public ColumnDescriptionAttribute(string Description)
        {
            _description = Description;
        }
    }
}
