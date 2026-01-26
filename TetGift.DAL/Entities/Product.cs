using System;
using System.Collections.Generic;

namespace TetGift.DAL.Entities;

public partial class Product
{
    public int Productid { get; set; }

    public int? Categoryid { get; set; }

    public int? Configid { get; set; }

    public int? Accountid { get; set; }

    public string? Sku { get; set; }

    public string? Productname { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Status { get; set; }

    public decimal? Unit { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual ProductCategory? Category { get; set; }

    public virtual ProductConfig? Config { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductDetail> ProductDetailProductparents { get; set; } = new List<ProductDetail>();

    public virtual ICollection<ProductDetail> ProductDetailProducts { get; set; } = new List<ProductDetail>();

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
