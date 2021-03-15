using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Exceptions;

namespace Negocio
{
    public class admCategorias
    {
        public List<Categoria> Listar()
        {
            try { 
            return new dbCategorias().Listar();
            }
            catch(SqlException ex)
            {
                throw new CapaDatosException("No se pudo conectar a la BD - " + ex.ToString());
            }
        }
    }
}
