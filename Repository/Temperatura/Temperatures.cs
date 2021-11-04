using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Temperatura
{
    public class Temperatures : Base<Temperature>, ITemperature
    {
        public List<Temperature> GetByDate(DateTime dateTime)
        {
            return Coleccion.Where(p => p.Fecha >= dateTime).ToList();
        }

        public List<Temperature> GetByTipoDeConversion(TipoDeConversion tipoDeConversion)
        {
            return Coleccion.Where(p => p.De == tipoDeConversion).ToList();
        }
    }
}

