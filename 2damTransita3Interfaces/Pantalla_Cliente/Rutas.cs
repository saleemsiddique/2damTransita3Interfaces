﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    public class Rutas
    {
        public static string cliente = "cliente/RolUsuario";
        public static string usuarioMunicipio = "cliente/RolMunicipio";
        public static string incidencia = "incidencias";
        public static string zona = "zonas";
        public static string punto = "puntos";
        public static string modifyClienteEstado = "api/auth/cliente/modificarEstado/";
        public static string servidorImagenes = "127.0.0.1/img/imagenes/punto/";
        public static string incidenciaEnviada = "incidencia/estado/0";
        public static string incidenciaAceptada = "incidencia/estado/1";
        public static string incidenciaProceso = "incidencia/estado/2";
        public static string incidenciaFinalizada = "incidencia/estado/3";
        public static string clienteActivado = "cliente/RolUsuario/estado/0";
        public static string clienteDesactivado = "cliente/RolUsuario/estado/1";
        public static string imagenesPunto = "http://127.0.0.1/img/imagenes/punto/";


    }
}
