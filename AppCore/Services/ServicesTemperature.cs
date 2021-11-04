using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ServicesTemperature : Base<Temperature>, ITemperatureColeccion
    {
        private ITemperature Temperature;

        public ServicesTemperature(ITemperature Temperature) : base(Temperature)
        {
            this.Temperature = Temperature;
        }

        public List<Temperature> GetByDate(DateTime dateTime)
        {
            return Temperature.GetByDate(dateTime);
        }

        public List<Temperature> GetByTipoDeConversion(TipoDeConversion tipoDeConversion)
        {
            return Temperature.GetByTipoDeConversion(tipoDeConversion);
        }
    }
}
