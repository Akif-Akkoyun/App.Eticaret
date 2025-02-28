using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
    }
}
