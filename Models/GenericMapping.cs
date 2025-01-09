using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpplusSample.Models
{
    public class GenericMapping
    {
        public Maprule[] MapRules { get; set; }
    }

    public class Maprule
    {
        public string DbName { get; set; }
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public string Format { get; set; }
        public Rule[] Rules { get; set; }
    }

    public class Rule
    {
        public string Val { get; set; }
        public string AddToValue { get; set; }
        public string Unit { get; set; }
        public string Operand { get; set; }
        public string Compare { get; set; }
        public Action Action { get; set; }
    }

    public class Action
    {
        public string Backgorund { get; set; }
        public string ForeColor { get; set; }
        public bool FontBold { get; set; }
    }


}
