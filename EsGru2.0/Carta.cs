using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsGru2._0
{
    internal class Carta
    {
        private string numeroCarta;
        private string cvv;

        private ContoCorrente conto1;

        public ContoCorrente Conto1
        {
            get { return conto1; }
            set { conto1 = value; }
        }

        public string NumeroCarta
        {
            get { return numeroCarta; }
        }

        public string Cvv 
        {
            get { return cvv; } 
        }



        public Carta(ContoCorrente conto1, string numeroCarta, string cvv)
        {
            this.conto1= conto1;
            this.numeroCarta = numeroCarta;
            this.cvv = cvv;
        }
        public void InviaDenaro(double denaroInviato)
        {
            conto1.Saldo += denaroInviato;
        }
        public void PrelevaDenaro(double denaroPrelevato)
        {
            double n = conto1.Saldo - denaroPrelevato;
            if (n >= 0)
                conto1.Saldo -= denaroPrelevato;
            else return;
        }

    }
}
