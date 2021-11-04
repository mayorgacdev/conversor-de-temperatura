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
    public class ResumenRepository : Base<Resumen>, IResumen
    {
        public List<Resumen> GetByDate(DateTime dateTime)
        {
            return (from e in Coleccion where e.Fecha >= dateTime select e).ToList();
        }

        public List<Resumen> GetByDeA(TipoDeConversion De, TipoDeConversion A)
        {
            return (from t in Coleccion where t.De == De && t.A == A select t).ToList();
        }
    }
}
