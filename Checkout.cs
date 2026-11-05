namespace CET2007_Week3_Workshop
{
    public class Checkout
    {
        // Version 1: basic total (tax already included by CalculateTotal)
        public double PlaceOrder(MenuItem item, int quantity)
        {
            return item.CalculateTotal(quantity);
        }

        // Version 2: basic total, then take off the discount
        public double PlaceOrder(MenuItem item, int quantity, double discountPercent)
        {
            double basicTotal = PlaceOrder(item, quantity);
            double discountAmount = basicTotal * discountPercent / 100;
            return basicTotal - discountAmount;
        }

        // Version 3: discounted total, then add the delivery fee
        public double PlaceOrder(MenuItem item, int quantity, double discountPercent, double deliveryFee)
        {
            double discountedTotal = PlaceOrder(item, quantity, discountPercent);
            return discountedTotal + deliveryFee;
        }
    }
}