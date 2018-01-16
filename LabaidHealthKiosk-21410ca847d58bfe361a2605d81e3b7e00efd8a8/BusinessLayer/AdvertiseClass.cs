using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class AdvertiseClass
    {
        public static void AddAdvertise(string uName, string type, string link)
        {
            var context = new ContextDb();

            context.Advertisements.Add(new Advertisement()
            {
                UserName = uName,
                AdType = type,
                AdLink = link
            });
            context.SaveChanges();
        }
    }
}
