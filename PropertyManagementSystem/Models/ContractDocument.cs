using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem.Models
{
    class ContractDocument
    {
        public int Id { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
        public byte[] Image { get; set; }
    }
}
