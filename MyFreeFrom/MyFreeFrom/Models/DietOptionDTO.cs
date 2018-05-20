using MyFreeFrom.Shared.Enums;
using System.Collections.Generic;

namespace MyFreeFrom.Models
{
    public class DietOptionDTO
    {
        public int Id { get; set; }
        public DietTypeEnum DietType { get; set; }
    }
}