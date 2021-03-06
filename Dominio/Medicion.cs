﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Validations;

namespace Dominio
{
    public class Medicion : Modelo<Medicion>
    {
        public virtual DateTime Fecha { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual Indicador Indicador { get; set; }
        public virtual string Detalle { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType()) return false;

            Medicion specificOject = (Medicion)obj;
            return (this.Fecha == specificOject.Fecha && this.Indicador == specificOject.Indicador);
        }

        public Medicion()
        {
            Validator = new MedicionValidator();
        }
    }
}
