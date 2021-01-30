using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Base_Lessons
{
    /// <summary>
    /// Мәзір - Файлдармен жұмыс
    ///         #1 Файл жол ақпараты（Path Info) - Екіге бөлінеді
    ///             #1.1 Absolute path - мысал: D:/Kurs/Salem.txt (Дискідегі толық жолы)
    ///             #1.2 Relative path - мысал: ../Kurs/Salem.txt (Салыстырмалы жолы)
    ///         #2 Файлдармен жұмыс істеу (Working with files)
    /// </summary>
    class File_info
    {
        // #1 Файл жол ақпараты（Path Info)
        public static void pathInfo()
        {
            /*Файл жол ақпараты екіге бөлінеді Absolute path және Relative path болып бөлінеді
             #1.1 Absolute path - Толық мекен-жайды сақтайды мысалы: D:/Kurs/Salem.txt (Дискідегі толық жолы)
             #1.2 Relative path - Файл жақын тұрған болса іздеп тауып көрсетуге болады мысалы: ../Kurs/Salem.txt (Салыстырмалы жолы)
            
             
                               string filePath = @"D:/Kurs/Salem.txt" 
                                @ - деген кодты оқыма ол мәтін дейді     
                                Kurs - Файлдар қалтасы 
                                Salem - Файл аты
                                .txt - Файл форматы
             
             */

            string path = "C:/Users/KK/Desktop/Kurs/salem.txt";
            /* Файл қалтасын алайық C:/Users/KK/Desktop/Kurs/ осы бөлігін 
             Оны қалай аламыз десек біз ең соңғы кезіккен "/" осы таңбаны тауып алуымыз керек*/

            //int index = path.LastIndexOf("/"); // ең соңғы кезіккен "/" осы таңбанының кілт-саның қайтарады біздін жағдайда 19 қайтарды
            //string dir = path.Substring(0, index+1); //output: C:/Users/KK/Desktop/Kurs/  ---- (index+1) деп кілт-санды 20 қыламыз не үшін десек 19 қалпында C:/Users/KK/Desktop/Kurs осылай болады 

            /* Файл атын алайық salem осы бөлігін 
             Оны қалай аламыз десек біз ең соңғы кезіккен "." нүктені тауып алуымыз керек*/

            //int pointIndex = path.LastIndexOf("."); //ең соңғы кезіккен "." нүктенің кілт-саның қайтарады біздін жағдайда 30 қайтарды
            //string fileName = path.Substring(index + 1, pointIndex-index-1); // Кілт-сан бойынша 20 мен 30 арасындағы мәнді қайтарады біздін жағдайда "salem" қайтарады

            // Файл форматын қалай аламыз десек біз алған нүкте кілт-саннаң бастап жолдын соңына дейін десек болғаны

            //string fileFormat = path.Substring(pointIndex, path.Length - pointIndex);




            // Біз әр жолы осылай жазып жүрсек онда әйрешілік болады C# тілі бізге дайындап қойған әдісі бар соны пайдалансақ болағаны System.IO пакетінде орналасқан

            // Әдісті қолдану - Әдістер Path() class-сында орналасқан
            string dir = Path.GetDirectoryName(path); // C:/Users/KK/Desktop/Kurs/
            string fileName = Path.GetFileNameWithoutExtension(path);// salem
            string fileFormat = Path.GetExtension(path);// .txt

            // Path() class-сындағы басқада көптеген әдістерді қолдана білуіміз керек оның ішінде
            string fileFullName = Path.GetFileName(path);// salem.txt
            string relativePath = Path.GetRelativePath("C:/Users/KK/Desktop/Sinaq/", path); // ..\Kurs\salem.txt

            Console.WriteLine($" dir = {dir} \n fileName = {fileName} \n fileFullName = {fileFullName} \n fileFormat = {fileFormat} \n relativePath {relativePath}");
        }



        //#2 Файлдармен жұмыс істеу (Working with files)
        public static void workingWithFiles()
        {
            /* Егер осылай жұмыс үстеліне жол жазсақ онда басқа адамдардын компьютеріне файл құратын бағдарлама жазсақ 
            онда таппай қалуы мүмкін себеп жұмыс үстелінің жолы басқа болуы мүмкін */

            //string desctopPath = @"C:\Users\Default\Desktop";


            //Еңді қалай істейміз десек C# оғанда әдіс жазып қойған соны пайдалансақ болғаны
            /*
             * .Combine()- Жолдарды біріктіреді "/" таңбасы болмаса қойып кетеді 
             */

            //Мысал 1

            //string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string desktopDirectory = "E:/";
            string file1 = Path.Combine(desktopDirectory, "1.txt");

            // Біз құратын файл барма жоқпа тексереміз жоқ болса жаңадан құрамыз бар болса ашып ішіне жазамыз
            if (File.Exists(file1))
            {

                // Файлдағы барлық жазбаны оқу
                //string allText = File.ReadAllText(file1, Encoding.UTF8);
                //Console.WriteLine(allText);

                //Бар болса ішін ашып жаңа мәтін қосамыз
                /*Файл оқығанда Encoding қаңдай екенің білмесек әдепкі десек болды мысал: Encoding.Default
                 UTF8 екенің білсек Encoding.UTF8 деп жазып кеткен дұрыс болады*/

                //File.AppendAllText(file1, "\nМен қосылдым", Encoding.UTF8);
            }
            else
            {
                //Жоқ болса жаңа файл құрамыз және "Сәлем!!!" мәтінің жазып береміз

                //File.WriteAllText(file1, "Сәлем!!!", Encoding.UTF8);
            }



            //Мысал 2

            if (!File.Exists(file1)) 
            {
                Console.WriteLine("Бұл файл жоқ!!!");
                return;
            }

            //Файлды 1жолдан оқу яғни бір жолдан бір-бірлеп оқу

            string[] allLines = File.ReadAllLines(file1, Encoding.UTF8);
            foreach(string line in allLines)
            {
                //Console.WriteLine(line);
            }


            ////Мысал 3 - Жол-жолдан сақтау бір-бірлеп сақтау

            
            StreamWriter streamWriter = File.CreateText(file1);

            for(int i = 1; i <= 10; i++)
            {
                streamWriter.WriteLine(i.ToString());
            }


                //StreamWriter қосқаннаң кейін жабу керек осылай
                streamWriter.Close();



            // Басқада әдістер
            //File.Copy(file1, file2);// бір файлдан екінші файлға көшіру
            //File.Move(file1, "2.txt"); // Қыйып алып біржерден екінші жерге ауыстыру және ауыстыру барысында атын өзгертуге болады
            File.Delete(file1); // Жою


            

        }

    }
}
