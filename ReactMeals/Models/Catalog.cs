using System;
using System.Collections.Generic;

namespace ReactMeals.Models;

public partial class Catalog
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Price { get; set; }

    public string Description { get; set; } = null!;
}
