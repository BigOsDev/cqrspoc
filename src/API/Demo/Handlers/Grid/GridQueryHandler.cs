using CQRS.Common.Definitions;
using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using Demo.Models.Grid;
using System.Threading.Tasks;

namespace Demo.Handlers.Grid
{
    public class GridQueryHandler : QueryHandlerBase<GridQuery, ObjectResult<GridResult>>
    {
        public override Task<ObjectResult<GridResult>> Handle(GridQuery query)
        {
            var data = new List<Item>();
            data.Add(new Item()
            {
                Id = 101,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Danie dnia: Kurniki 3
                    Zestaw 1
                    Koperkowa z lanym ciastem
                    Rumsztyk z cebulką
                    Ziemniaki
                    Surówka 17 zł
                    Zestaw 2
                    Koperkowa z lanym ciastem
                    Wieprzowina na ostro
                    Ryż
                    Surówka 17 zł
                    Zestaw 3
                    Koperkowa z lanym ciastem
                    Penne z kurczakiem i pieczarkami 16 zł",
                Title = "Krem ziemniaczany z grzankami",
                Price = 17.50m,
                Rate = 4.72m,
                RestaurantId = 12,
                RestaurantName = "Lunch Bar TU",
                Votes = 351,
                Another1 = "Sugoroku",
                Another2 = "Shogi",
                Another3 = "Checkers",
                Another4 = "Ghosts",
            });
            ;

            data.Add(new Item()
            {
                Id = 911,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia:
                        Zupa dnia + Spaghetti z klopsikami wieprzowymi w sosie neapolitańskim
                        Cena promocyjna 19.90 obowiązuje w dniach pon-pt od 11.00 do 16.00. 
                        Aby skorzystać z promocji należy w koszyku pod zamówieniem zaznaczyć promocję Lunch Menu.
                        ",
                Title = "Lunch nr 1 - Spaghetti z klopsikami wieprzowymi",
                Price = 19.90m,
                Rate = 3.90m,
                RestaurantId = 13,
                RestaurantName = "  Pizzeria Banolli ",
                Votes = 51,
                Another1 = "Camelot",
                Another2 = "Patolli",
                Another3 = "Fletcher",
                Another4 = "Celica",
            });


            data.Add(new Item()
            {
                Id = 634,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia:
                        Zupa dnia + Grillowana pierś drobiowa podana na szpinaku w sosie serowym z ryżem i pomidorami
                        Cena promocyjna 19.90 obowiązuje w dniach pon-pt od 11.00 do 16.00. 
                        Aby skorzystać promocji należy w koszyku pod zamówieniem zaznaczyć promocję Lunch Menu",
                Title = "Lunch nr 2 - Grillowana pierś drobiowa podana na szpinaku w sosie serowym",
                Price = 22.00m,
                Rate = 4.50m,
                RestaurantId = 141,
                RestaurantName = "Bar TUTAM",
                Votes = 357,
                Another1 = "Corbin",
                Another2 = "Mondeo",
                Another3 = "France",
                Another4 = "Sugoroku",
            });


            data.Add(new Item()
            {
                Id = 637,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia: Zupa dnia + Sałatka Gyros kurczak, pomidor, ogórek, papryka, mix sałat, sos jogurtowy podana na cieście pizzowym",
                Title = "Lunch nr 3 - Sałatka Gyros",
                Price = 14.00m,
                Rate = 4.25m,
                RestaurantId = 19,
                RestaurantName = "Lunch Bar TU",
                Votes = 3567,
                Another1 = "Brennan",
                Another2 = "Wari",
                Another3 = "Patolli",
                Another4 = "Kalah",
            });


            data.Add(new Item()
            {
                Id = 6778,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"W dniu dzisiejszym zapraszamy na zupa ogórkowa, ryba z ziemniakami i surówka z kiszonej kapusty. cena: 15,00 zł / 20,00 zł z dowozem",
                Title = "Zupa ogórkowa, ryba z ziemniakami i surówka z kiszonej kapusty",
                Price = 20.00m,
                Rate = 4.10m,
                RestaurantId = 222,
                RestaurantName = "Lunch service",
                Votes = 324,
                Another1 = "Boxter",
                Another2 = "Ford",
                Another3 = "Olivia",
                Another4 = "Isla",
            });

            data.Add(new Item()
            {
                Id = 401,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Danie dnia: Kurniki 3
                    Zestaw 1
                    Koperkowa z lanym ciastem
                    Rumsztyk z cebulką
                    Ziemniaki
                    Surówka 17 zł
                    Zestaw 2
                    Koperkowa z lanym ciastem
                    Wieprzowina na ostro
                    Ryż
                    Surówka 17 zł
                    Zestaw 3
                    Koperkowa z lanym ciastem
                    Penne z kurczakiem i pieczarkami 16 zł",
                Title = "Krem ziemniaczany z grzankami",
                Price = 17.50m,
                Rate = 4.72m,
                RestaurantId = 12,
                RestaurantName = "Lunch Bar TU",
                Votes = 6725,
                Another1 = "Sugoroku",
                Another2 = "Shogi",
                Another3 = "Checkers",
                Another4 = "Ghosts",
            });
            ;

            data.Add(new Item()
            {
                Id = 888,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia:
                        Zupa dnia + Spaghetti z klopsikami wieprzowymi w sosie neapolitańskim
                        Cena promocyjna 19.90 obowiązuje w dniach pon-pt od 11.00 do 16.00. 
                        Aby skorzystać z promocji należy w koszyku pod zamówieniem zaznaczyć promocję Lunch Menu.
                        ",
                Title = "Lunch nr 1 - Spaghetti z klopsikami wieprzowymi",
                Price = 19.90m,
                Rate = 3.90m,
                RestaurantId = 13,
                RestaurantName = "  Pizzeria Banolli ",
                Votes = 123,
                Another1 = "Camelot",
                Another2 = "Patolli",
                Another3 = "Fletcher",
                Another4 = "Celica",
            });


            data.Add(new Item()
            {
                Id = 456,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia:
                        Zupa dnia + Grillowana pierś drobiowa podana na szpinaku w sosie serowym z ryżem i pomidorami
                        Cena promocyjna 19.90 obowiązuje w dniach pon-pt od 11.00 do 16.00. 
                        Aby skorzystać promocji należy w koszyku pod zamówieniem zaznaczyć promocję Lunch Menu",
                Title = "Lunch nr 2 - Grillowana pierś drobiowa podana na szpinaku w sosie serowym",
                Price = 22.00m,
                Rate = 4.50m,
                RestaurantId = 141,
                RestaurantName = "Bar TUTAM",
                Votes = 235,
                Another1 = "Corbin",
                Another2 = "Mondeo",
                Another3 = "France",
                Another4 = "Sugoroku",
            });


            data.Add(new Item()
            {
                Id = 386,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"Lunch dnia: Zupa dnia + Sałatka Gyros kurczak, pomidor, ogórek, papryka, mix sałat, sos jogurtowy podana na cieście pizzowym",
                Title = "Lunch nr 3 - Sałatka Gyros",
                Price = 14.00m,
                Rate = 4.25m,
                RestaurantId = 19,
                RestaurantName = "Lunch Bar TU",
                Votes = 234,
                Another1 = "Brennan",
                Another2 = "Wari",
                Another3 = "Patolli",
                Another4 = "Kalah",
            });


            data.Add(new Item()
            {
                Id = 563,
                Added = DateTime.Now.AddMinutes(-1),
                Description = @"W dniu dzisiejszym zapraszamy na zupa ogórkowa, ryba z ziemniakami i surówka z kiszonej kapusty. cena: 15,00 zł / 20,00 zł z dowozem",
                Title = "Zupa ogórkowa, ryba z ziemniakami i surówka z kiszonej kapusty",
                Price = 20.00m,
                Rate = 4.10m,
                RestaurantId = 222,
                RestaurantName = "Lunch service",
                Votes = 13,
                Another1 = "Boxter",
                Another2 = "Ford",
                Another3 = "Olivia",
                Another4 = "Isla",
            });

            data.ForEach(x => x.Description = Regex.Replace(x.Description, @"\t|\n|\r", ""));
            data.ForEach(x => x.Description = Regex.Replace(x.Description, @"\s+", " "));
            return Task.FromResult(new ObjectResult<GridResult>(new GridResult(data)));
        }

    }
}
