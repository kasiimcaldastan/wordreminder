using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KelimeEzberle
{
   public class Class1
    {
        //public  List<Kelime> klm;
       // public void DataGetir()
        //{
        //    string constr= "Server=LOCALHOST\\SQLEXPRESS; Database=Words; Trusted_Connection=True";
        //    SqlConnection con = new SqlConnection(constr);
        //    SqlCommand com = new SqlCommand("select * from Learning", con);
        //    SqlDataReader dr = com.ExecuteReader();
        //    klm = new List<Kelime>();
        //    if (dr.Read())
        //    {
        //        klm.Add(new Kelime { Eng = dr["English"].ToString(), TR = dr["Turkish"].ToString(), Read = dr["Readly"].ToString() });
        //    }
        //}

    }
   public class Kelime
    {
        public string Eng { get; set; }
        public string TR { get; set; }
        public string Read { get; set; }
    }
}
