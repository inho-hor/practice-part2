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
    
    public partial class productFurniture
    {
        public int idFurniture { get; set; }
        public int idProduct { get; set; }
        public string accommodation { get; set; }
        public Nullable<double> width { get; set; }
        public Nullable<double> length { get; set; }
        public Nullable<double> turn { get; set; }
        public Nullable<int> QTY { get; set; }
    
        public virtual furniture furniture { get; set; }
        public virtual product product { get; set; }
    }
}
