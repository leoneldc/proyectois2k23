using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Ventas
{
    public class Sentencias
    {
        Cpconexion con = new Cpconexion();

        public OdbcDataAdapter DisplayAlumnos()
        {
            string sql = "SELECT * FROM tbl_vendedores ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, con.Conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Alumnos");
            }
            return dataTable;
        }
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
                    OdbcCommand cmd = new OdbcCommand(insert, con.Conexion());
                    Console.WriteLine(insert);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

        }
        public void ejecutarSentecias(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.Conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("error con la setencias" + sql + "\n" + e);
            }
        }
    }
}

