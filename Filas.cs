using System;
using System.Text;

            internal class Filas
    {
        string[] _fila;
        int _tope;
    int _borrador;

        public Filas(int elementos)
        {
            _fila = new string[elementos];
            _tope = 0;
        _borrador = 0;
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
            if (_borrador == _fila.Length)
            {
            throw new Exception("La fila esta vacia");
            }
        if (String.IsNullOrWhiteSpace(_fila[_borrador]))
        {
            _borrador++;
            Console.WriteLine("Esta parte de la fila está vacia");

        }
        else
        {
            _fila[_borrador] = String.Empty;
            _borrador++;
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
