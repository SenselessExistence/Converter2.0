using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Converter2._0
{
    public class UserManagment
    {
        public UserManagment()
        {
            this.FileLink = "users.json";
            this.Stream = new FileStream(FileLink, FileMode.OpenOrCreate);
            this.Stream.Close();
            this.Reader = new FileStream(FileLink, FileMode.Open);
            this.Reader.Close();
        }
        protected string? Json { get; set; }
        protected string FileLink { get; set; }
        protected FileStream Stream { get; set; }
        protected FileStream Reader { get; set; }

        public List<User> Users
        {
            get { return InitializeUsers(); }
            set { }
        }
        protected List<User> InitializeUsers()
        {
            var users = new List<User>();
            using (this.Reader)
            {
                var UserList = JsonSerializer.Deserialize<List<User>>();
            }
            return;
        }
        public async void RegUser(string username, string password, string email)
        {

            using (this.Stream)
            {
                this.Users.Add(new User(username, password, email));
                await JsonSerializer.SerializeAsync<List<User>>(Stream, Users);
                Stream.Close();
            }
        }
    }
}
