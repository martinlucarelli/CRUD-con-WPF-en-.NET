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
    /// Lógica de interacción para nuevaMateria.xaml
    /// </summary>
    public partial class nuevaMateria : Window
    {
        public nuevaMateria()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["Practica_BBDD.Properties.Settings.PracticaBBDDConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }
        SqlConnection miConexionSql;

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            miConexionSql.Open();

            string consulta = "INSERT INTO materia (nombre,cargaHorariaSemanal,anio,profesorCargo) " +
                "VALUES (@nombre,@horas,@anio,@profesor)";

            SqlCommand misqlcommand = new SqlCommand(consulta, miConexionSql);

            using (misqlcommand)
            {
                misqlcommand.Parameters.AddWithValue("@nombre", TexBoxNombre.Text);
                misqlcommand.Parameters.AddWithValue("@horas", TexBoxHoras.Text);
                misqlcommand.Parameters.AddWithValue("@anio", TexBoxAnio .Text);
                misqlcommand.Parameters.AddWithValue("@profesor", TexBoxProfCargo .Text);

                try
                {
                    misqlcommand.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL GUARDAR LOS DATOS. Asegurese de que todos los campos esten completados" +
                        " y de no colocar letras o puntos en el campo dni. Tambien asegurese de que" +
                        " el dni del profesor a cargo coincida con el de un profesor ya cargado en el sistema: " + ex.Message);
                }
            }
            miConexionSql.Close();

            TexBoxAnio.Text = " "; TexBoxNombre.Text = " ";TexBoxHoras .Text = " "; TexBoxProfCargo.Text = " ";


        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
