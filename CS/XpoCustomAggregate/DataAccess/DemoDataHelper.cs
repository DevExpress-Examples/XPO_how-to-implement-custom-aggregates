using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XpoCustomAggregate {
    public static class DemoDataHelper {
        private static string[] firstNames = new string[] {
            "Peter", "Ryan", "Richard", "Tom", "Mark"};
        private static string[] lastNames = new string[] {
            "Dolan", "Fischer", "Hamlett", "Hamilton", "Lee", "Lewis" };
        private static string[] productNames = new string[] {
            "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning",
            "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread",
            "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce",
            "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora",
            "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton"};
        private static Random Random = new Random(0);

        public static void Seed() {
            using(UnitOfWork uow = new UnitOfWork(XpoDefault.DataLayer)) {
                if(uow.Query<Customer>().Count() > 0) {
                    return;
                }
                List<Customer> customers = new List<Customer>();
                for(int i = 0; i < firstNames.Length; i++) {
                    for(int j = 0; j < lastNames.Length; j++) {
                        customers.Add(new Customer(uow) {
                            FirstName = firstNames[i],
                            LastName = lastNames[j]
                        });
                    }
                }
                const int recordsCount = 500;
                for(int i = 0; i < recordsCount; i++) {
                    Order order = new Order(uow);
                    order.ProductName = productNames[Random.Next(productNames.Length)];
                    order.OrderDate = new DateTime(Random.Next(2014, 2024), Random.Next(1, 12), Random.Next(1, 28));
                    order.Price = 1 + Random.Next(10000) / 100m;
                    order.Quantity = 1 + Random.Next(100);
                    order.Customer = customers[Random.Next(customers.Count)];
                }
                uow.CommitChanges();
            }
        }
    }
}