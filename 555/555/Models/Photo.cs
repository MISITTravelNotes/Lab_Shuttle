using System;
using System.Collections.Generic;

namespace _555.Models;

public partial class Photo
{
    public int Id { get; set; }

    public byte[]? ImageData { get; set; }
}
