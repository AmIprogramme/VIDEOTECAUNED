/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Primer proyecto a realizar.
 */

using System;
using System.Windows.Forms;
using Tarea_1.Consultas;

namespace Tarea_1.Plantillas
{
    public partial class Menu : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();

        public Menu()
        {
            InitializeComponent();
        }

        public void declaracion_de_variable_de_datos(Gestor_de_registros datos) 
        {
            /*Para este caso, se estara usando la instancia de la clase "Gestor_de_registros"
             llamado del mismo nombre la variable, esto con el fin de manejar todo el programa
            en todo el tiempo de ejecución, esto con el fin de enviarlos a los siguientes
            procesos de las siguientes capaz, por lo cual también en las otras interfaces 
            también devolveran esta misma instancia para que genere una copia con todas las 
            modificaciones pertinentes dentro de este programa.*/

            gestor_de_datos = datos;
        }

        //-------------------------------------- Registros ---------------------------------------
        #region // Abrir registro de categoría

        /*Este código maneja la lógica para abrir un formulario de registro de categoría (Registrar_categoria). 
          Cuando el botón btn_registrar_categoria es clicado:

        1- Verifica si ya hay una instancia del formulario abierta.

        2- Verifica si hay datos de encargados registrados (a través de gestor_de_datos.Contador_1).
        
        3- Si ambas condiciones se cumplen, crea y muestra el formulario, pasando los datos necesarios y 
        suscribiéndose al evento de cierre del formulario.

        4- Si no hay datos de encargados, muestra un mensaje de advertencia.

        5- Cuando el formulario se cierra, el método volver_abrir1 se ejecuta, estableciendo la instancia del formulario 
        a null para permitir abrirlo nuevamente en el futuro.*/


        Registrar_categoria abrir_categoria;
        private void btn_registrar_categoria_Click(object sender, EventArgs e)
        {
            if (abrir_categoria == null)
            {
                abrir_categoria = new Registrar_categoria();
                abrir_categoria.FormClosed += new FormClosedEventHandler(volver_abrir1);
                abrir_categoria.declaracion_de_variable_de_datos(gestor_de_datos);
                abrir_categoria.Show();
            }
        }
        void volver_abrir1(object sender, EventArgs e) { abrir_categoria = null; }
        #endregion

        #region // Abrir registro de pelicula
        Registrar_pelicula abrir_R_Pelicula;
        private void btn_registrar_pelicula_Click(object sender, EventArgs e)
        {
            if (abrir_R_Pelicula == null)
            {
                if (gestor_de_datos.Contador_1 != 0)
                {
                    abrir_R_Pelicula = new Registrar_pelicula();
                    abrir_R_Pelicula.declaracion_de_variable_de_datos(gestor_de_datos);
                    abrir_R_Pelicula.FormClosed += new FormClosedEventHandler(volver_abrir2);
                    abrir_R_Pelicula.Show();
                }
                else { MessageBox.Show("Primero tiene que llenar datos en categoría posteriormente"); }
            }
        }
        void volver_abrir2(object sender, EventArgs e) { abrir_R_Pelicula = null; }



        #endregion

        #region // Abrir registro de encargado

        Registrar_encargado abrir_R_encargado;
        private void btn_registrar_encargado_Click(object sender, EventArgs e)
        {
            if (abrir_R_encargado == null)
            {
                abrir_R_encargado = new Registrar_encargado();
                abrir_R_encargado.declaracion_de_variable_de_datos(gestor_de_datos);
                abrir_R_encargado.FormClosed += new FormClosedEventHandler(volver_abrir3);
                abrir_R_encargado.Show();

            }

        }
        void volver_abrir3(object sender, EventArgs e) { abrir_R_encargado = null; }

        #endregion

        #region // Abrir registro de sucursal
        Registrar_sucursal abrir_R_Sucursal;
        private void btn_registrar_sucursal_Click(object sender, EventArgs e)
        {
            if (abrir_R_Sucursal == null)
            {
                if (gestor_de_datos.Contador_3 != 0)
                {
                    abrir_R_Sucursal = new Registrar_sucursal();
                    abrir_R_Sucursal.declaracion_de_variable_de_datos(gestor_de_datos);
                    abrir_R_Sucursal.FormClosed += new FormClosedEventHandler(volver_abrir4);
                    abrir_R_Sucursal.Show();
                }
                else { MessageBox.Show("No puede acceder a esta sección sin antes registrar datos de encargados"); }
            }
        }
        void volver_abrir4(object sender, EventArgs e) { abrir_R_Sucursal = null; }

        #endregion

        #region // Abrir registrar clientes

        Registrar_cliente abrir_R_Cliente;
        private void btn_registrar_cliente_Click(object sender, EventArgs e)
        {
            if(abrir_R_Cliente == null)
            {
                abrir_R_Cliente = new Registrar_cliente();
                abrir_R_Cliente.FormClosed += new FormClosedEventHandler(volver_abrir5);
                abrir_R_Cliente.Show();
            }
        }
        void volver_abrir5(object sender, EventArgs e) { abrir_R_Cliente = null; }

        #endregion

