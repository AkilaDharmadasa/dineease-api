﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[Keyless]
[Table("Side_dish")]
public partial class SideDish
{
    [Column("food_id")]
    public int FoodId { get; set; }

    [Column("side_dish_id")]
    public int SideDishId { get; set; }
}