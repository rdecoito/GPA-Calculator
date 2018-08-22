using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Util
{
    public class FourPointGradeScale : GradeScale
    {
        // Uses College Board 4.0 scale
        // https://pages.collegeboard.org/how-to-convert-gpa-4.0-scale
        public override double A_PLUS { get; } = 4.0;
        public override double A { get; } = 4.0;
        public override double A_MINUS { get; } = 3.67;
        public override double B_PLUS { get; } = 3.33;
        public override double B { get; } = 3.0;
        public override double B_MINUS { get; } = 2.67;
        public override double C_PLUS { get; } = 2.33;
        public override double C { get; } = 2.0;
        public override double C_MINUS { get; } = 1.67;
        public override double D_PLUS { get; } = 1.33;
        public override double D { get; } = 1.0;
        public override double D_MINUS { get; } = 0.0;

        public override Dictionary<string, double> GradeLetterMapping { get; protected set; }
        public override Dictionary<double, double> GradeLowestNumericMapping { get; protected set; }
        
        public FourPointGradeScale()
        {
            GradeLetterMapping = new Dictionary<string, double>()
            {
                { "A+", A_PLUS },
                { "A", A },
                { "A-", A_MINUS },
                { "B+", B_PLUS },
                { "B", B },
                { "B-", B_MINUS },
                { "C+", C_PLUS },
                { "C", C },
                { "C-", C_MINUS },
                { "D+", D_PLUS },
                { "D", D },
                { "D-", D_MINUS }
            };

            GradeLowestNumericMapping = new Dictionary<double, double>()
            {
                { 97, A_PLUS },
                { 93, A },
                { 90, A_MINUS },
                { 87, B_PLUS },
                { 83, B },
                { 80, B_MINUS },
                { 77, C_PLUS },
                { 73, C },
                { 70, C_MINUS },
                { 67, D_PLUS },
                { 63, D },
                { 0, D_MINUS }
            };
        }
    }
}
