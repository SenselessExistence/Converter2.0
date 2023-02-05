using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Converter2._0
{
    public class UserManagment
    {
        public UserManagment()
        {
            this.FileLink = "users.json";
            this.Stream = new FileStream(FileLink, FileMode.OpenOrCreate);
            InitializeUsers();
            this.Stream.Close();
            this.Reader = new FileStream(FileLink, FileMode.Open);
            this.Reader.Close();
        }
        protected string FileLink { get; set; }
        protected FileStream Stream { get; set; }
        protected FileStream Reader { get; set; }

        public List<User> Users { get; set; }
        protected async void InitializeUsers()
        {
            using (Stream)
            {
                if (Stream.Length != 0)
                {
                    StreamReader reader = new StreamReader(Stream, Encoding.UTF8);
                    this.Users = (List<User>)JsonConvert.DeserializeObject(reader.ReadToEnd());
                }
                Stream.Close();
            }
        }
        public async void RegUser(string username, string password, string email)
        {

            using (this.Stream)
            {
                this.Users.Add(new User(username, password, email));
                await System.Text.Json.JsonSerializer.SerializeAsync<List<User>>(Stream, Users);
                Stream.Close();
            }
        }
    }
}
