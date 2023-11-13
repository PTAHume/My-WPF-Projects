using System.Collections.ObjectModel;

namespace DataBinding.Models;

public class UserManager
{
    public static ObservableCollection<User> _DatabaseUsers = new() {
        new User { Email = "test1@user.com", UserName = "Test User 1" },
        new User { Email = "test2@user.com", UserName = "Test User 2" },
        new User { Email = "test3@user.com", UserName = "Test User 3" },
        new User { Email = "test4@user.com", UserName = "Test User 4" },
        new User { Email = "test5@user.com", UserName = "Test User 5" }
    };

    public static ObservableCollection<User> GetUsers() => _DatabaseUsers;

    public static void AddUser(User user) => _DatabaseUsers.Add(user);
}