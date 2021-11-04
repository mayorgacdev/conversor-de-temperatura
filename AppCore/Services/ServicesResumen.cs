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
    public class ServicesResumen : Base<Resumen>, IResumenServices
    {
        private IResumen Resumen;

        public ServicesResumen(IResumen Resumen) : base(Resumen)
        {
            this.Resumen = Resumen;
        }

        public List<Resumen> GetByDate(DateTime dateTime)
        {
            return Resumen.GetByDate(dateTime);
        }

        public List<Resumen> GetByDeA(TipoDeConversion De, TipoDeConversion A)
        {
            return Resumen.GetByDeA(De, A);
        }
    }
}
