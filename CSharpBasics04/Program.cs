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

            #region Question07
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            //// I expect that pages will store 450 instead of 400 since it was passed by reference and added 50 in the function
            #endregion

            #region Question08
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Question09
            //if (TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine(price);
            //}
            #endregion

            #region Question10
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code", 500);
            #endregion

            #region Question11
            //PrintBookInfo(pages: 500, title: "Clean Code");
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

        #region Question07
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion

        #region Question08
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region Question09
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion

        #region Question10 
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title: {title}, pages: {pages}");
        }
        #endregion
    }
}
