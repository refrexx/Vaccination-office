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
    
    public partial class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Roled { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
