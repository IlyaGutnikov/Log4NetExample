using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Log4net_test
{
    class Program
    {
        static ILog Log = LogManager.GetLogger(Assembly.GetExecutingAssembly().Location + ".log");

        private static void Main()
        {  
            string pathToConfigFile = "C:\\Users\\igutnikov\\Documents\\Visual Studio 2015\\Projects\\Log4net-test\\config.xml";
            FileInfo fileWithConfig = new FileInfo(pathToConfigFile);

            XmlConfigurator.Configure(fileWithConfig);

            Log.Debug("Hello, log!");
            Console.ReadLine();
        }
    }
}