using System;
using System.Collections.Generic;
using System.Text;

namespace FilaArreglos
{
    internal class Filas
    {
        string[] _fila;
        int _tope;
        int _eliminar;


        public Filas(int elementos)
        {
            _fila = new string[elementos];
            _tope = 0;
            _eliminar = 0;
        }

        public void Agregar(string dato)
        {
            if (_tope == _fila.Length)
            {
                throw new Exception("La fila esta llena");
            }
            _fila[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (_eliminar == _tope)
            {
                throw new Exception("La fila esta vacia");
            }
            _fila[_eliminar] = string.Empty;
            _eliminar++;
            
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < _tope; i++)
            {
                datos.AppendLine(_fila[i]);
            }
            return datos.ToString();

        }
    }
}
