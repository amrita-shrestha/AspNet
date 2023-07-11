using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearningCRUD
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewRecord();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\source\\repos\\LearningCRUD\\App_Data\\Database1.mdf;Integrated Security=True");
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into [Table] (Name, RegNo) values('" + StdName.Text + "','" + int.Parse(StdReg.Text) + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            //register a JavaScript code block to be executed on the client - side.In this case,
            //it registers a script that displays an alert message with the text "Successfully Inserted".
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            GridViewRecord();
        }

        protected void GridViewRecord()
        {
                SqlCommand comm = new SqlCommand("select * from [Table]", con);
                SqlDataAdapter d = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                d.Fill(dt);
            DisplayDbData.DataSource = dt;
            DisplayDbData.DataBind();
            
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Update [Table] set Name = '" +  StdName.Text+ "' where RegNo = '" + int.Parse(StdReg.Text) + "'"  ,con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GridViewRecord();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete [Table] where RegNo = '" + int.Parse(StdReg.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GridViewRecord();
        }

        protected void SearchBtn_Click(Object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from [Table] where RegNo = '" + int.Parse(StdReg.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            DisplayDbData.DataSource = dt;
            DisplayDbData.DataBind();
        }

        protected void GetBtn_Click(Object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from [Table] where RegNo = '" + int.Parse(StdReg.Text) + "'", con);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                StdName.Text = dr.GetValue(1).ToString();
            }
        }
    }
}