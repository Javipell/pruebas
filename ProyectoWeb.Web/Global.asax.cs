﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ProyectoWeb.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["usuario"] = "todos";
            Application["tipoUsuario"] = "todos";
            Application["empresa"] = "JAVIPELL";
            Application["bienvenido"] = "DISEÑO ELEGANTE";
            Application["comentario"] = "Con la plantilla de sitio web adecuada, excelente y receptiva, podrá atraer visitantes y aumentar sus ventas. Este es un tema elegante diseñado para usos múltiples.";
            Application["opcion"] = "";
            Application["imagen"] = "";
            Application["destino"] = "#";
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}