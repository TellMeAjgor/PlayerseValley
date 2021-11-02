using PlayerseValleyDomain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerseValleyDomain.Entities
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Experience { get; set; }
        public long Gold { get; set; }
        public short Level { get; set; }
        public CharacterClass Class { get; set; }
        public CharacterGender Sex { get; set; }
        public Guid CurrentLocation { get; set; }
        public Guid AccountId { get; set; }

        [ForeignKey("CurrentLocation")]
        public virtual Map Map { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
