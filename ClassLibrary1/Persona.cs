﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona {

        String nombre, apellido ,direccion;

        public Persona(String nombre, String apellido, String direccion) { 
            this.nombre = nombre;
            this.apellido = apellido;   
            this.direccion = direccion;
        }

        public String getNombre() {  return nombre; }
        
        public void setNombre(String nombre) { this.nombre = nombre; }
        public String getApellido() {  return apellido; }

        public void setApellido(String apellido) { this.apellido = apellido; }

        public String getDireccion() {  return direccion; }

        public void setDireccion(String direccion) { this.direccion = direccion; }


    }
}
