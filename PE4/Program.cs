namespace PE4
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

        }


        class Sample
        {
            static Sample()
            {
                Console.WriteLine("1");
            }
            public Sample()
            {
                Console.WriteLine("2");
            }
            static void Main(string[] args) 
            {
                Sample obj = new Sample();  
                Console.WriteLine();
            }
        }




    }
}