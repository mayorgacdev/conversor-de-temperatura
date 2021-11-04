using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resumen
    {
        public TipoDeConversion De { get; set; }

        public TipoDeConversion A { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Resultado { get; set; }
    }
}
