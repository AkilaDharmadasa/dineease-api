﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[PrimaryKey("OrderId", "FoodId")]
[Table("Order_Foods")]
[Index("FoodId", Name = "IX_Order_Foods_food_id")]
public partial class OrderFoods
{
    [Key]
    [Column("order_id")]
    public Guid OrderId { get; set; }

    [Key]
    [Column("food_id")]
    public Guid FoodId { get; set; }

    [Column("quantity")]
    public int? Quantity { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("OrderFoods")]
    public virtual Food Food { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderFoods")]
    public virtual Orders Order { get; set; }
}