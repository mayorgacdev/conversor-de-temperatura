using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IResumen : IColeccion<Resumen>
    {
        List<Resumen> GetByDeA(TipoDeConversion De, TipoDeConversion A);

        List<Resumen> GetByDate(DateTime dateTime);
    }
}
