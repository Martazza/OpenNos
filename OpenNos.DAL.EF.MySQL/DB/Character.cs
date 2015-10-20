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
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.friend = new HashSet<friend>();
            this.inventory = new HashSet<inventory>();
            this.skill = new HashSet<skill>();
            this.pet = new HashSet<pet>();
            this.action = new HashSet<action>();
            this.partner = new HashSet<partner>();
        }
    
        public int CharacterId { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; }
        public byte Slot { get; set; }
        public byte Gender { get; set; }
        public byte Class { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public short Map { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int ArenaWinner { get; set; }
        public int Reput { get; set; }
        public int Dignite { get; set; }
        public long Gold { get; set; }
        public int Backpack { get; set; }
        public byte Level { get; set; }
        public int LevelXp { get; set; }
        public byte JobLevel { get; set; }
        public int JobLevelXp { get; set; }
        public int Dead { get; set; }
        public int Kill { get; set; }
        public int Contribution { get; set; }
        public int Faction { get; set; }
    
        public virtual Account account { get; set; }
        public virtual characterfamily characterfamily { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<friend> friend { get; set; }
        public virtual miniland miniland { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventory> inventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skill> skill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pet> pet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action> action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<partner> partner { get; set; }
    }
}
