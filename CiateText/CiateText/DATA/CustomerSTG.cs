using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiateText.DATA
{
    class CustomerSTG
    {
        public string NumInscription { get; set; }
        public string NomPrenom { get; set; }

        public int NumeroGroupe { get; set; }
        public override string ToString()
        {
            return NomPrenom;
        }
    }
}
