//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Product()
        {
            this.T_Sostav_Product = new HashSet<T_Sostav_Product>();
        }
    
        public int id_product { get; set; }
        public string Title { get; set; }
        public int id_manufacturer { get; set; }
        public int id_type { get; set; }
        public int id_provider { get; set; }
        public int id_discount { get; set; }
        public int Price { get; set; }
    
        public virtual T_Discount T_Discount { get; set; }
        public virtual T_Manufacturer T_Manufacturer { get; set; }
        public virtual T_Provider T_Provider { get; set; }
        public virtual T_Type T_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sostav_Product> T_Sostav_Product { get; set; }
    }
}
