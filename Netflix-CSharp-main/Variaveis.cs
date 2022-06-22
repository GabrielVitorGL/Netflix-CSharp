using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Netflix
{
    public static class Variaveis
    {
        public static String idfilme;
        public static String NomeUsuario;
        public static String EmailUsuario;
        //public static String strCon = "Data Source=DESKTOP-SA9T3MO;Initial Catalog=contas;Integrated Security=true;";
        public static String strCon = "Data Source=LI03-11;Initial Catalog=contas;User ID=sa;password=123456";
    }

}
