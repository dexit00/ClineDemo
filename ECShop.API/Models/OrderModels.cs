using System.ComponentModel.DataAnnotations;

namespace ECShop.API.Models
{
    // Request DTOs
    public class CreateOrderRequest
    {
        [Required]
        public List<OrderItemRequest> Items { get; set; } = new List<OrderItemRequest>();
        
        [Required]
        [MaxLength(100)]
        public string ShippingName { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(10)]
        public string ShippingPostalCode { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50)]
        public string ShippingPrefecture { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(100)]
        public string ShippingCity { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(200)]
        public string ShippingAddressLine { get; set; } = string.Empty;
        
        [MaxLength(20)]
        public string? ShippingPhone { get; set; }
        
        [MaxLength(500)]
        public string? Notes { get; set; }
    }
    
    public class OrderItemRequest
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
    
    public class UpdateOrderStatusRequest
    {
        [Required]
        public OrderStatus Status { get; set; }
    }
    
    // Response DTOs
    public class OrderResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string StatusText { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string ShippingName { get; set; } = string.Empty;
        public string ShippingPostalCode { get; set; } = string.Empty;
        public string ShippingPrefecture { get; set; } = string.Empty;
        public string ShippingCity { get; set; } = string.Empty;
        public string ShippingAddressLine { get; set; } = string.Empty;
        public string? ShippingPhone { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<OrderItemResponse> Items { get; set; } = new List<OrderItemResponse>();
    }
    
    public class OrderItemResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? ProductDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
    }
    
    public class OrderSummaryResponse
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string StatusText { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public int ItemCount { get; set; }
    }
}
