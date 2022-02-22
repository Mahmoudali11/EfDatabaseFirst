using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.BL;
namespace WebApplication1.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                 SingleTone singleTone = new SingleTone();


               singleTone.MyEmployee.Update(new DA.emp { Id = 5, Name = "Mahmoud Selim...", adress = "now in cairo" ,did=3,gender=DA.gender.male});
                myg.DataSource = singleTone.MyEmployee.GetByGender(1);
                myg.DataBind();



            }

        }
    }
}