using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public string Address { get; set; }
        public string AdditionalDetails { get; set; }
        public bool IsMainAddress { get; set; }
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }

    }
}
