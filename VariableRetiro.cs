using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Atm
{
    public sealed class VariableRetiro
    {
        public int OpcionRetiro { get; set; }

        public VariableRetiro(int OpcionRetiro)
        {
            this.OpcionRetiro = OpcionRetiro;
        }

        public static VariableRetiro MetodoRetiro { get; } = new VariableRetiro();

        public VariableRetiro() { }
    }
}
