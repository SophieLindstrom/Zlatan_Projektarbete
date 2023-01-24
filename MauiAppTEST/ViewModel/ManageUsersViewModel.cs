using CommunityToolkit.Mvvm.ComponentModel;
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
    [QueryProperty(nameof(User), nameof(User))]
    public partial class ManageUsersViewModel : BaseViewModel
    {
        //public ObservableCollection<string> CommentList { get; } = new();

        [ObservableProperty]
        User user;

        public ObservableCollection<User> Users;
        public ManageUsersViewModel()
        {
            Users = LoadUsers();
            //LoadUserComments();
        }

        //void LoadUserComments()
        //{
        //    var users = UserServices.GetUsers().FirstOrDefault(x => x.UserName == User.UserName);

        //    foreach (var comment in users.CommentList)
        //    {
        //        CommentList.Add(comment);
        //    }
        //}

        public ObservableCollection<User> LoadUsers()
        {
            List<User> users = UserServices.GetUsers();
            ObservableCollection<User> tmp = new ObservableCollection<User>();

            foreach (var item in users)
            {
                tmp.Add(item);
            }

            return tmp;

            //foreach (var user in users)
            //    Users.Add(user);
        }
    }
}
