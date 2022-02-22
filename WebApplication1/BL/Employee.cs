using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DA;
namespace WebApplication1.BL
{
    public class Employee : Reposatory<emp>
    {


        public Employee(LearnEntities1 context) : base(context)
        {


        }

      public List<emp> GetByGender(int gender)
        {


            return  this.GetAll().Where(e=>(int)e.gender==gender).ToList();
        }
    }
}