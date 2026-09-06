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
    }
}
