//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marketplace.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supply_Product
    {
        public int idSupply_Product { get; set; }
        public int idSupply { get; set; }
        public int idProduct { get; set; }
    
        public virtual Supply Supply { get; set; }
    }
}
