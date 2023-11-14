using ConsoleApp1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class GroupService
    {
        public void AddGroup(Group group)
        {
            AppDBContext dbContextg = new AppDBContext();
            dbContextg.Groups.Add(group);
            dbContextg.SaveChanges();
        }
    }
}
