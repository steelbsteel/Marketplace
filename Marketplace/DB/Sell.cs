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
    
    public partial class Sell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sell()
        {
            this.Sell_User = new HashSet<Sell_User>();
        }
    
        public int idSell { get; set; }
        public int idProduct { get; set; }
        public int Sallary { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sell_User> Sell_User { get; set; }
    }
}