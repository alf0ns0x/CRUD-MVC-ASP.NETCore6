﻿namespace CRUDCORE.Datos
{
    public class Contexto
    {
        public string Conexion { get; }

        public Contexto(string valor)
        {
            Conexion = valor;
        }
    }
}
