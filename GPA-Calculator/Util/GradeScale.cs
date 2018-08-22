using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Util
{
    public class GradeScale
    {
        public virtual double A_PLUS { get; }
        public virtual double A { get; }
        public virtual double A_MINUS { get; }
        public virtual double B_PLUS { get; }
        public virtual double B { get; }
        public virtual double B_MINUS { get; }
        public virtual double C_PLUS { get; }
        public virtual double C { get; }
        public virtual double C_MINUS { get; }
        public virtual double D_PLUS { get; }
        public virtual double D { get; }
        public virtual double D_MINUS { get; }

        public virtual Dictionary<string, double> GradeLetterMapping { get; protected set; }
        public virtual Dictionary<double, double> GradeLowestNumericMapping { get; protected set; }
    }
}
