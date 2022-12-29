using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMedicineBackEnd.Models;

public partial class Order
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? UserId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OrderTotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrderStatus { get; set; }
}
