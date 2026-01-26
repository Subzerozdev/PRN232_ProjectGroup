using System;
using System.Collections.Generic;

namespace TetGift.DAL.Entities;

public partial class Quotation
{
    public int Quotationid { get; set; }

    public int? Accountid { get; set; }

    public int? Orderid { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Status { get; set; }

    public string? Company { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public decimal? Totalprice { get; set; }

    public string? Note { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();
}
