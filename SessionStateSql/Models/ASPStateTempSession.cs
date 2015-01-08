using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SessionStateSql.Models
{
    public class ASPStateTempSession
    {
        [Key, Required, MaxLength(88)]
        public string SessionId { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Expires { get; set; }
        public System.DateTime LockDate { get; set; }
        public System.DateTime LockDateLocal { get; set; }
        public int LockCookie { get; set; }
        public int Timeout { get; set; }
        public bool Locked { get; set; }
        [MaxLength(7000)]
        public byte[] SessionItemShort { get; set; }
        public byte[] SessionItemLong { get; set; }
        public int Flags { get; set; }
    }
}
