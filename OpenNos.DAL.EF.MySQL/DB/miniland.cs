//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class miniland
    {
        public int MinilandId { get; set; }
        public int Owner { get; set; }
        public string Item { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
    
        public virtual Character character { get; set; }
    }
}
