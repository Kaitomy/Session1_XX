//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amonic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Track
    {
        public int ID_Track { get; set; }
        public int UserID { get; set; }
        public string LoginIn { get; set; }
        public string LoginOut { get; set; }
        public string ErrorReason { get; set; }
        public System.DateTime LoginTimeIn { get; set; }
        public Nullable<System.DateTime> LoginTimeOutException { get; set; }
        public string TypeError { get; set; }
    
        public virtual Users Users { get; set; }
    }
}