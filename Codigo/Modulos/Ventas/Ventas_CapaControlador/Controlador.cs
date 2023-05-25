using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Ventas;
using System.Windows.Forms;
using System.Data.Odbc;


namespace Ventas_CapaControlador
{
    public class Controlador
    {
        Cpconexion conexion = new Cpconexion();
        public void Guardar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas)
        {
            HashSet<string> tables = new HashSet<string>(valoresPorTagTabla.Keys.Union(valoresPorTagColumnas.Keys));

            foreach (string tabla in tables)
            {
                List<string> columnas = valoresPorTagTabla[tabla];
                List<string> valores = valoresPorTagColumnas[tabla];

                // Generate INSERT statement
                string insert = $"INSERT INTO {tabla} ({string.Join(",", columnas)}) VALUES ({string.Join(",", valores)});";

                try
                {
                    OdbcCommand cmd = new OdbcCommand(insert, conexion.Conexion());
                    Console.WriteLine(insert);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dato insertado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