        #region // Abrir registrar peliculas por sucursal
        Registrar_peliculaxsucursal abrir_R_Peliculaxsucursal;
        private void btn_registrar_peliculaxsurcusal_Click(object sender, EventArgs e)
        {
            if (abrir_R_Peliculaxsucursal == null)
            {
                if (gestor_de_datos.Contador_2 != 0 && gestor_de_datos.Contador_4 != 0)
                {
                    abrir_R_Peliculaxsucursal = new Registrar_peliculaxsucursal();
                    abrir_R_Peliculaxsucursal.declaracion_de_variable_de_datos(gestor_de_datos);
                    abrir_R_Peliculaxsucursal.FormClosed += new FormClosedEventHandler(volver_abrir6);
                    abrir_R_Peliculaxsucursal.Show();
                }
                else { MessageBox.Show("No puede acceder a esta sección sin antes registrar datos de sucursal y de películas."); 
            }

        }

    }
        void volver_abrir6(object sender, EventArgs e) { abrir_R_Peliculaxsucursal = null; }


        #endregion

//----------------------------------------- Consultas ---------------------------------

        #region // Abrir consulta de categoría
        Consultar_categoria abrir_C_categoria;
        private void btn_consulta_categoria_Click(object sender, EventArgs e)
        {
            if (abrir_C_categoria == null)
            {
                if (gestor_de_datos.Contador_1 != 0)
                {
                    abrir_C_categoria = new Consultar_categoria();
                    abrir_C_categoria.establecer_instancia(gestor_de_datos);
                    abrir_C_categoria.FormClosed += new FormClosedEventHandler(volver_abrir7);
                    abrir_C_categoria.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
            }
        }
        void volver_abrir7(object sender, EventArgs e) { abrir_C_categoria = null; }


        #endregion

        #region // Abrir consulta de peliculas
        Consultar_pelicula abrir_C_pelicula;

        private void btn_consulta_pelicula_Click(object sender, EventArgs e)
        {
            if (abrir_C_pelicula == null)
            {
                if (gestor_de_datos.Contador_2 != 0)
                {
                    abrir_C_pelicula = new Consultar_pelicula();
                    abrir_C_pelicula.establecer_instancia(gestor_de_datos);
                    abrir_C_pelicula.FormClosed += new FormClosedEventHandler(volver_abrir8);
                    abrir_C_pelicula.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
                
            }
        }
        void volver_abrir8(object sender, EventArgs e) { abrir_C_pelicula = null; }

        #endregion

        #region // Abrir consulta de encargado
        Consultar_encargado abrir_consulta_de_encargado;
        private void btn_consultar_encargado_Click(object sender, EventArgs e)
        {
            if (abrir_consulta_de_encargado == null)
            {
                if (gestor_de_datos.Contador_3 != 0)
                {
                    abrir_consulta_de_encargado = new Consultar_encargado();
                    abrir_consulta_de_encargado.establecer_instancia(gestor_de_datos);
                    abrir_consulta_de_encargado.FormClosed += new FormClosedEventHandler(volver_abrir9);
                    abrir_consulta_de_encargado.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
            }
        }
        void volver_abrir9(object sender, EventArgs e) { abrir_consulta_de_encargado = null; }


        #endregion

        #region // Abrir consulta de sucursal
        Consultar_sucursal abrir_consulta_de_sucursal;

        private void btn_consultar_sucursal_Click(object sender, EventArgs e)
        {
            if (abrir_consulta_de_sucursal == null)
            {
                if (gestor_de_datos.Contador_4 != 0)
                {
                    abrir_consulta_de_sucursal = new Consultar_sucursal();
                    abrir_consulta_de_sucursal.establecer_instancia(gestor_de_datos);
                    abrir_consulta_de_sucursal.FormClosed += new FormClosedEventHandler(volver_abrir10);
                    abrir_consulta_de_sucursal.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
            }
        }
        void volver_abrir10(object sender, EventArgs e) { abrir_consulta_de_sucursal = null; }
        #endregion

        #region // Abrir consulta de cliente
        Consultar_cliente abrir_C_cliente;
        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {
            if (abrir_C_cliente == null)
            {
                if (gestor_de_datos.Contador_1 != 0)
                {
                    abrir_C_cliente = new Consultar_cliente();
                    abrir_C_cliente.establecer_instancia(gestor_de_datos);
                    abrir_C_cliente.FormClosed += new FormClosedEventHandler(volver_abrir11);
                    abrir_C_cliente.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
            }
        }
        void volver_abrir11(object sender, EventArgs e) { abrir_C_cliente = null; }




        #endregion

        #region // Abrir consulta de peliculas por hotel
        Consultar_peliculaxSucursal abrir_C_peliculaXsucursal;
        private void btn_C_peliculaxsucursal_Click(object sender, EventArgs e)
        {
            if (abrir_C_peliculaXsucursal == null)
            {
                if (gestor_de_datos.Contador_6 != 0) 
                {
                    abrir_C_peliculaXsucursal = new Consultar_peliculaxSucursal();
                    abrir_C_peliculaXsucursal.declaracion_de_variable_de_datos(gestor_de_datos);
                    abrir_C_peliculaXsucursal.FormClosed += new FormClosedEventHandler(volver_abrir12);
                    abrir_C_peliculaXsucursal.Show();
                }
                else { MessageBox.Show("No hay datos que mostrar aún."); }
            }
        }
        void volver_abrir12(object sender, EventArgs e) { abrir_C_peliculaXsucursal = null; }
        #endregion
    }
}
