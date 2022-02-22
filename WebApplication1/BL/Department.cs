using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DA;

namespace WebApplication1.BL
{
    public class Department:Reposatory<dept>
    {


        public Department(LearnEntities1 context) : base(context)
        {


        }



    }
}