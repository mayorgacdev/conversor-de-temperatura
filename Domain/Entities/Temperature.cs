using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Temperature
    {
        public Temperature(decimal medicion)
        {
            this.Medicion = medicion;
        }

        public int Id { get; set; }

        public decimal Medicion { get; set; }

        public DateTime Fecha { get; set; }

        public TipoDeConversion De { get; set; }

        public TipoDeConversion A { get; set; }
    }
}
