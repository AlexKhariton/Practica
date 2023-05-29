using practic.Data.Models;
using System.Runtime.Serialization;

namespace practic.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any()) 
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Realtor.Any())
            {
                content.AddRange(
                    new Realtor
                    {
                        name = "Петров Н.В.",
                        shortDesc = "Компания ОАО Желток",
                        longDesc = "Найдем лучшее предложение на рынке",
                        img = "/img/realtor_1.jpg",
                        price = 45000,
                        Category = Categories["Премиум"]
                    },
                    new Realtor
                    {
                        name = "Борисов К.А.",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Дешево, быстро, надежно",
                        img = "/img/realtor_2.jpg",
                        price = 20000,
                        Category = Categories["Стандарт"]
                    },
                    new Realtor
                    {
                        name = "Колмаков Ю.Н.",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Ваше жилье уже ищет вас",
                        img = "/img/realtor_3.jpg",
                        price = 65000,
                        Category = Categories["Премиум"]
                    },
                    new Realtor
                    {
                        name = "Петриков А.Д.",
                        shortDesc = "Компания ОАО Желток",
                        longDesc = "Кто ищет тот всегда найдет",
                        img = "/img/realtor_4.jpg",
                        price = 55000,
                        Category = Categories["Премиум"]
                    },
                    new Realtor
                    {
                        name = "Швагерев В.О.",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Красиво жить не запретишь",
                        img = "/img/realtor_5.jpg",
                        price = 13000,
                        Category = Categories["Стандарт"]
                    }
                );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if( category == null ) 
                {
                    var list = new Category[]
                    {
                        new Category {categoryname = "Премиум", desc = "Дорого богато"},
                        new Category {categoryname = "Стандарт", desc = "Цена = качество"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach( Category c in list )
                        category.Add( c.categoryname, c );
                }
                return category;
            }
        }
    }
}
