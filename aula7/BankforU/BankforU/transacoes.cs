<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankforU
{
    internal class transacoes
    {
        public decimal Montante { get; }
        public DateTime Data { get; }
        public string Notes { get; }

        public transacoes(decimal montante, DateTime data, string note)
        {
            this.Montante = montante;
            this.Data = data;
            this.Notes = note;
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
    internal class transacoes
    {
        public decimal Montante { get; }
        public DateTime Data { get; }
        public string Notes { get; }

        public transacoes(decimal montante, DateTime data, string note)
        {
            this.Montante = montante;
            this.Data = data;
            this.Notes = note;
        }
    }
}
>>>>>>> 60ece241b2c9c23917c7c5e10f8348a7aaf573c5
