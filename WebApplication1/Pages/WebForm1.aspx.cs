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

                SingleTone singleTone2 = new SingleTone();

              var x=  singleTone.MyEmployee.
                    GetById(5);


                var y = singleTone2.MyDepartment.GetById(1);
                x.dept = y;
                singleTone.MyEmployee.Update(x);
                myg.DataSource = singleTone.MyEmployee.GetByGender(1);
                myg.DataBind();



            }

        }
    }
} 