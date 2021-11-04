using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITemperature : IColeccion<Temperature>
    {
        List<Temperature> GetByTipoDeConversion(TipoDeConversion tipoDeConversion);

        List<Temperature> GetByDate(DateTime dateTime);
    }
}
