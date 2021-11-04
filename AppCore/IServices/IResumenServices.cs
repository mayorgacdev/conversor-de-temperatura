using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IResumenServices : IServicesColeccion<Resumen>
    {
        List<Resumen> GetByDeA(TipoDeConversion De, TipoDeConversion A);

        List<Resumen> GetByDate(DateTime dateTime);

    }
}
