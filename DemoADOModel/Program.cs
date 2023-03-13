namespace DemoADOModel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

/*
            static int GetValue(out int a,out int b, int c)
            {
                a = ++c;
                b = a++;
                return c;
            }
            static void Main(string[] args)
            {
                int a = 3, b = 4, c = 5;
                c = GetValue(out a, out b, c);  
                Console.WriteLine($"a={a},b={b},c={c}");
            }
        A. a = 7, b = 8, c = 8
        B. a = 5, b = 5, c = 5
        C. a = 7, b = 6, c = 6
        D. a = 5, b = 2, c = 4
*/

        }
    }
}