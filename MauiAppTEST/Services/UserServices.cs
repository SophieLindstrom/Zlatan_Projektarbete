using MauiAppTEST.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTEST.Services
{
    public class UserServices
    {
        public static List<User> GetUsers()
        {
            List<User> userList = new List<User>()
            {
                new User(){ UserName="Prince_Charming69", Comment="HAHHAHA" },
                new User(){ UserName="Janne", Comment="SVETTIG" },
                new User(){ UserName="Svettig_Runkare", Comment="What's wrong with being racist LuL XD?" },
                new User(){ UserName="Apan", Comment="Ahmed kmr doda dig mannen" },
                new User(){ UserName="Peddo_Björnkillen1992", Comment="Eeeeehhh, okej?" },
                new User(){ UserName="Svettig", Comment="passa dig bror" },
                new User(){ UserName="Coolaste_Shonon", Comment="Eyyy grabbar looogna er" },
                new User(){ UserName="Mannen123", Comment="Son javla hura hon e" },
            };

            return userList;
        }
    }
}
