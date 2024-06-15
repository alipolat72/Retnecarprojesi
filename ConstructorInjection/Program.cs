using System;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = new DatabaseLogger();
           // logger.log();

            CustomerManeger customerManeger = new CustomerManeger(new DosyaLogger());
            //customerManeger.Logger=new DatabaseLogger();
             customerManeger.AddLog();
             customerManeger.AddData();
           
 
        }
        

    }
    interface ILogger
    {
        void log();
        void Add();
    }

    class DatabaseLogger : ILogger
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void log()
        {
            Console.WriteLine("DataBaseLogger tabanına Loglandı");
        }

    }
    class FileLogger : ILogger
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void log()
        {
            Console.WriteLine("FileLogger'a   Loglandı");
        }
    }
    class SmsLogger : ILogger
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void log()
        {
            Console.WriteLine("müşteriye sms yollandı");
        }
    }
    class DosyaLogger : ILogger
    {
        public void Add()
        {
            Console.WriteLine("ürün DosyaLoggera eklendi");
        }

        public void log()
        {
            Console.WriteLine("DosyaLogger da Çalıştı");
        }
    }

    class CustomerManeger
    {
        ILogger _logger;

        public CustomerManeger(ILogger logger)
        {
            _logger = logger;
        }

        public void AddLog()
        {
            _logger.log(); 
        }

        public void AddData()
        {
            _logger.Add();
        }
    }





    //class CustomerManeger
    //{
    //    ILogger _logger;
    //    public CustomerManeger(ILogger logger)
    //    {
    //        _logger = logger;
    //    }
    //    public void Add()
    //    {
    //        _logger.log();
    //    }

    //}

}
