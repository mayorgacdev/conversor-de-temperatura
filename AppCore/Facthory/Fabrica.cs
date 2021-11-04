using AppCore.IServices;
using AppCore.Processes;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Facthory
{
    public class Fabrica
    {
        public static IConversionDeTemperatura CreateInstance(TipoDeConversion caso)
        {
            if (caso is TipoDeConversion.Celsius)
            {
                return new Celsius();
            }
            else if (caso is TipoDeConversion.Farenheit)
            {
                return new Farenheit();
            }
            else if (caso is TipoDeConversion.Kelvin)
            {
                return new Kelvin();
            }
            else
            {
                return null;
            }

        }
    }
}
