namespace Test_NETFRAMEWORK_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersInfo")]
    public partial class UsersInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string Last_name { get; set; }

        [StringLength(50)]
        public string First_name { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        public string Role { get; set; }

        public int? Click { get; set; }

        public virtual Users Users { get; set; }
    }
}
