using System;
using System.Collections.Generic;

namespace TetGift.DAL.Entities;

public partial class ConfigDetail
{
    public int Configdetailid { get; set; }

    public int? Configid { get; set; }

    public int? Categoryid { get; set; }

    public int? Quantity { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ProductConfig? Config { get; set; }
}
