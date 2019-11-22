using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleInnovation.DataProvider.Entity.EntityModel
{
    [Table("ErrorLog")]
    public class ErrorLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long? UserID { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
        public string Severity { get; set; }
        public DateTime LoggedOn { get; set; }
        public DateTime ISDTime { get; set; }
        public string Source { get; set; }
    }
}
