﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class CapaDatosException:Exception
    {
        public CapaDatosException(string mensaje) : base(mensaje) { }
    }
}
