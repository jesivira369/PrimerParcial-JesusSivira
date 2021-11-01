using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial_JesusSivira
{
    class Producto
    {

        private int codigo;
        private string descripcion;
        private float precio;
        public Producto(int codigo, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} \n Descripcion: {1} \n Precio: {2} \n", GetCodigo(), GetDescripcion(), GetPrecio());
        }

    }
}
