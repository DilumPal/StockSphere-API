namespace StockSphere.Core.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal PurchasePrice { get; set; }
    public decimal SellingPrice { get; set; }
    public string ImageUrl { get; set; } = string.Empty; // Supabase URL
    public int ReorderLevel { get; set; } // Low stock threshold
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Foreign Keys
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public Guid? SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
}
