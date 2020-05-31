using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemelMvc.Entity;

namespace TemelMvc
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k+s
            //NorthwindContext db = new NorthwindContext();
            #region Listele
            //Read
            //var result = db.Categories;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //} 
            #endregion
            #region Bulma
            //var result = db.Categories.Find(8);
            //Console.WriteLine(result.CategoryName);
            #endregion
            #region Ekleme
            //Category category = new Category();
            //category.CategoryName = "Ferit";
            //category.Description = "Football";
            //db.Categories.Add(category);
            //db.SaveChanges(); 
            #endregion
            #region Silme
            //var result = db.Categories.Find(1009);
            //db.Categories.Remove(result);
            //db.SaveChanges(); 
            #endregion
            #region Using ekleme
            //using (NorthwindContext db=new NorthwindContext())
            //{
            //    var category = new Category { CategoryName = "ferit", Description = "football" };
            //    db.Categories.Add(category);
            //    db.SaveChanges();
            //}
            #endregion
            #region Liste halinde ekleme
            //        Category[] persons = new Category[]
            //{
            //    new Category { CategoryName = "fdsaf", Description = "Tom" }
            //    //new Category { LanguageId = 1, FirstName = "Sandy" },
            //    //new Category { LanguageId = 2, FirstName = "Vladimir" },
            //    //new Category { LanguageId = 2, FirstName = "Mikhail" },
            //}; 
            #endregion

            #region LinqSelect
            //using (NorthwindContext northwindContext =new NorthwindContext())
            //{
            //    List<Category> categories = (from c in northwindContext.Categories
            //                                      select c).ToList();
            //    foreach (var item in categories)
            //    {
            //        Console.WriteLine(item.CategoryName);
            //    }
            //} 
            #endregion
            #region LinqSelectKısıtlamalı
            //using (NorthwindContext northwind=new NorthwindContext())
            //{
            //    var category = from c in northwind.Categories
            //                   select new
            //                   {
            //                       c.CategoryName,
            //                       c.Description
            //                   };
            //    foreach (var item in category)
            //    {
            //        Console.WriteLine(item);
            //    }
            //} 
            #endregion
            using (NorthwindContext northwindContext =new NorthwindContext())
            {
                #region hepsini listeleme
                //var category = northwindContext.Categories;
                //foreach (var item in category)
                //{
                //    Console.WriteLine(item.CategoryName);
                //} 
                #endregion
                #region metodwhereişlemi
                //var category = northwindContext.Categories.Where(i => i.CategoryName == "Beverages"); 
                #endregion
                #region ilkikisini alma
                //var category = northwindContext.Categories.Take(2); 
                #endregion
                #region Orderbyişlemi
                //var category = northwindContext.Categories.OrderBy(x => x.CategoryID); 
                #endregion
                #region wherekosulu
                //var category = northwindContext.Categories.Where(x => x.CategoryID > 3 && x.CategoryID < 6); 
                #endregion
                //ConsoleTable.From(category).Write();
                #region Sumİşlemi
                //var category=northwindContext.Categories.Sum(x => x.CategoryID); 
                //max min avg hepsi aynı işlemi yapmaktadır.
                #endregion

                #region OrderByThenBy )> orderby dan sonraki sıralama işlemini yapmak için thenby kullanılır.
                //var category = northwindContext.Categories.OrderBy(x => x.CategoryID).ThenBy(x => x.CategoryName).Select(x => new
                //{
                //    x.CategoryName,
                //    x.Description
                //}); 
                #endregion

                #region SkipTake )> skip ile ilk kaç tane pas geçilecek take ile kaç tane data alınacak skiptenden önce orderby kullanılmalı.
                //var category = northwindContext.Categories.OrderBy(x=>x.CategoryID).Skip(2).Take(2).Select(x => new
                //{
                //    x.CategoryName,
                //    x.Description
                //}); 
                #endregion

                #region All )>Bütün değerler koşulu sağlarsa true döner eğer bir tanesi bile değilse false döner
                //var category = northwindContext.Categories.All(x => x.CategoryID > 0); 
                #endregion

                #region Any )> Değerlerden sadece bir tanesi koşulu sağlarsa true döner eğer hiçbir koşula uymazsa false döner
                //var category = northwindContext.Categories.Any(x => x.CategoryID > 100000); 
                #endregion

                #region Single )> istenilen koşulda bir değer varsa getirir yoksa hata atar
                //var category = northwindContext.Categories.Single(x => x.CategoryID == 1); 
                #endregion

                #region SingleorDefault )> istenilen koşula ait birden fazla değer varsa hata atar eğer hiç hiç eleman yoksa null atar
                //var category = northwindContext.Categories.SingleOrDefault(x => x.CategoryID == 1000); 
                #endregion

                #region First )> istenilen kayıtta birden fazla değer varsa ilkini getirir eğer hiç değer yoksa hata atar
                //var category = northwindContext.Categories.First(x => x.CategoryID > 1); 
                #endregion

                #region Eğer istenilen koşul varsa ilk değeri getirir değer yoksa null atar hata patlatmaz
                var category = northwindContext.Categories.FirstOrDefault(x => x.CategoryID > 50); 
                #endregion

                Console.WriteLine(category);
                //ConsoleTable.From(category).Write();
            }
            Console.ReadLine();
        }
    }
}
