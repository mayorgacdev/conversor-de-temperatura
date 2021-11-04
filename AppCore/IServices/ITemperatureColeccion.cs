using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface ITemperatureColeccion : IServicesColeccion<Temperature>
    {
        List<Temperature> GetByTipoDeConversion(TipoDeConversion tipoDeConversion);

        List<Temperature> GetByDate(DateTime dateTime);
    }
}
