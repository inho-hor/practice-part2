//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice
{
    using System;
    using System.Collections.Generic;
    
    public partial class clothWarehouse
    {
        public int idRoll { get; set; }
        public int idCloth { get; set; }
        public double width { get; set; }
        public double length { get; set; }
    
        public virtual cloth cloth { get; set; }
    }
}
