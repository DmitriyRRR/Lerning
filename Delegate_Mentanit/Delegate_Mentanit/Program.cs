using System;

namespace Delegate_Mentanit
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(150);
            //Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Color_Message);
            Account.AccountStateHandler colorDelegate = Color_Message;
            // Добавляем в делегат ссылку на методы
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.RegisterHandler(colorDelegate);
            // Два раза подряд пытаемся снять деньги
            //account.withdraw(100);
            account.Withdraw(150);

            // Удаляем делегат
            account.UnregisterHandler(colorDelegate);
            account.Withdraw(50);
            Console.ReadLine();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
        private static void Color_Message(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
    }
    class Account
    {
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del; // добавляем делегат
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del; // удаляем делегат
        }
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _del;

        // Регистрируем делегат
       


        int _sum; // Переменная для хранения суммы

        public Account(int sum)
        {
            _sum = sum;
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;

                /*if (_del != null)
                    _del($"Сумма {sum} снята со счета");*/
                _del?.Invoke($"Сумма {sum} снята со счета");
            }
            else
            {
                /*if (_del != null)
                    _del("Недостаточно денег на счете");*/
                _del?.Invoke("Not enough money");
            }
        }
    }
}
