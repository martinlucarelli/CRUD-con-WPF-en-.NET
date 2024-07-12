using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_BBDD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //PracticaBBDDConnectionString

            string miConexion = ConfigurationManager.ConnectionStrings["Practica_BBDD.Properties.Settings.PracticaBBDDConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);

            muestraAlumnos();
            muestraProfesores();
            muestraMateria();
        }
        SqlConnection miConexionSql;


        private void muestraAlumnos()
        {
            string consulta = "SELECT dni, direccion, telefono,CONCAT(apellido, ' ',nombre)" +
                "AS nombreyapellido FROM alumno ORDER BY apellido ASC";




            SqlDataAdapter miadaptador = new SqlDataAdapter(consulta, miConexionSql);

            using (miadaptador)
            {
                DataTable tablaAlumnos = new DataTable();
                miadaptador.Fill(tablaAlumnos);

                listaAlumnos.ItemsSource = tablaAlumnos.DefaultView;
                
                
            }
        }

       

        
        private void muestraProfesores()
        {
            string consulta = "SELECT dni,CONCAT(apellido, ' ',nombre) AS nombreyapellido FROM profesor" +
                " ORDER BY apellido ASC";

            SqlDataAdapter miadaptador = new SqlDataAdapter(consulta, miConexionSql);

            using (miadaptador)
            {
                DataTable tablaProfesores = new DataTable();
                miadaptador.Fill(tablaProfesores);

               
                listaProfesores.ItemsSource = tablaProfesores.DefaultView;
            }
        }
        
        private void muestraMateria()
        {
            string consulta = "SELECT m.*, CONCAT(p.apellido, ' ', p.nombre) AS profesor FROM materia m JOIN profesor p ON m.profesorCargo = p.dni";

            SqlDataAdapter miadaptador = new SqlDataAdapter(consulta, miConexionSql);

            using (miadaptador)
            {
                DataTable tablaMaterias = new DataTable();
                miadaptador.Fill(tablaMaterias);

                
                listaMaterias.ItemsSource = tablaMaterias.DefaultView;
            }
        }

        private void agregarAlumno_Click(object sender, RoutedEventArgs e)
        {
            nuevoAlumno ventaAgregarAlumno = new nuevoAlumno();

            ventaAgregarAlumno.Show();



        }

        private void Window_Activated(object sender, EventArgs e)
        {
            muestraAlumnos();
            muestraProfesores();
            muestraMateria();
        }

        private void borrarAlumno_Click(object sender, RoutedEventArgs e)
        {
            eliminarAlumno ventaEliminarAlumno = new eliminarAlumno();
            ventaEliminarAlumno.Show();
        }

        private void agregarProfesor_Click(object sender, RoutedEventArgs e)
        {
            nuevoProfesor ventanaNuevoProfesor = new nuevoProfesor();

            ventanaNuevoProfesor.Show();
        }

        private void borrarProfesor_Click(object sender, RoutedEventArgs e)
        {
            eliminarProfesor ventaEliminarProfesor = new eliminarProfesor();
            ventaEliminarProfesor.Show();
        }

        private void agregarMateria_Click(object sender, RoutedEventArgs e)
        {
            nuevaMateria ventanaNuevaMateria = new nuevaMateria();
            ventanaNuevaMateria.Show();
        }

        private void borrarMateria_Click(object sender, RoutedEventArgs e)
        {
            eliminarMateria ventanaEliminarMateria = new eliminarMateria();
            ventanaEliminarMateria.Show();
        }

        private void modificarMateria_Click(object sender, RoutedEventArgs e)
        {
            modificarMateria ventanaModificarMateria = new modificarMateria();
            ventanaModificarMateria.Show();
        }
    }

    //CONSULTA VIEJA:  SELECT m.*, CONCAT(p.apellido, ' ', p.nombre) AS profesor FROM materia m JOIN profesor p ON m.profesorCargo = p.dni; "

    //Hay que crear un listbox por cada columna de las tablas y ponerlo dentro de un grid
    //de esta forma voy a poner los datos mas ordenados, tengo que revisar el trabajo del clima que 
    // ahi puse distintas columnas de forma ordenada y prolija.

}
