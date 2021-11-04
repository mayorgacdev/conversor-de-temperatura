using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class Base<T> : IServicesColeccion<T>
    {
        private IColeccion<T> Coleccion;

        public Base(IColeccion<T> coleccion)
        {
            this.Coleccion = coleccion;
        }

        public void Add(T t)
        {
            Coleccion.Add(t);
        }

        public List<T> FindAll()
        {
            return Coleccion.FindAll();
        }
    }
}
