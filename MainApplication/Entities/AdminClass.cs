using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainApplication.Entities
{
    public  class AdminClass
    {   
        
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }



        public AdminClass(String username, String password)
        {
            this.userName = username;
            this.password = password;
        }
    }
}
