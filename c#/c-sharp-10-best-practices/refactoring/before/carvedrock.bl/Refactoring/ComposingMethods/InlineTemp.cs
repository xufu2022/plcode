namespace carvedrock.bl.Refactoring.ComposingMethods
{
    public class InlineTemp
    {
        public static double UpdatePrice(double total, double discountPercent)
        {
            var discount = total * discountPercent;
            total -= discount;
            return total;
        }
    }
}
