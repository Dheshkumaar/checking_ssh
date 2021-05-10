using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQEg.pubsModel;

namespace LINQEg
{
    class nwClient
    {
        public static pubsContext db = new pubsContext();
        public static void Main()
        {
            List<Author> auths = db.Authors.ToList();
            var result = (from i in auths
                          where i.City == "Oakland"
                          select i).ToList();
            var res = auths.Where(i => i.City == "Oakland").Select(i => i).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item.AuId+" "+item.AuFname+" "+item.City);
            }
        }

    }
}
