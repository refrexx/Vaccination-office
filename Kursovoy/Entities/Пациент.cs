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
    
    public partial class Пациент
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пациент()
        {
            this.Прием_пациента = new HashSet<Прием_пациента>();
        }
    
        public int Код_пациента { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public Nullable<System.DateTime> Дата_рождения { get; set; }
        public Nullable<int> Номер_участка { get; set; }
        public string Номер_страхового_полиса { get; set; }
        public string Пол { get; set; }
        public string Номер_телефона { get; set; }
        public string Область_прописки { get; set; }
        public string Район_прописки { get; set; }
        public string Город_прописки { get; set; }
        public string Улица_прописки { get; set; }
        public Nullable<int> Дом_прописки { get; set; }
        public Nullable<int> Номер_квартиры_прописки { get; set; }
        public string СНИЛС { get; set; }
        public string Место_работы { get; set; }
    
        public virtual Участок Участок { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Прием_пациента> Прием_пациента { get; set; }
    }
}
