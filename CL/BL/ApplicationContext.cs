using log4net;
using System;
using System.Collections.Generic;
//вносим изменения

namespace CL
{
    public static class ApplicationContext
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ApplicationContext));

        public static List<Goods> Goods = new List<Goods>();
        public static List<Employee> Employees = new List<Employee>();
        public static List<Buyer> Buyers = new List<Buyer>();
        public static List<Check> Checks = new List<Check>();

        private static void MakeRandomChecks(int count)
        {
            log.Debug($"Making of {count} random checks");
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Checks.Add(new Check()
                {
                    Number = i + 1,
                    Buyer = Buyers[random.Next(0, Buyers.Count)],
                    Employee = Employees[random.Next(0, Employees.Count)],
                    SaleDate = DateTime.Now.AddDays(random.Next(-30, 30)),
                    Cart = new Cart()
                    {
                        Items = new List<CartItem>()
                        {
                        new CartItem() { Goods = Goods[random.Next(0, Goods.Count)], GoodsCount = random.Next(1, 10) },
                        new CartItem() { Goods = Goods[random.Next(0, Goods.Count)], GoodsCount = random.Next(1, 10) }
                        }
                    }
                });
            }
        }

        public static void Init()
        {
            log.Debug("Init application context");
            Goods.Add(new Product()
            {
                Brand = "Агуша",
                Cost = 790,
                Manufacturer = "ООО Завод",
                Name = "Фруктовое пюре",
                Weight = 250
            });
            Goods.Add(new Drink()
            {
                Brand = "Coca-Cola",
                Cost = 289,
                Manufacturer = "PepsiCo",
                Name = "Coca-Cola, газ.",
                Volume = 2
            });
            Buyers.Add(new Buyer()
            {
                SurName = "Петров",
                FirstName = "Петр",
                PhoneNumber = "+7(023)924-03-21",
                Email = "petr2012@mail.ru"
            });
            Employees.Add(new Employee()
            {
                SurName = "Иванов",
                FirstName = "Иван",
                PhoneNumber = "+7(111)345-34-09",
                Position = "Продавец"
            });

            MakeRandomChecks(100);
        }
    }
}