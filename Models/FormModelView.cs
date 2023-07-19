namespace Example07New.Models
{
    public class FormCategoryView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Summary { get; set; }
        public string? Photo { get; set; }
        public short IsParent { get; set; }
        public long? ParentId { get; set; }
        public long? AddedBy { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
    public class FormProductView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string? Description { get; set; }
        public string Photo { get; set; } = null!;
        public int Stock { get; set; }
        public string? Size { get; set; }
        public string Condition { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public short IsFeatured { get; set; }
        public long? CatId { get; set; }
        public long? ChildCatId { get; set; }
        public long? BrandId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormBannerView
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Photo { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormBrandView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormCartView
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long? OrderId { get; set; }
        public long? UserId { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
    public class FormCouponView
    {
        public long Id { get; set; }
        public string Code { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal Value { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormMessageView
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Phone { get; set; }
        public string Message1 { get; set; } = null!;
        public DateTime? ReadAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormNotificationView
    {
        public string Id { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string NotifiableType { get; set; } = null!;
        public long NotifiableId { get; set; }
        public string Data { get; set; } = null!;
        public DateTime? ReadAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormOrderView
    {
        public long Id { get; set; }
        public string OrderNumber { get; set; } = null!;
        public long? UserId { get; set; }
        public decimal SubTotal { get; set; }
        public long? ShippingId { get; set; }
        public decimal? Coupon { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? PostCode { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormPostView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string? Description { get; set; }
        public string? Quote { get; set; }
        public string? Photo { get; set; }
        public string? Tags { get; set; }
        public long? PostCatId { get; set; }
        public long? PostTagId { get; set; }
        public long? AddedBy { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormPostCategoryView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormPostCommentView
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? PostId { get; set; }
        public string Comment { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? RepliedComment { get; set; }
        public long? ParentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormPostTagView
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormProductReviewView
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? ProductId { get; set; }
        public short Rate { get; set; }
        public string? Review { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormShippingView
    {
        public long Id { get; set; }
        public string Type { get; set; } = null!;
        public decimal Price { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormUserView
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string? Password { get; set; }
        public string? Photo { get; set; }
        public string Role { get; set; } = null!;
        public string? Provider { get; set; }
        public string? ProviderId { get; set; }
        public string Status { get; set; } = null!;
        public string? RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormSettingView
    {
        public long Id { get; set; }
        public string Description { get; set; } = null!;
        public string ShortDes { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string Photo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormWishlistView
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long? CartId { get; set; }
        public long? UserId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class FormFailedJobView
    {
        public long Id { get; set; }
        public string Connection { get; set; } = null!;
        public string Queue { get; set; } = null!;
        public string Payload { get; set; } = null!;
        public string Exception { get; set; } = null!;
        public DateTime FailedAt { get; set; }
    }
}
