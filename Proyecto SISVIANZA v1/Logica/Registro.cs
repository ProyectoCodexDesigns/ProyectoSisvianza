using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Proyecto_SISVIANZA_v1.Persistencia;

namespace Proyecto_SISVIANZA_v1.Logica
{

    class Registro
    {
        private RegistroPersistencia registroPersistencia;
        public Registro() => registroPersistencia = new RegistroPersistencia();
        public void Registrar(string ci, string password, string rol) => registroPersistencia.Registrar(ci, password, rol); 
        public Boolean VerificarRol(string rol) => registroPersistencia.VerificarRol(rol);
        public Boolean Cidiff(string ci) => registroPersistencia.Cidiff(ci);
    }
}
