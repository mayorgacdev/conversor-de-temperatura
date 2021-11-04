using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Temperatura
{
    public abstract class Base<T> : IColeccion<T>
    {
        protected List<T> Coleccion = new List<T>();

        public void Add(T t)
        {
            Coleccion.Add(t);
        }

        public List<T> FindAll()
        {
            return Coleccion;
        }
    }
}
