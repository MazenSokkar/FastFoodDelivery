using System;
using System.ComponentModel.DataAnnotations;

namespace FastFoodDelivery.Models;

public class OrderHeader
{
    public int Id { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    [DataType(DataType.Date)]
    public DateTime OrderDate { get; set; }
    public DateTime TimeOfPick { get; set; }
    public DateTime DateOfPick { get; set; }
    public double SubTotal { get; set; }
    public double OrderTotal { get; set; }
    public string CouponCode { get; set; }
    public double CouponDis { get; set; }
    public string TransId { get; set; }
    public string OrderStatus { get; set; }
    public string PaymentStatus { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}
