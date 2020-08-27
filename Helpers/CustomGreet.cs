using System;

namespace blazorTeste1.Client.Helpers
{
    class CustomGreet
    {

        public static string customGreeting (string value)
        {
            return value.ToUpper() + " hoje é " + DateTime.Today;
        }

    }
}