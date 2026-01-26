using System;
using System.Collections.Generic;

namespace TetGift.DAL.Entities;

public partial class Blog
{
    public int Blogid { get; set; }

    public int? Accountid { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateTime? Creationdate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Account? Account { get; set; }
}
