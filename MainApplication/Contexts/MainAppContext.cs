using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MainApplication.Entities;

namespace MainApplication.Contexts
{
    public class MainAppContext:DbContext
    {
        public MainAppContext() : base("baglanti")
        {

        }

       
    }
}
