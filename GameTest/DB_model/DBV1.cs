using GameTest.Properties;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest.DB_model
{
    public class DBV1
    {
        public int id { get; set; }
        public int id_kat { get; set; }
        public string tekst { get; set; }
        public string otvet { get; set; }

    }
    public class DBK1
    {
        public int id_kat { get; set; }
        public string name_kat { get; set; }
        public string nazvanie { get; set; }
        public DateTime datas { get; set; }
        public DateTime datar { get; set; }
    }
   

    public class Helper
    {
        /*List<DBV1> DBv1 = new List<DBV1>();
    List<DBK1> DBk1 = new List<DBK1>();
   //строгое типизирование данных
    public List<DBV1> GetAllEllementsDBv1(int tn)
    {
        SqlConnection sqlCon = new SqlConnection(Settings.Default.ConectDb);
        sqlCon.Open();
        SqlDataReader sqlRe = null;
        SqlCommand command = new SqlCommand("SELECT * FROM [GTV" + tn +"]", sqlCon);
        sqlRe = command.ExecuteReader();
        sqlRe.Read();
        foreach (DbDataRecord s in sqlRe)
        {
            DBv1.Add(new DBV1()
            {
                id = s.GetInt32(0),
                id_kat = s.GetInt32(1),
                tekst = s.GetString(2),
                otvet = s.GetString(3),
            });
        }
        return DBv1;
    }*/
        public static string Vops(int vop, int tn)
        {
            var sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV" + tn + "] WHERE id=" + vop, sqlCon);
            sqlRe = command.ExecuteReader();
            sqlRe.Read();
            return Convert.ToString(sqlRe["tekst"]);
        }
        public static string Otv(int vop,int tn)
        {
            var sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV" + tn + "] WHERE id=" + vop, sqlCon);
            sqlRe = command.ExecuteReader();
            sqlRe.Read();
            return Convert.ToString(sqlRe["otvet"]);
        }
        
    }
}
