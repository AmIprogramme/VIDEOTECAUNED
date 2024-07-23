/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_de_entidades;

namespace Capa_de_Acceso_a_Datos
{
    public class Gestor_de_registros
    {
        private static string direccion_sql = "Server= CUPPZ15762\\SQLEXPRESS; Database= VIDEOTECAUNED; Integrated Security=True;;";
        private SqlConnection conexion = new SqlConnection(direccion_sql);

        #region Registro de datos

        /*
         En esta clase únicamente se usará esta función para registrar todos los movimientos 
        que en la base de datos se vaya a insertar.

        Todas las instancias tienen que hacer un query y así enviarlo en forma de cadena
        para así solo proceder en una sola.
         */
        public void Registrar_datos_en_sql(String query)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void Registrar_PeliculaxSucursal(List<PeliculaxSucursal> px)
        {
            try
            {
                conexion.Open();

                foreach (PeliculaxSucursal pelicula in px)
                {
                    // Definir la consulta SQL para insertar los datos
                    String query = "INSERT INTO PeliculaxSucursal ( IdSucursal, IdPelicula, Cantidad) VALUES (@IdSucursal, @IdPelicula, @Cantidad)";

                    // Configurar el comando SQL
                    SqlCommand comando = new SqlCommand(query, conexion);
   
                    comando.Parameters.AddWithValue("@IdSucursal", pelicula.Sucursal!.Id_de_sucursal);
                    comando.Parameters.AddWithValue("@IdPelicula", pelicula.Filmes!.Id_de_pelicula);
                    comando.Parameters.AddWithValue("@Cantidad", pelicula.Cantidad);
                    // Añadir más parámetros según las columnas que tengas en tu tabla

                    // Ejecutar la consulta SQL
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, puedes registrar el error o lanzar una excepción según sea necesario
                Console.WriteLine("Error al registrar películas en sucursal: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión, incluso si ocurre un error
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        #endregion

        #region Retorno de datos

        #region Categoria
        public List<CategoriaPelicula> retorno_lista_CATEGORIA_PELICULAS()
        {
            List<CategoriaPelicula> arreglo_global = new List<CategoriaPelicula>();

            try
            {
                conexion.Open();
                String query = "Select IdCategoria, NombreCategoria, Descripcion from CategoriaPelicula;";
                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    CategoriaPelicula objeto = new CategoriaPelicula()
                    {
                        Id_de_categoria = Convert.ToInt32(reader["IdCategoria"]),
                        Nombre_de_la_categoria = (String)reader["NombreCategoria"],
                        Descripcion = (String)reader["Descripcion"]
                    };
                    arreglo_global.Add(objeto);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close();}
            }

            return arreglo_global;
        }

        #endregion

        #region Películas
        public List<Pelicula> retorno_arreglo_PELICULAS()
        {
            List<Pelicula> arreglo_global = new List<Pelicula>();

            try
            {
                conexion.Open();

                string query = "SELECT CategoriaPelicula.IdCategoria, NombreCategoria, Descripcion, Pelicula.IdPelicula, Titulo, AnioLanzamiento, Idioma " +
                               "FROM Pelicula INNER JOIN CategoriaPelicula ON CategoriaPelicula.IdCategoria = Pelicula.IdCategoria";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear objeto CategoriaPelicula
                            CategoriaPelicula objeto_categoria = new CategoriaPelicula()
                            {
                                Id_de_categoria = reader["IdCategoria"] is DBNull ? 0 : Convert.ToInt32(reader["IdCategoria"]),
                                Nombre_de_la_categoria = reader["NombreCategoria"] is DBNull ? string.Empty : (string)reader["NombreCategoria"],
                                Descripcion = reader["Descripcion"] is DBNull ? string.Empty : (string)reader["Descripcion"]
                            };
                            // Crear objeto Pelicula
                            Pelicula objeto = new Pelicula()
                            {
                                Id_de_pelicula = reader["IdPelicula"] is DBNull ? 0 : Convert.ToInt32(reader["IdPelicula"]),
                                Titulo = reader["Titulo"] is DBNull ? string.Empty : (string)reader["Titulo"],
                                Categoria_pelicula = objeto_categoria,
                                Ano_de_lanzamiento = reader["AnioLanzamiento"] is DBNull ? 0 : Convert.ToInt32(reader["AnioLanzamiento"]),
                                Idioma = reader["Idioma"] is DBNull ? string.Empty : (string)reader["Idioma"]
                            };

                            arreglo_global.Add(objeto);
                        }
                    }
                }

                conexion.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return arreglo_global;
        }

        #endregion

        #region Persona 
        public List<Persona> retorno_arreglo_Persona()
        {
            List<Persona> arreglo_global = new List<Persona>();

            try
            {
                conexion.Open();
                

                String query = "Select Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento from Persona";

                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Persona objeto = new Persona()
                        {
                            Identificacion = (String)reader["Identificacion"],
                            Nombre = (String)reader["Nombre"],
                            Primer_apellido = (String)reader["PrimerApellido"],
                            Segundo_apellido = (String)reader["SegundoApellido"],
                            Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!)
                        };
                        arreglo_global.Add(objeto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }

            return arreglo_global;
        }
        #endregion

        #region Persona por id
        public Persona retorno_variable_Persona_por_id(String id)
        {     
            try
            {
                conexion.Open();
                String query = "Select Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento from Persona where Identificacion = " + id + " ";

                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // Se comprueba que la tabla tiene datos 
                {
                    while (reader.Read())
                    {

                        if (reader["Identificacion"].ToString() == id)
                        {
                            Persona objeto = new Persona()
                            {
                                Identificacion = reader["Identificacion"].ToString()!,
                                Nombre = reader["Nombre"].ToString()!,
                                Primer_apellido = reader["PrimerApellido"].ToString()!,
                                Segundo_apellido = reader["SegundoApellido"].ToString()!,
                                Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!)
                            };

                            return objeto;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }
            
            return null!;
        }
        #endregion

        #region Encargado
        public List<Encargado> retorno_arreglo_ENCARGADO()
        {
            conexion.Open();
            List<Encargado> arreglo_global = new List<Encargado>();

            String query = "Select IdEncargado, Encargado.Identificacion, Nombre, PrimerApellido, SegundoApellido, \r\nFechaNacimiento, FechaIngreso\r\nfrom Encargado Inner join Persona \r\non Encargado.Identificacion = Persona.Identificacion";

            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Encargado objeto = new Encargado()
                {
                    Id_Encargado = Convert.ToInt32(reader["IdEncargado"]),
                    Identificacion = reader["Identificacion"].ToString()!,
                    Nombre = reader["Nombre"].ToString()!,
                    Primer_apellido = reader["PrimerApellido"].ToString()!,
                    Segundo_apellido = reader["SegundoApellido"].ToString()!,
                    Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                    Fecha_de_ingreso = DateTime.Parse(reader["FechaIngreso"].ToString()!)
                };
                arreglo_global.Add(objeto);
            }

            conexion.Close();
            return arreglo_global;
        }
        #endregion

        #region Sucursal
        public List<Sucursal> retorno_arreglo_SUCURSAL()
        {
            List<Sucursal> arreglo_global = new List<Sucursal>();

            conexion.Open();
            String query = "select IdSucursal, Sucursal.Nombre 'Nombre_Sucursal', Direccion, Telefono, Activo, Encargado.IdEncargado, Encargado.Identificacion, Persona.Nombre 'Nombre_Personaje', Persona.PrimerApellido, Persona.SegundoApellido,Persona.FechaNacimiento, Encargado.FechaIngreso from Sucursal inner join Encargado on Sucursal.IdEncargado = Encargado.IdEncargado Inner join Persona on Persona.Identificacion = Encargado.Identificacion";

            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Encargado objeto_encargado = new Encargado()
                {
                   Id_Encargado = Convert.ToInt32(reader["IdEncargado"]),
                   Identificacion = reader["Identificacion"].ToString()!,
                   Nombre = reader["Nombre_Personaje"].ToString()!,
                   Primer_apellido = reader["PrimerApellido"].ToString()!,
                   Segundo_apellido = reader["SegundoApellido"].ToString()!,
                   Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                   Fecha_de_ingreso = DateTime.Parse(reader["FechaIngreso"].ToString()!)
                };
               
                Sucursal objeto_sucursal = new Sucursal()
                {
                    Id_de_sucursal = Convert.ToInt32(reader["IdSucursal"]),
                    Nombre = reader["Nombre_Sucursal"].ToString()!,
                    _Encargado = objeto_encargado,
                    Direccion = reader["Direccion"].ToString()!,
                    Telefono = reader["Telefono"].ToString()!,
                    Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                };
                arreglo_global.Add(objeto_sucursal);

            }
            reader.Close();
            conexion.Close();
            return arreglo_global;
        }

        #endregion

        #region Cliente
        public List<Cliente> retorno_arreglo_CLIENTE()
        {
            List<Cliente> arreglo_global = new List<Cliente>();

            try
            {   conexion.Open();
                String query = "Select IdCliente, Persona.Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento,FechaRegistro, Activo from Cliente inner join Persona on Cliente.Identificacion = Persona.Identificacion";

                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente objeto = new Cliente()
                        {
                            Id_Cliente = Convert.ToInt32(reader["IdCliente"].ToString()!),
                            Identificacion = reader["Identificacion"].ToString()!,
                            Nombre = reader["Nombre"].ToString()!,
                            Primer_apellido = reader["PrimerApellido"].ToString()!,
                            Segundo_apellido = reader["SegundoApellido"].ToString()!,
                            Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                            Fecha_de_registro = DateTime.Parse(reader["FechaRegistro"].ToString()!),
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };
                        arreglo_global.Add(objeto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }

            return arreglo_global;



        }

        #endregion

        #region Películas por sucursal
        public List<PeliculaxSucursal> retorno_lista_PELICULA_POR_SUCURSAL()
        {
            List<PeliculaxSucursal> arreglo_global = new List<PeliculaxSucursal>();
            try
            {
                conexion.Open();
                String query = "Select " +
                    "Sucursal.IdSucursal, Sucursal.Nombre 'Nombre_Sucursal', Sucursal.Direccion, Sucursal.Telefono, Sucursal.Activo," +
                    " Encargado.IdEncargado, Encargado.Identificacion, Encargado.FechaIngreso," +
                    " Persona.Nombre 'Nombre_Persona', Persona.PrimerApellido, Persona.SegundoApellido, Persona.FechaNacimiento," +
                    " Pelicula.IdPelicula, Pelicula.Titulo, Pelicula.AnioLanzamiento, Pelicula.Idioma," +
                    " CategoriaPelicula.IdCategoria, CategoriaPelicula.NombreCategoria, CategoriaPelicula.Descripcion," +
                    " Cantidad" +
                    " from PeliculaxSucursal Inner Join Sucursal on PeliculaxSucursal.IdSucursal = Sucursal.IdSucursal " +
                    " Inner Join Pelicula on PeliculaxSucursal.IdPelicula = Pelicula.IdPelicula Inner Join Encargado on" +
                    " Encargado.IdEncargado = Sucursal.IdEncargado Inner Join CategoriaPelicula on CategoriaPelicula.IdCategoria = Pelicula.IdCategoria " +
                    " Inner join Persona on Encargado.Identificacion = Persona.Identificacion";

                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoriaPelicula objeto_Categoria = new CategoriaPelicula()
                        {
                            Id_de_categoria = Convert.ToInt32(reader["IdCategoria"]),
                            Nombre_de_la_categoria = (String)reader["NombreCategoria"],
                            Descripcion = (String)reader["Descripcion"]
                        };

                        Encargado objeto_encargado = new Encargado()
                        {
                            Id_Encargado = Convert.ToInt32(reader["IdEncargado"]),
                            Identificacion = reader["Identificacion"].ToString()!,
                            Nombre = reader["Nombre_Persona"].ToString()!,
                            Primer_apellido = reader["PrimerApellido"].ToString()!,
                            Segundo_apellido = reader["SegundoApellido"].ToString()!,
                            Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                            Fecha_de_ingreso = DateTime.Parse(reader["FechaIngreso"].ToString()!)
                        };

                        Sucursal objeto_sucursal = new Sucursal()
                        {
                            Id_de_sucursal = Convert.ToInt32(reader["IdSucursal"]),
                            Nombre = reader["Nombre_Sucursal"].ToString()!,
                            _Encargado = objeto_encargado,
                            Direccion = reader["Direccion"].ToString()!,
                            Telefono = reader["Telefono"].ToString()!,
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };

                        

                        Pelicula objeto_pelicula = new Pelicula()
                        {
                            Id_de_pelicula = reader["IdPelicula"] is DBNull ? 0 : Convert.ToInt32(reader["IdPelicula"]),
                            Titulo = reader["Titulo"] is DBNull ? string.Empty : (string)reader["Titulo"],
                            Categoria_pelicula = objeto_Categoria,
                            Ano_de_lanzamiento = reader["AnioLanzamiento"] is DBNull ? 0 : Convert.ToInt32(reader["AnioLanzamiento"]),
                            Idioma = reader["Idioma"] is DBNull ? string.Empty : (string)reader["Idioma"]
                        };


                        PeliculaxSucursal objeto_pxS = new PeliculaxSucursal()
                        {
                            Sucursal = objeto_sucursal,
                            Filmes = objeto_pelicula,
                            Cantidad = Convert.ToInt32(reader["Cantidad"])
                        };

                        arreglo_global.Add(objeto_pxS);
                        
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos de películas por sucursal.");
                    return null!;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("1 - Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }

            return arreglo_global;

        }
        #endregion

        #region Préstamo por id
        public List<Prestamo> retorno_lista_de_prestamo_por_id(int id)
        {
            List<Prestamo> arreglo_global = new List<Prestamo>();

            //MessageBox.Show($"El id en Prestamo es {id}");
            try
            {
                conexion.Open();
                String query = "select IdPrestamo, Cliente.IdCliente, Cliente.Identificacion, " +
                    "Cliente.FechaRegistro, Cliente.Activo, Persona.Nombre 'Nombre_persona', Persona.PrimerApellido, " +
                    "Persona.SegundoApellido, Persona.FechaNacimiento, Sucursal.IdSucursal, " +
                    "Sucursal.Nombre 'Nombre_sucursal', Sucursal.Direccion, Sucursal.Telefono, Sucursal.Activo, " +
                    "Pelicula.IdPelicula, Pelicula.Titulo, Pelicula.AnioLanzamiento, Pelicula.Idioma, " +
                    "CategoriaPelicula.IdCategoria, CategoriaPelicula.NombreCategoria, CategoriaPelicula.Descripcion, " +
                    "FechaPrestamo, PendienteDevolucion from Prestamo Inner join Cliente on Prestamo.IdCliente = Cliente.IdCliente " +
                    "inner join Persona on Cliente.Identificacion = Persona.Identificacion Inner join Sucursal on " +
                    "Sucursal.IdSucursal = Prestamo.IdSucursal " +
                    "Inner join Pelicula on Pelicula.IdPelicula = Prestamo.IdPelicula Inner join CategoriaPelicula on " +
                    "CategoriaPelicula.IdCategoria = Pelicula.IdCategoria " +
                    "where  Prestamo.IdCliente = "+id+" ";
                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoriaPelicula objeto_Categoria = new CategoriaPelicula()
                        {
                            Id_de_categoria = Convert.ToInt32(reader["IdCategoria"]),
                            Nombre_de_la_categoria = (String)reader["NombreCategoria"],
                            Descripcion = (String)reader["Descripcion"]
                        };

                        Sucursal objeto_sucursal = new Sucursal()
                        {
                            Id_de_sucursal = Convert.ToInt32(reader["IdSucursal"]),
                            Nombre = reader["Nombre_Sucursal"].ToString()!,
                            _Encargado = null,
                            Direccion = reader["Direccion"].ToString()!,
                            Telefono = reader["Telefono"].ToString()!,
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };

                        Cliente objeto_cliente = new Cliente()
                        {
                            Id_Cliente = Convert.ToInt32(reader["IdCliente"].ToString()!),
                            Identificacion = reader["Identificacion"].ToString()!,
                            Nombre = reader["Nombre_persona"].ToString()!,
                            Primer_apellido = reader["PrimerApellido"].ToString()!,
                            Segundo_apellido = reader["SegundoApellido"].ToString()!,
                            Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                            Fecha_de_registro = DateTime.Parse(reader["FechaRegistro"].ToString()!),
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };

                        Pelicula objeto_pelicula = new Pelicula()
                        {
                            Id_de_pelicula = reader["IdPelicula"] is DBNull ? 0 : Convert.ToInt32(reader["IdPelicula"]),
                            Titulo = reader["Titulo"] is DBNull ? string.Empty : (string)reader["Titulo"],
                            Categoria_pelicula = objeto_Categoria,
                            Ano_de_lanzamiento = reader["AnioLanzamiento"] is DBNull ? 0 : Convert.ToInt32(reader["AnioLanzamiento"]),
                            Idioma = reader["Idioma"] is DBNull ? string.Empty : (string)reader["Idioma"]
                        };

                        Prestamo objeto_prestamo = new Prestamo() 
                        {
                            Id_de_prestamos = Convert.ToInt32(reader["IdPrestamo"].ToString()),
                            _Cliente = objeto_cliente,
                            _Sucursal = objeto_sucursal,
                            _Pelicula = objeto_pelicula,
                            Fecha_de_prestamo = DateTime.Parse(reader["FechaPrestamo"].ToString()!),
                            Pendiente_de_devolucion = reader.GetBoolean(reader.GetOrdinal("PendienteDevolucion"))
                        };
                        arreglo_global.Add(objeto_prestamo);    

                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                    return null!;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("1 - Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }

            return arreglo_global;

        }

        #endregion

        #region Préstamo 
        public List<Prestamo> retorno_lista_de_prestamo()
        {
            List<Prestamo> arreglo_global = new List<Prestamo>();

            //MessageBox.Show($"El id en Prestamo es {id}");
            try
            {
                conexion.Open();
                String query = "select IdPrestamo, Cliente.IdCliente, Cliente.Identificacion, " +
                    "Cliente.FechaRegistro, Cliente.Activo, Persona.Nombre 'Nombre_persona', Persona.PrimerApellido, " +
                    "Persona.SegundoApellido, Persona.FechaNacimiento, Sucursal.IdSucursal, " +
                    "Sucursal.Nombre 'Nombre_sucursal', Sucursal.Direccion, Sucursal.Telefono, Sucursal.Activo, " +
                    "Pelicula.IdPelicula, Pelicula.Titulo, Pelicula.AnioLanzamiento, Pelicula.Idioma, " +
                    "CategoriaPelicula.IdCategoria, CategoriaPelicula.NombreCategoria, CategoriaPelicula.Descripcion, " +
                    "FechaPrestamo, PendienteDevolucion from Prestamo Inner join Cliente on Prestamo.IdCliente = Cliente.IdCliente " +
                    "inner join Persona on Cliente.Identificacion = Persona.Identificacion Inner join Sucursal on " +
                    "Sucursal.IdSucursal = Prestamo.IdSucursal " +
                    "Inner join Pelicula on Pelicula.IdPelicula = Prestamo.IdPelicula Inner join CategoriaPelicula on " +
                    "CategoriaPelicula.IdCategoria = Pelicula.IdCategoria; ";

                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoriaPelicula objeto_Categoria = new CategoriaPelicula()
                        {
                            Id_de_categoria = Convert.ToInt32(reader["IdCategoria"]),
                            Nombre_de_la_categoria = (String)reader["NombreCategoria"],
                            Descripcion = (String)reader["Descripcion"]
                        };

                        Sucursal objeto_sucursal = new Sucursal()
                        {
                            Id_de_sucursal = Convert.ToInt32(reader["IdSucursal"]),
                            Nombre = reader["Nombre_Sucursal"].ToString()!,
                            _Encargado = null,
                            Direccion = reader["Direccion"].ToString()!,
                            Telefono = reader["Telefono"].ToString()!,
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };

                        Cliente objeto_cliente = new Cliente()
                        {
                            Id_Cliente = Convert.ToInt32(reader["IdCliente"].ToString()!),
                            Identificacion = reader["Identificacion"].ToString()!,
                            Nombre = reader["Nombre_persona"].ToString()!,
                            Primer_apellido = reader["PrimerApellido"].ToString()!,
                            Segundo_apellido = reader["SegundoApellido"].ToString()!,
                            Fecha_de_nacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()!),
                            Fecha_de_registro = DateTime.Parse(reader["FechaRegistro"].ToString()!),
                            Activo_ = reader.GetBoolean(reader.GetOrdinal("Activo"))
                        };

                        Pelicula objeto_pelicula = new Pelicula()
                        {
                            Id_de_pelicula = reader["IdPelicula"] is DBNull ? 0 : Convert.ToInt32(reader["IdPelicula"]),
                            Titulo = reader["Titulo"] is DBNull ? string.Empty : (string)reader["Titulo"],
                            Categoria_pelicula = objeto_Categoria,
                            Ano_de_lanzamiento = reader["AnioLanzamiento"] is DBNull ? 0 : Convert.ToInt32(reader["AnioLanzamiento"]),
                            Idioma = reader["Idioma"] is DBNull ? string.Empty : (string)reader["Idioma"]
                        };

                        Prestamo objeto_prestamo = new Prestamo()
                        {
                            Id_de_prestamos = Convert.ToInt32(reader["IdPrestamo"].ToString()),
                            _Cliente = objeto_cliente,
                            _Sucursal = objeto_sucursal,
                            _Pelicula = objeto_pelicula,
                            Fecha_de_prestamo = DateTime.Parse(reader["FechaPrestamo"].ToString()!),
                            Pendiente_de_devolucion = reader.GetBoolean(reader.GetOrdinal("PendienteDevolucion"))
                        };
                        arreglo_global.Add(objeto_prestamo);

                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                    return null!;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("1 - Ocurrió un error: " + e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }

            return arreglo_global;

        }



        #endregion
        #endregion Fin de todas las funciones.

        #region Busqueda de identificación.

        /*
         En este apartado solo se retornará los datos que tengan filas según 
        sea su proposito a buscar, esto también se implementará en la parte que evaluará
        datos registrados en el menú de inicio.
         */

        public bool busqueda_de_existencia_id(String query)
        {
            conexion.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        { return false; }
                        else
                        { return true; }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message);
                return false; // Considera retornar false o una señal de error en caso de excepción.
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        #endregion
   
    }
}
