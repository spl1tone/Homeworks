﻿namespace Homeworks;

public class Customer
{
    public int customerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public virtual List<Order> Orders { get; set; }
}
