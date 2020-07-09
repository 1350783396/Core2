using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    [Table("Test1")]
    public class Test1
    {
        public int id { get; set; }
        public string name { get; set; }

    }
}
