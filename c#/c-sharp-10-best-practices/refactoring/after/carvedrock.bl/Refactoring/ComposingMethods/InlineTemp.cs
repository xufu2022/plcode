namespace carvedrock.bl.Refactoring.ComposingMethods
{
    public class InlineTemp
    {
        public static double UpdatePrice(double total, double discountPercent)
        {
            return total - (total * discountPercent);
        }
    }
}
