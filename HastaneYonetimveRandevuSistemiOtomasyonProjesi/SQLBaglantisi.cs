using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneYonetimveRandevuSistemiOtomasyonProjesi
{

    class SQLBaglantisi
    {
        

        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HastaneProje;Integrated Security=True");
            con.Open();
            return con;
          
            

        }
    }
}
