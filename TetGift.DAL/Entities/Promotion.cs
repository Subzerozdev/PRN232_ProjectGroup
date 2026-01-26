using System;
using System.Collections.Generic;

namespace TetGift.DAL.Entities;

public partial class Promotion
{
    public int Promotionid { get; set; }

    public string? Code { get; set; }

    public decimal? Discountvalue { get; set; }

    public DateTime? Expirydate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
