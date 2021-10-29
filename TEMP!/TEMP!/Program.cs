using System;

namespace TEMP_
{
    class User
    {
        static User()
        {
            Console.WriteLine("Создан первый пользователь");
        }
        public User()
        {
            Console.WriteLine("jet");
        }

        public string UserName;
        public int _Id;
        public User(string UserName)
        {
            this.UserName = UserName;
            Console.WriteLine(UserName);

        } public User(int Id)  
        {
            _Id = Id;

        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(); // здесь сработает статический конструктор
            //User user2 = new User();
            User user3 = new User("dfg");
            user3._Id = 12345;
            Console.WriteLine(user3._Id.ToString(), user3.UserName);

            Console.Read();
        }
    }
}
