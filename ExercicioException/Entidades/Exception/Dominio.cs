using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioException.Entidades.Exception
{
    class Dominio : ApplicationException
    {
        public Dominio(string message) : base(message)
        {
        }
    }
}

