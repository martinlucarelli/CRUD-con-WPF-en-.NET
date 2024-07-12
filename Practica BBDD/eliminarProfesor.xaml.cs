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
    /// Lógica de interacción para eliminarProfesor.xaml
    /// </summary>
    public partial class eliminarProfesor : Window
    {
        public eliminarProfesor()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["Practica_BBDD.Properties.Settings.PracticaBBDDConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }
        SqlConnection miConexionSql;
        private void eliminar_Click(object sender, RoutedEventArgs e)
        {
            miConexionSql.Open();

            string consulta = "DELETE FROM profesor WHERE dni = @DNI";

            SqlCommand misqlcommand = new SqlCommand(consulta, miConexionSql);

            using (misqlcommand)
            {
                misqlcommand.Parameters.AddWithValue("@DNI", dniEliminar.Text);

                try
                {
                    int filasAfectadas = misqlcommand.ExecuteNonQuery(); 

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Datos eliminados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el DNI proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL GUARDAR LOS DATOS. Asegurese de que todos los campos esten completados" +
                        "y de no colocar letras o puntos en el campo dni: " + ex.Message);
                }
            }

            dniEliminar.Text = " ";
            miConexionSql.Close();


        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
