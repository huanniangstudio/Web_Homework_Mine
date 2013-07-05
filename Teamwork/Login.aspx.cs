using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections;
namespace Teamwork
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void Button1_Click1(object sender, EventArgs e)
        {

            //SqlConnection myConnection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString.ToString());
            //myConnection.Open();
            //SqlCommand myCommand = new SqlCommand("select * from LoginUser", myConnection);
            //SqlDataReader myReader = myCommand.ExecuteReader();
            //string a = TextBox1.Text;
            //string b = TextBox2.Text;
            //while (myReader.Read())
            //{
            //    Button1.Text = a+"  "+ myReader["Name"].ToString() +"  "+b+" "+ myReader["Password"].ToString();
            //        if (a == myReader["Name"].ToString() && b.ToString() == myReader["Password"].ToString())
            //        {
            //            Button1.Text = "good";
            //            if (myReader["UserType"] == "Student") Response.Redirect("ShowQuestionList.aspx");
            //            else Response.Redirect("ReplyQuestionList.aspx");
            //        }
        


            //}

            //因为上述代码有些问题，解决不了，所以先静态判断
            if (TextBox1.Text== "请叫我欢娘" && TextBox2.Text=="1234") Response.Redirect("ShowQuestionList.aspx");
            if (TextBox1.Text == "请叫我军哥" && TextBox2.Text == "1234") Response.Redirect("ReplyQuestionList.aspx");

        }

    }
}