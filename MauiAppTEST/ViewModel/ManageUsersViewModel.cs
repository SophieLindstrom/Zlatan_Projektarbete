using MauiAppTEST.Services;
using MauiAppTEST.TestData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTEST.ViewModel
{
    public partial class ManageUsersViewModel
    {

        public ObservableCollection<User> Users { get; } = new();

        public ManageUsersViewModel()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            List<User> users = UserServices.GetUsers();

            foreach (var user in users)
                Users.Add(user);
        }
    }
}
