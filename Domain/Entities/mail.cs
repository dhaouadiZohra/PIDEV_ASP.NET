namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.mail")]
    public partial class mail
    {
        public int id { get; set; }

        [StringLength(255)]
        public string context { get; set; }

        [StringLength(255)]
        public string path { get; set; }

        public DateTime? sentdate { get; set; }

        [StringLength(255)]
        public string subject { get; set; }

        public int? receiver_id { get; set; }

        public int? sender_id { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }
    }
}
