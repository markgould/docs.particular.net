using System;
using NServiceBus;

public class PlaceOrder :
    ICommand
{
    public Guid OrderId { get; set; }
    public int UserId { get; set; }
}