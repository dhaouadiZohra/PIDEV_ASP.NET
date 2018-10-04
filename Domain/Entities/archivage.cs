namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.archivage")]
    public partial class archivage
    {
        public int id { get; set; }

        public DateTime? datesubmit { get; set; }

        public int? etat { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string path { get; set; }

        [StringLength(255)]
        public string version { get; set; }

        public int? user_id { get; set; }

        public virtual user user { get; set; }
    }
}
