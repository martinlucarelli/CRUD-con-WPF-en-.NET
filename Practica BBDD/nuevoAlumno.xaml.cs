using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica_BBDD
{
    /// <summary>
    /// Lógica de interacción para nuevoAlumno.xaml
    /// </summary>
    public partial class nuevoAlumno : Window
    {
        public nuevoAlumno()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["Practica_BBDD.Properties.Settings.PracticaBBDDConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }

        SqlConnection miConexionSql;

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            miConexionSql.Open();

            string consulta="INSERT INTO alumno (dni, nombre, apellido, direccion, telefono) " +
                "VALUES (@DNI, @nombre, @apellido, @direccion, @telefono)";

            SqlCommand misqlcommand = new SqlCommand(consulta,miConexionSql);

            using (misqlcommand)
            {
                misqlcommand.Parameters.AddWithValue("@DNI", TexBoxDni.Text);
                misqlcommand.Parameters.AddWithValue("@nombre", TexBoxNombre.Text);
                misqlcommand.Parameters.AddWithValue("@apellido", TexBoxApellido.Text);
                misqlcommand.Parameters.AddWithValue("@direccion", TexBoxDireccion.Text);
                misqlcommand.Parameters.AddWithValue("@telefono", TexBoxTelefono.Text);

                try
                {
                    misqlcommand.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL GUARDAR LOS DATOS. Asegurese de que todos los campos esten completados" +
                        "y de no colocar letras o puntos en el campo dni: " + ex.Message);
                }
            }
            miConexionSql.Close();

            TexBoxApellido.Text = " "; TexBoxNombre.Text = " "; TexBoxDni.Text = " "; TexBoxDireccion.Text = " "; TexBoxTelefono.Text = " ";



        }
    }
}
