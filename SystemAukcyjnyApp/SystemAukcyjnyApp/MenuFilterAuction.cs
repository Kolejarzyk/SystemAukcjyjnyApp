using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    class MenuFilterAuction
    {
    
        public static void FilterPick(DatabaseOfAuctions database, DatabaseOfUsers users)
        {
            Console.WriteLine("Filtrowanie aukcji");
            Console.WriteLine("1.Filtrowanie zakończonych aukcji" + "\n"
                               + "2.Filtrowanie niezakończonych aukcji" + "\n"
                               + "3.Filtrowanie po użytkowniku");
            
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    try
                    {
                       Console.WriteLine("Filtrowanie zakończonych aukcji");
                        IFilterAuction filter = new FilterEndedAuction();
                        filter.Filter(database);
                    }
                    catch (Exception e) { Console.Write("Brak aukcji w bazie"); }

                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Filtrowanie niezakończonych aukcji");
                        IFilterAuction filter = new FilterNotEndedAuction();
                        filter.Filter(database);
                    }
                    catch (Exception e) { Console.WriteLine("Brak aukcji w bazie"); }

                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Filtrowanie po użytkowniku");
                        IFilterAuction filter = new FilterAuctionByUser();
                        filter.Filter(database);
                    }
                    catch (Exception e) { Console.WriteLine("Brak aukcji w bazie"); }


                    break;
            }
        }
    }
}
