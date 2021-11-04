using AppCore.IServices;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class Kelvin : IConversionDeTemperatura
    {
        public decimal ConversionDeTemperatura(decimal temperatura, TipoDeConversion caso)
        {
            if (caso is TipoDeConversion.Celsius)
            {
                return 1;
            }
            else if (caso is TipoDeConversion.Farenheit)
            {
                return 0;
            }
            else
            {
                return temperatura;
            }
        }
    }
}
