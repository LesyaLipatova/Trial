using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_4
{
    public class Evaluation_by_descendants : Leader
    {
        int P;
        double Qp;

        public Evaluation_by_descendants(string sername, int self_esteem, int evaluation_by_others, int P) : base (sername, self_esteem, evaluation_by_others)
        {
            this.P = P;
            this.Qp = set_Q(P);
        }

        public double set_Q(int P)
        {
            int Q = base.get_Q();
            return (0.3 * Q) + (0.7 * P);
        }

        public double get_Q()
        {
            return Qp;
        }
    }
}
