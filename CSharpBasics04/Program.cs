namespace CSharpBasics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question02
            //int[,] shelfCopies = {
            //    { 3, 5 },
            //    { 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question03
            //PrintWelcomeMessage();
            #endregion

            #region Question04
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question05
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //// I expect that pages will still store 400 and not 450 because it was passed by value
            #endregion

            #region Question06
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //// I expect prices[0] will store 20.5 because a copy of the array reference is passed and both references point to the same array
            #endregion

        }

        #region Question03
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region Question04
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        #endregion

        #region Question05
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion

        #region Question06
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion
    }
}
