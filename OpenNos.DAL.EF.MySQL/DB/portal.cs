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
    
    public partial class Portal
    {
        public int PortalId { get; set; }
        public short SourceX { get; set; }
        public short SourceY { get; set; }
        public short DestinationX { get; set; }
        public short DestinationY { get; set; }
        public short Type { get; set; }
        public short DestinationMapId { get; set; }
        public short SourceMapId { get; set; }
    
        public virtual Map destinationmap { get; set; }
        public virtual Map sourcemap { get; set; }
    }
}
