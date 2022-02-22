using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DA;

namespace WebApplication1.BL
{
    public class SingleTone
    {



      static  LearnEntities1 context=new LearnEntities1();


        public Employee MyEmployee
        {
            get
            {

                return  new Employee(context);
            }
                }
        public Department MyDepartment
        {
            get
            {

                return new Department(context);
            }
        }

    }
}