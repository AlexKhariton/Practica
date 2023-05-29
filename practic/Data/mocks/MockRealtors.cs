using practic.Data.Interfaces;
using practic.Data.Models;

namespace practic.Data.mocks
{
    public class MockRealtors : IAllRealtors
    {
        private readonly IRealtorsCategory _category = new MockCategory();
        public IEnumerable<Realtor> Realtors
        {
            get
            {
                return new List<Realtor>
                {
                    new Realtor
                    {
                        name = "Петров Н.В.",
                        shortDesc = "Компания ОАО Желток",
                        longDesc = "Найдем лучшее предложение на рынке",
                        img = "/img/realtor_1.jpg",
                        price = 45000,
                        Category = _category.AllCategories.First()
                    },
                    new Realtor
                    {
                        name = "Борисов К.А.",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Дешево, быстро, надежно",
                        img = "/img/realtor_2.jpg",
                        price = 20000,
                        Category = _category.AllCategories.Last()
                    },
                    new Realtor
                    {
                        name = "Колмаков Ю.Н.",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Ваше жилье уже ищет вас",
                        img = "/img/realtor_3.jpg",
                        price = 65000,
                        Category = _category.AllCategories.Last()
                    },
                    new Realtor
                    {
                        name = "Борисов К.М",
                        shortDesc = "Компания ОАО Желток",
                        longDesc = "Кто ищет тот всегда найдет",
                        img = "/img/realtor_4.jpg",
                        price = 55000,
                        Category = _category.AllCategories.First()
                    },
                    new Realtor
                    {
                        name = "Швагин Н.Г",
                        shortDesc = "Компания ОАО Домовой",
                        longDesc = "Красиво жить не запретишь",
                        img = "/img/realtor_5.jpg",
                        price = 13000,
                        Category = _category.AllCategories.Last()
                    }
                };
            } 
        }

        public Realtor getObjRealtor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
