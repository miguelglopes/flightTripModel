using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.OrTools.LinearSolver;


namespace modeloViagensAviao
{
    class Program
    {
        static void Main(string[] args)
        {
            Viagens viagens = new Viagens();

            //Solver solver = Solver.CreateSolver("realFever", "GLOP_LINEAR_PROGRAMMING");
            Solver solver = Solver.CreateSolver("realFever", "CBC_MIXED_INTEGER_PROGRAMMING");

            #region DECISIONS
            foreach (Viagem v in viagens)
                v.variable = solver.MakeBoolVar(v.id);
            #endregion

            #region GOALS
            Objective objective = solver.Objective();
            foreach (Viagem v in viagens)
                objective.SetCoefficient(v.variable, v.price);
            objective.SetMinimization();
            #endregion
        }
    }
}
