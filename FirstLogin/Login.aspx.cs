using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con=new SqlConnection("Data Source=LAPTOP-OPTB7RJV;Initial Catalog=Student;Integrated Security=true");
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from StudentDetails", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //grdData.DataSource = ds;
            //grdData.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OPTB7RJV;Initial Catalog=Student;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentDetails values('" + txtUsername.Text + "','" + txtPassword.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from StudentDetails", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grdData.DataSource = ds;
            grdData.DataBind();
        }
    }
}