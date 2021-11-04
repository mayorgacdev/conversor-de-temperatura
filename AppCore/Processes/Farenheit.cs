using AppCore.IServices;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class Farenheit : IConversionDeTemperatura
    {
        public decimal ConversionDeTemperatura(decimal temperatura, TipoDeConversion caso)
        {
            if (caso is TipoDeConversion.Celsius)
            {
                return ((temperatura - 32)/(1.8M));
            }
            else if (caso is TipoDeConversion.Kelvin)
            {
                return (((temperatura - 32) / (1.8M)) + 273.15M);
            }
            else
            {
                return temperatura;
            }
        }
    }
}
