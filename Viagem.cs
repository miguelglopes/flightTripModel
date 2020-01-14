using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.OrTools.LinearSolver;

namespace modeloViagensAviao
{
    class Viagem
    {
        String from = null; 
        String to = null;
        DateTime date = new DateTime();
        public Double price = 0;
        int weekday = 0;
        public Variable variable = null;

        public string id
        {
            get { return from + "-" + to + "_" + date; }
        }

    }

    class Viagens : List<Viagem>
    {

    }
}
