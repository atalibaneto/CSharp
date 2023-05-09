<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankforU
{
    internal class Conta
    {
        public string Numero { get; }
        public string  Correntista { get; set; }
        public decimal Saldo { get; }

        private static int contaInicial = 1234567890;

        public Conta(string nome, decimal saldoInicial)
        {
            this.Correntista = nome;
            this.Saldo = saldoInicial;
            this.Numero = contaInicial.ToString();
            contaInicial++;
        }

        public void Depositar(decimal quantia, DateTime data, string note)
        {

        }
        public void Sacar(decimal quantia, DateTime data, string note)
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankforU
{
    internal class Conta
    {
        public string Numero { get; }
        public string  Correntista { get; set; }
        public decimal Saldo { get; }

        private static int contaInicial = 1234567890;

        public Conta(string nome, decimal saldoInicial)
        {
            this.Correntista = nome;
            this.Saldo = saldoInicial;
            this.Numero = contaInicial.ToString();
            contaInicial++;
        }

        public void Depositar(decimal quantia, DateTime data, string note)
        {

        }
        public void Sacar(decimal quantia, DateTime data, string note)
        {

        }
    }
}
>>>>>>> 60ece241b2c9c23917c7c5e10f8348a7aaf573c5
