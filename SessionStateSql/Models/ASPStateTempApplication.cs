using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SessionStateSql.Models
{
    public class ASPStateTempApplication
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppId { get; set; }
        [MaxLength(280), Required]
        public string AppName { get; set; }
    }
}
