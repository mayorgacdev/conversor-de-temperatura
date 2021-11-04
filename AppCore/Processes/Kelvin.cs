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
                return (temperatura + 273.15M);
            }
            else if (caso is TipoDeConversion.Farenheit)
            {
                return ((9*(temperatura - 273.5M)/5) + 32);
            }
            else
            {
                return temperatura;
            }
        }
    }
}
