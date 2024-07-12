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
    /// Lógica de interacción para modificarMateria.xaml
    /// </summary>
    public partial class modificarMateria : Window
    {
        public modificarMateria()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["Practica_BBDD.Properties.Settings.PracticaBBDDConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }
        SqlConnection miConexionSql;

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {

            if (ComboBoxOpciones.SelectedItem != null)
            {
                string opcion = (ComboBoxOpciones.SelectedItem as ComboBoxItem).Content.ToString();

                materiaModificadaEnProfesor ventanaModificarProfesorACargo = new materiaModificadaEnProfesor();
                cargaHorariaModificada ventanaCargaHorariaModificada = new cargaHorariaModificada();

                

                if (opcion == "Profesor a cargo")
                {
                    ventanaModificarProfesorACargo.Show();

                }
                else if (opcion == "Carga horaria semanal")
                {
                    ventanaCargaHorariaModificada.Show();
                }
            }
            else { MessageBox.Show ("DEBE SELECCIONAR UNA OPCION"); }    
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
