using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMvc.Models.Enums
{
    public enum StatusVenda : int
    {
        Pendente = 1,
        Faturado = 2,
        Cancelado = 3
    }
}
