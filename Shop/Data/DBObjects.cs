using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{  
    public class DBObjects
    {
        public static void GetObj(AppDBContent content)
        {         
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(x => x.Value));
            }

            if (!content.Cars.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "Электромобиль кроссовер.",
                        longDesc = "Тесла Модель Х - это полноразмерный кроссовер с тремя рядами сидений. " +
                        "Его габаритные размеры составляют: длина 5004 мм, ширина 2083 мм, высота 1626 мм, а колесная база- 3061 мм. " +
                        "Что касается дорожного просвета, то он напрямую зависит от положения пневматической подвески.",
                        img = "/img/tesla-x.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Электромобиль седан",
                        longDesc = "Знакомьтесь - Tesla Model S. " +
                            "Менять мир к лучшему этот полноразмерный пятидверный лифтбек класса люкс начал с 2012 года. " +
                            "Идейным отцом проекта является американский инженер и предприниматель Илон Маск, " +
                            "который еще в 2009 году представил прототип Model S всему миру на Франкфуртском автосалоне.",
                        img = "/img/tesla-s.jpg",
                        price = 143000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Tesla Model Y",
                        shortDesc = "Электрический кроссовер",
                        longDesc = "Tesla Model Y - электрический кроссовер производства компании Tesla. " +
                            "Модель была представлена в марте 2019 года, серийное производство начато на фабрике во Фримонте в январе 2020, " +
                            "а поставки потребителям с 13 марта 2020. Машина представлена как кроссовер среднего класса, " +
                            "аналогичная таким машинам как VW Touareg, Nissan Murano, " +
                            "Lexus RX и её электрическому конкуренту под названием Audi E-tron.",
                        img = "/img/tesla-y.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Nissan GT-R",
                        shortDesc = "Спортивный автомобиль",
                        longDesc = "Nissan GT-R - это четырехместный спорткар в кузове купе. " +
                        "Новый обвес немного повлиял на его габаритные размеры. " +
                        "Отныне, автомобиль насчитывает 4710 мм в длину, 1895 мм в ширину, " +
                        "1370 мм в высоту и 2780 мм между колесными парами. " +
                        "Дорожный просвет ожидаемо мал и составляет всего 105 миллиметров.",
                        img = "/img/nissan-gt-r.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = true,
                        category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Спортивный автомобиль",
                        longDesc = "BMW M3 – спортивный роскошный седан всемирно известного немецкого бренда. " +
                        "История модели ведет отсчет с 1986 года. " +
                        "В разное время автомобиль выпускался в кузовах седан, кабриолет, " +
                        "купе и всегда отличался превосходными техническими показателями. " +
                        "На сегодняшний день выпущено пять поколений авто. Машина широко известна во многих странах, включая и Россию.",
                        img = "/img/bmw-m3.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = false,
                        category = Categories["Классические автомобили"]
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
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили",desc = "Современный вид транспорта"},
                        new Category {categoryName = "Классические автомобили", desc = "Автомобили с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }        
    }    
}
