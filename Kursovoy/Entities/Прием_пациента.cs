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
    
    public partial class Прием_пациента
    {
        public int Номер_приёма { get; set; }
        public int Код_пациента { get; set; }
        public int Код_препарата { get; set; }
        public int Код_сотрудника { get; set; }
        public Nullable<System.DateTime> Дата_приёма { get; set; }
    
        public virtual Пациент Пациент { get; set; }
        public virtual Препарат Препарат { get; set; }
        public virtual Сотрудник Сотрудник { get; set; }
    }
}
