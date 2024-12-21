using MonsterFactory.Monsters;

namespace ProjectReptile
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Cultist_1 cultist_1 = new Cultist_1();
            Cultist_1 cultist = new Cultist_1();
            Console.WriteLine(cultist.Constitution);
            Console.WriteLine(cultist_1.Constitution);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}