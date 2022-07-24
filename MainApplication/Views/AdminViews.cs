using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainApplication.Contexts;
using MainApplication.Entities;

namespace MainApplication.Views
{
    public  class AdminViews
    {

       
        List<AdminClass> adminClasses = new List<AdminClass>();


       

        public  void addAdmin(AdminClass admin)
        {
            adminClasses.Add(admin);
        }

        


    }
}
