using EquationSolver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationForm
{
    public partial class SolveForm : Form
    {
        public SolveForm()
        {
            InitializeComponent();
        }

        private void bSolve_Click(object sender, EventArgs e)
        {
            string equation = tInput.Text;

            SquareEquation squareEquation = new SquareEquation(equation);
            lResult.Text = squareEquation.Solve();
        }
    }
}
