using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WEB_SERV
{
    /// <summary>
    /// Summary description for Meteo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Meteo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=Meteo;Integrated Security=True");

        [WebMethod]
        public int TempMin(string Ville)
        {
            String req = "select TempMin from Meteo where Ville ='" + Ville + "'";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int res = int.Parse(dr[0].ToString());
            cnx.Close();
            dr.Close();
            return res;


        }

        [WebMethod]
        public int TempMax(string Ville)
        {
            String req = "select TempMax from Meteo where Ville ='" + Ville + "'";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int res = int.Parse(dr[0].ToString());
            cnx.Close();
            dr.Close();
            return res;


        }


        [WebMethod]
        public int Humid(string Ville)
        {
            String req = "select Humid from Meteo where Ville ='" + Ville + "'";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int res = int.Parse(dr[0].ToString());
            cnx.Close();
            dr.Close();
            return res;


        }
    }
}
