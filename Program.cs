namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var p in seafoodProducts)
            //{
            //    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C}");
            //}
            #endregion

            #region Question 2
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Question 3
            //var sortedProducts = ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var p in sortedProducts)
            //{
            //    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C}");
            //}
            #endregion

            #region Question 4
            //var midRangeProducts = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            #endregion

            #region Question 5
            var inStockCondiments = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion

            #region Question 6
            var productStatusList = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            foreach (var p in productStatusList)
            {
                Console.WriteLine($"Name: {p.Name}, Price: {p.Price:C}, Status: {p.StockStatus}");
            }
            #endregion

            #region Question 7
            var numberedProducts = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

            foreach (var formattedName in numberedProducts)
            {
                Console.WriteLine(formattedName);
            }
            #endregion

            #region Question 8
            var complexSortedProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            #endregion

            #region Question 9
            var beverageStock = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);

            foreach (var p in beverageStock)
            {
                Console.WriteLine($"Name: {p.ProductName}, Stock: {p.UnitsInStock}");
            }
            #endregion

            #region Question 10
            var recentOrders = from customer in CustomerList
                               from order in customer.Orders
                               where order.OrderDate.Year >= 1997
                               select new { customer.CustomerID, order.OrderDate };
            #endregion

            #region Question 11
            var productPositions = ProductList.Select((p, index) => new
            {
                Position = index + 1,
                p.ProductName
            });
            #endregion

            #region Question 12
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BIUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Question 13
            string[] digitArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var filteredReversedDigits = digitArr
                .Where(word => word.Length > 1 && word[1] == 'i')
                .Reverse();
            #endregion



        }
    }
}
