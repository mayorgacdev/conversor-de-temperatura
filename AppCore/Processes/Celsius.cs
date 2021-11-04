using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class Celsius : IConversionDeTemperatura
    {
        public decimal ConversionDeTemperatura(decimal temperatura, TipoDeConversion caso)
        {
            if (caso is TipoDeConversion.Farenheit)
            {
                return ((1.8M) * temperatura + 32);
            }
            else if(caso is TipoDeConversion.Kelvin)
            {
                return (temperatura + 273.15M);
            }
            else
            {
                return temperatura;
            }
        }

        public List<Temperature> GetByTipoDeConversion(TipoDeConversion tipoDeConversion)
        {
            throw new NotImplementedException();
        }
    }
}
