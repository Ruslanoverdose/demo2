//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Семестровая
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Musics
    {
        public int MusicID { get; set; }
        public int UserID { get; set; }
        public string Performer { get; set; }
        public string Track { get; set; }
        public string Path { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
