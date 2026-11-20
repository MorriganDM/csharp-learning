
decimal[] orders = { 100m, 200m, 50m, 300m };
decimal[] discountRates = { 10m, 20m, 0m, 50m };

for (int i = 0; i < orders.Length; i++)
{
    decimal finalPrice = CalculateFinalPrice(
        orders[i],
        discountRates[i]
    );

    Console.WriteLine($"Pedido {i + 1}: R$ {finalPrice:F2}");
}

static decimal CalculateFinalPrice(decimal total, decimal discountRate)
{
    decimal discount = total * (discountRate / 100m);

    if (discountRate == 0)
    {
        return total;
    }

    if (discountRate >= 50)
    {
        discount = 50m;
    }

    return total - discount;
}
