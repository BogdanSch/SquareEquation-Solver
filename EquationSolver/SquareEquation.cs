using System;

namespace EquationSolver
{
    public class SquareEquation
    {
        public SquareEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public SquareEquation(string equationString)
        {
            EquationString = equationString;
        }
        public string EquationString { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public string Solve()
        {
            D = GetDescriminant();

            if(D < 0)
            {
                return "Descriminant is less than 0, there are no solutions!";
            }
            else if(D == 0)
            {
                X1 = Math.Round(-B / (2 * A), 3);
                return $"Descriminant = 0, X = {X1}";
            }
            else
            {
                X1 = Math.Round(-B + Math.Sqrt(D) / 2 * A);
                X2 = Math.Round(-B - Math.Sqrt(D) / 2 * A);
                return $"D = {D}, X1 = {X1} and X2 = {X2}";
            }
        }
        private double GetDescriminant()
        {
            if(A == 0 && B == 0 && C == 0)
            {
                ParseEquation();
                return B * B - 4 * A * C;
            }
            return B * B - 4 * A * C;
        }
        private void ParseEquation()
        {
            A = B = C = 0;
            string equation = EquationString;

            equation = equation.Replace(" ", "");
            equation = equation.ToLower();

            if (equation.Contains("="))
            {
                string[] parts = equation.Split('=');

                if (parts.Length > 2) throw new Exception("Symbol = cannot be used more than one time!");

                string left = parts[0];
                string right = parts[1];

                right = right.Replace("+", "plus").Replace("-", "+").Replace("plus", "-");

                if (right[0] != '-' && right[0] != '+') right = right.Insert(0, "-");

                equation = left + right;
            }

            equation = equation.Replace("-", "+-");

            try
            {
                foreach (string item in equation.Split('+'))
                {
                    if (item == "") continue;

                    if (item.Contains("x2"))
                    {
                        if (item == "x2")
                            A++;
                        else if (item == "-x2")
                            A--;
                        else
                            A += double.Parse(item.Replace("x2", ""));
                    }
                    else if (item.Contains("x"))
                    {
                        if (item == "x")
                            B++;
                        else if (item == "-x")
                            B--;
                        else
                            B += double.Parse(item.Replace("x", ""));
                    }
                    else C += double.Parse(item);
                }
            }
            catch (Exception)
            {
                throw new Exception("Please enter correct expression!");
            }
        }
    }
}
