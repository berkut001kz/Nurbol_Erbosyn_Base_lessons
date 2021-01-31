using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Base_Lessons
{
    class Result
    {


        /*
         * Өткен сабақтардан нәтиже шығарып көремін
         * Консольден логин пароль сұрап сосын оны файлға сақтаймыз және 
         * кіру деп шығарып сақталған логин парольді тексереміз бар болса Қош келдіңіз жоқ болса логин немесе пароль қате дейміз
         * 
         * енді осылай қалай жасаймыз?????????????
         * 
         * ең алдымен пайдаланушыдан деректерін еңгізуді сұрайтын әдіс керек  Console.ReadLine() қажет
         * және ақпаратты сақтайтын файл керек файлды құру, жою, оқу үшін File() class-сы қажет
         * және ақпаратты оқу үшін тізбек(array) керек
         * және бұйрық беріп басқару үшін талдайтын swich қажет
         * және логинды парольді тексеру,қате жөңінде ақпарат беру үшін Try and Catch керек
         * және бұлардын бәрін реттеу үшін әдістер(methods) қажет
         * 
         * 
         * еңді кодпен жасап көрейін:
         */


        private string login;
        private string password;
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        static string directory = Path.Combine(path, "File_info_class");
        static string file = Path.Combine(directory, "users.txt");


        // Негізгі терезе
        public static void MainWindow()
        {
            Result registerUser = new Result();
            //registerUser.Register();

            Console.WriteLine("Жол нұсқау");
            Console.WriteLine("Сіз тіркелгенсізбе?\n " +
                                "Тіркелсеңіз \"L\" батырмасын басыңыз. \n " +
                                "Тіркелмеген болсаңыз \"R\" батырмасын басыңыз. \n " +
                                "Бастапқы бетке қайту үшін \"H\" батырмасын басыңыз. \n Сақталған файлды жою үшін \"D\" батырмасын басыңыз!!!");


            string command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "R":
                    registerUser.Register();
                    break;
                case "L":
                    registerUser.Login();
                    break;
                case "H":
                    Result.MainWindow();
                    break;
                case "D":
                    Result.DeleteFile();
                    break;
                default:
                    Console.WriteLine("Сізді түсінбедім Төмендегі бұйрық батырмалардын біреуін басыңыз");
                    Result.MainWindow();
                    break;
            }
        }




        //Пайдаланушыдан деректерін алу және сақтау
        /// <summary>
        /// Жүйеге тіркелу
        /// </summary>
        public void Register()
        {
            Console.WriteLine("Тіркелу");
            

            try
            {
                Console.Write("Ойдан логин жазыңыз: ");
                login = Console.ReadLine();

                Console.Write("Ойдан пароль жазыңыз: ");
                password = Console.ReadLine();

                // "H" немесе "h" батырмасын басу арқылы бастапқы бетке қайту
                if (login == "h" || password == "h") Result.MainWindow();
                if (login == "H" || password == "H") Result.MainWindow();

                //Файл бар болса
                if (File.Exists(file))
                {
                    string[] users = File.ReadAllLines(file, Encoding.UTF8);

                    // Логин сақталған файлда барма жоқпа тексеру
                    for (int i = 0; i < users.Length; i++)
                    {
                        // Логин сақталған файлдан Логинды қыйып алу үшін
                        int loginIndex = users[i].IndexOf(":");
                        int loginIndexEnd = users[i].IndexOf(",");



                        // Логин,Пароль сақталған файлдан Логин мен Парольды қыйып алу
                        string login2 = users[i].Substring(loginIndex + 2, loginIndexEnd - loginIndex - 2);

                        // Логин және Пароль бар жоғын тексеру - бар болса қате шығару
                        if (login == login2)
                        {
                            throw new Exception("Бұл логин бос емес");
                            new Result().Register();
                        }
                        
                    }
                }


                string user = $"login: {login}, password: {password}, \r\n";

                //Пайдаланушының деректерін файлға сақтау үшін InsertFile class-сына жолдап береміз
                Result newUser = new Result();
                newUser.InsertFile(user);

                Console.WriteLine("Тіркелу сәтті аяқталды!!!");
                Result registerUser = new Result();
                registerUser.Login();
            }
            catch(Exception e)
            {
                Console.WriteLine("Бірдеме дұрыс емес! Қайта тіркеліп көрініз\n қате: " + e.Message);
                Result registerUser = new Result();
                registerUser.Register();
            }
            // Ойлағанымдай болмады
            //finally
            //{
            //    Console.WriteLine("Тіркелу аяқталды!!!");
            //}


        }







        //Папка құрып және оның ішіне файл құрып ішіне пайдаланушының деректерін еңгізуге дайындап қойдым
        /// <summary>
        /// Тіркелу барысындағы деректерді файлға сақтау
        /// </summary>
        /// <param name="user">Логин және Пароль</param>
        public void InsertFile(string user)
        {
            
            
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory); 
            else if (!File.Exists(file)) File.WriteAllText(file, user, Encoding.UTF8);

            File.AppendAllText(file, user,Encoding.UTF8);


        }








        /// <summary>
        /// Жүйеге кіру
        /// </summary>
        public void Login()
        {
            Console.WriteLine("Бастапқы бетке қайту үшін \"H\" батырмасын басыңыз!!!");
            Console.WriteLine("Кіру");
            Console.Write("Тіркелген логинды жазыңыз:");
            string loginUser = Console.ReadLine();

            Console.Write("Тіркелген парольды жазыңыз:");
            string passwordUser = Console.ReadLine();

            string[] user = File.ReadAllLines(file,Encoding.UTF8);

            // "H" немесе "h" батырмасын басу арқылы бастапқы бетке қайту
            if (loginUser == "h" || passwordUser == "h") Result.MainWindow(); 
            if (loginUser == "H" || passwordUser == "H") Result.MainWindow();


            // Логин,Пароль сақталған файлда барма жоқпа тексеру
            for (int i = 0; i < user.Length; i++)
            {
                // Логин,Пароль сақталған файлдан Логин мен Парольды қыйып алу үшін
                int loginIndex = user[i].IndexOf(":");
                int passwordIndex = user[i].LastIndexOf(":");

                int loginIndexEnd = user[i].IndexOf(",");
                int passwordIndexEnd = user[i].LastIndexOf(",");



                // Логин,Пароль сақталған файлдан Логин мен Парольды қыйып алу
                login = user[i].Substring(loginIndex + 2, loginIndexEnd - loginIndex - 2);
                password = user[i].Substring(passwordIndex + 2, passwordIndexEnd - passwordIndex - 2);

                // Логин және Пароль бар жоғын тексеру - бар болса ілмектен шығару
                if (login == loginUser && password == passwordUser)
                {
                    break;
                }
            }

            // Логин және Пароль бар жоғын тексеру 
            if (login == loginUser && password == passwordUser)
            {
                // Логин және Пароль бар болса
                Console.WriteLine($"Қош келдіңіз {login}!!!");
            }
            else
            {
                Console.WriteLine("Логин немесе Пароль қате");

                // Қайтадан Логин және Пароль сұрау
                Result registerUser = new Result();
                registerUser.Login();
            }

            
            
        }




        /// <summary>
        /// Сақталған файл мен папканы жою
        /// </summary>
        public static void DeleteFile()
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
             if (Directory.Exists(directory))
            {
                Directory.Delete(directory);
            }

        }




    }
}
