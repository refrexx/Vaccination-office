//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovoy.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Производитель
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Производитель()
        {
            this.Препарат = new HashSet<Препарат>();
        }
    
        public int Код_производителя { get; set; }
        public string Название_производителя { get; set; }
        public string Имя_представителя { get; set; }
        public string Фамилия_представителя { get; set; }
        public string Отчество_представителя { get; set; }
        public string Номер_телефона_представителя { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Препарат> Препарат { get; set; }
    }
}
