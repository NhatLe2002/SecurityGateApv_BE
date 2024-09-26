using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitorSessionsImage
    {
        [Key]
        public int VisitorSessionsImageId { get; set; }
        public string ImageType { get; set; }
        public string ImageURL { get; set; }

        [ForeignKey("VisitorSession")]
        public int VisitorSessionId { get; set; }
        public VisitorSession VisitorSession { get; set; }
    }
}
