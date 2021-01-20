using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Lessons
{
    class Turlendriu
    {


        /* Мәзір - Деректерді түрлендіру - Data conversion
                #1 (Жүйелік) Түрді түрлендіру - (System) Type Casting
                    #1.1 Жасырын түрлендіру(автоматты түрде) - Implicit Casting (automatically)
                    #1.2 Ашық түрлендіру(қолмен) - Explicit Casting (manually)
                #2 Түрлендіру әдістері - Type Conversion Methods
                    #2.1 Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
                    #2.2 int.Parse(); осы әдіс тек String-ты ғана қабылдайды
                #3 Қорапқа салу мен Қораптан шығару --- Қорап деген object дерек түрі
                    #3.1 Қорапқа салу
                    #3.2 Қораптан шығару
                #4 "var" мен "?" белгісінің қолданылуы
                    #4.1 "var" қолданылуы
                    #4.2 "?" қолданылуы
                #5 "is" пен "as" тұралы қысқаша түсінік
            */
















        //#1 (Жүйелік) Түрді түрлендіру - (System) Type Casting

        /* Type casting - бұл бір дерек түрінің мәнін екінші дерек түріне тағайындау.

            C# тілінде түрлендіру(casting)-дің екі түрі бар:

            1) Implicit Casting (automatically) - converting a smaller type to a larger type size
                    char -> int -> long -> float -> double
            1) Жасырын түрлендіру(автоматты түрде) - кіші түрді үлкен өлшемге түрлендіру
                

            2) Explicit Casting (manually) - converting a larger type to a smaller size type
                    double -> float -> long -> int -> char
            2) Ашық түрлендіру(қолмен) - үлкен түрді кіші өлшем түріне түрлендіру
                

         */







        //#1.1 Жасырын түрлендіру(автоматты түрде) - Implicit Casting (automatically)
        public static void ImplicitCasting()
        {
            //Мөршері ==> Аумағы
            // int мәнің long мәніне бергенде қате шықпайды себебі жасырын түрлендіреді int мәнің long мәніне жасырын түрлендіреді
            // Неге десек int сақтау мөршері long-тан кіші, асып кету қауыпы жоқ
            // Жасырын түрлендіру қай кезде орындалады?
            // Қабылдап алатын түрден мөршері кіші болғанда - Мөршері ==> Аумағы
            //char -> int -> long -> float -> double



            Console.WriteLine("#1.1 Жасырын түрлендіру(автоматты түрде) - Implicit Casting (automatically)");
            Console.WriteLine();

            //Мысал 1 int -> long
            int intNumber = 18;
            //Жасырын құю кіші өлшем түрін үлкен өлшем түріне өткізген кезде автоматты түрде жасалады:
            long longNumber = intNumber; // Жасырын автоматты түрлендірді intNumber-дын түрі енді long болды
            Console.WriteLine("Мысал 1");
            Console.WriteLine("int Number = " + intNumber); // 18
            Console.WriteLine("int -> long : long Number= " + longNumber); // 18
            Console.WriteLine();

            //Мысал 2 char -> int
            char charNumber = '4';
            //Жасырын құю кіші өлшем түрін үлкен өлшем түріне өткізген кезде автоматты түрде жасалады:
            int intNumber2 = charNumber; // Жасырын автоматты түрлендірді char-дын түрі енді int болды
            Console.WriteLine("Мысал 2");
            Console.WriteLine("char Number = " + charNumber); // 4
            Console.WriteLine("char -> int : int Number2 = " + intNumber2); // 52 - Неге 52 шықты десек ол 4-тің Unicode ASCII Мәнің қайтарды
            Console.WriteLine();
        }










        //#1.2 Ашық түрлендіру(қолмен) - Explicit Casting (manually)
        public static void ExplicitCasting()
        {
            /*
             *  2) Explicit Casting(manually) -converting a larger type to a smaller size type
                    double -> float -> long -> int -> char
                2) Ашық түрлендіру(қолмен) -үлкен түрді кіші өлшем түріне түрлендіру
            */

            Console.WriteLine("#1.2 Ашық түрлендіру(қолмен) - Explicit Casting (manually)");
            Console.WriteLine();

            //Мысал 1 - double -> float
            double doubleNumber = 100.98;
            // Ашық түрлендіру түрін жақшаның ішіне мәннің алдына қою арқылы қолмен жасалуы керек: (float)doubleNumber
            float floatNumber = (float)doubleNumber; // Қолымен double мәнің float түріне өзгерттік

            Console.WriteLine("Мысал 1 - double -> float");
            Console.WriteLine("double Number = " + doubleNumber); // 100.98
            Console.WriteLine("double -> float : float Number = " + floatNumber); // 100.98

            Console.WriteLine();

            //Мысал 2 - double -> int
            double doubleNumber2 = 100.98;
            // Ашық түрлендіру түрін жақшаның ішіне мәннің алдына қою арқылы қолмен жасалуы керек: (int)doubleNumber2
            float intNumber = (int)doubleNumber2; // Қолымен double мәнің int түріне өзгерттік

            Console.WriteLine("Мысал 2 - double -> int");
            Console.WriteLine("double Number2 = " + doubleNumber2); // 100.98
            Console.WriteLine("double -> int : int Number = " + intNumber); // 100


            /* Мысал 3
             Егер біз екі int-тын сақтау мөршерінің шегін бір-біріне қоссақ не болады?
            .....не болады????.....
            .....не болады????.....
            .....не болады????.....

            Әрине қате болады!!! неге деудін өзі ұят :)
             */

            // Осы екі айнымалы Мысал 3 тен Мысал 6 ға дейін қолданылған
            int number1 = int.MaxValue; // 2147483647
            int number2 = int.MaxValue; // 2147483647

            // Мысал 3
            int intNumber3 = number1 + number2; // 2147483647 + 2147483647 = -2 Қате шықты
            /*
             -2 Қате шығып тұр неге десек себебі қарапайм number мен number2 мәндері сақтау мөршерінің шегі болып тұр
            енді екеуін қосатын болсақ сақтау мөршеріннең асып кетеді сондықтан қате шығады */

            Console.WriteLine();
            Console.WriteLine("Мысал 3 - intNumber3 = number1 + number2");
            Console.WriteLine("number1 = " + number1); // 2147483647
            Console.WriteLine("number2 = " + number2); // 2147483647
            Console.WriteLine("intNumber3 = " + intNumber3); // -2


            // Мысал 4 - Енді long арқылы қабылдайтын болсақ
            long longNumber = number1 + number2; // 2147483647 + 2147483647 = -2

            Console.WriteLine();
            Console.WriteLine("Мысал 4 - Енді long арқылы қабылдайтын болсақ - longNumber = number1 + number2");
            Console.WriteLine("number1 = " + number1); // 2147483647
            Console.WriteLine("number2 = " + number2); // 2147483647
            Console.WriteLine("longNumber = " + longNumber); // -2 Қате шықты
            /*
              Тағыда қате шығады 
                .....Неге???? long-тын сақтау мөршері кеңғой асып кетпейді.....
                .....Неге???? long-тын сақтау мөршері кеңғой асып кетпейді.....
                .....Неге???? long-тын сақтау мөршері кеңғой асып кетпейді.....

            Егер екі int мәнің қоссақ онда нәтижесіде int мәні болады.

            */


            // Мысал 5 - Енді ол мәселені шешу үшін түрлендіру қажет болады
            long longNumber5 = (long)number1 + (long)number2; // 2147483647 + 2147483647 = 4294967294
            Console.WriteLine();
            Console.WriteLine("Мысал 5 - Енді ол мәселені шешу үшін түрлендіру қажет болады - longNumber5 = (long)number1 + (long)number2;");
            Console.WriteLine("number1 = " + number1); // 2147483647
            Console.WriteLine("number2 = " + number2); // 2147483647
            Console.WriteLine("longNumber5 = " + longNumber5); // 4294967294 Дұрыс шықты

            /* Енді дұрыс шықты Ура :)
             Айта кететің бір жағдай егер long пен int қосылса онда нәтижесі long болып шығады 
                    long + int => long
                    int + long => long
            */

            // Мысал 6 - Айта кететің бір жағдай егер long пен int қосылса онда нәтижесі long болып шығады long + int => long, int + long => long
            long longNumber6 = (long)number1 + number2; // 2147483647 + 2147483647 = 4294967294
            Console.WriteLine();
            Console.WriteLine("Мысал 6 - longNumber6 = (long)number1 + number2;");
            Console.WriteLine("number1 = " + number1); // 2147483647
            Console.WriteLine("number2 = " + number2); // 2147483647
            Console.WriteLine("longNumber6 = " + longNumber6); // 4294967294 Дұрыс шықты

        }








        //#2 Түрлендіру әдістері - Type Conversion Methods


        /* #2.1 Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
         * 
         * Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
         * Осы Сияқты кірістірілген әдістерді қолдану арқылы деректер түрлерін түрлендіруге болады
         * 
         * 
         * #2.2 int.Parse(); осы әдіс тек String-ты ғана қабылдайды
         * int.Parse(), bool.Parse(), double.Parse() т.б сандық түрдегілер
         * Осы Сияқты кірістірілген әдістерді қолдану арқылы Сырттан келетін String түріндегі сандарды түрлендіруге болады
         * Бұл тек String түріндегі сандар мәнің ғана қабылдайды
         */

        public static void TypeConversionMethods()
        {

            /* #2.1 Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
             * 
             * 
             * Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
             * Сияқты кірістірілген әдістерді қолдану арқылы деректер түрлерін түрлендіруге болады
             */

            Console.WriteLine();
            Console.WriteLine("#2 Түрлендіру әдістері - Type Conversion Methods");

            //Мысал 1 - кірістірілген әдістерді қолдану арқылы деректер түрлерін түрлендіру
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine();
            Console.WriteLine("Мысал 1 - кірістірілген әдістерді қолдану арқылы деректер түрлерін түрлендіру");
            Console.WriteLine("myInt => string = " + Convert.ToString(myInt));    // convert int to string
            Console.WriteLine("myInt => double = " + Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine("myDouble => int = " + Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine("myBool => string = " + Convert.ToString(myBool));   // convert bool to string

            /*Неліктен айырбастау керек?
            Көптеген жағдайда түрлендірудің қажеті жоқ. Бірақ кейде сізге тура келеді. Бұған мысал келтіру үшін келесі тарауға, 
            пайдаланушы енгізулерімен жұмыс жасаңыз. Мысал 7 -де*/


            //#1.2 Ашық түрлендіру(қолмен) - Әдісінде біз осындай Мысал қарастырған едік 

            // Осы екі айнымалы Мысал 3 тен Мысал 6 ға дейін қолданылған
            int intNumber1 = int.MaxValue; // 2147483647
            int intNumber2 = int.MaxValue; // 2147483647

            // Мысал 2 - #1.2 Ашық түрлендіру(қолмен) - Әдісінде біз осындай Мысал қарастырған едік - longNumber = (long)intNumber1 + intNumber2;
            long longNumber = (long)intNumber1 + intNumber2; // 2147483647 + 2147483647 = 4294967294
            Console.WriteLine();
            Console.WriteLine("Мысал 2 - #1.2 Ашық түрлендіру(қолмен) - Әдісінде біз осындай Мысал қарастырған едік");
            Console.WriteLine("Мысал 2 - longNumber = (long)intNumber1 + intNumber2;");
            Console.WriteLine("number1 = " + intNumber1); // 2147483647
            Console.WriteLine("number2 = " + intNumber2); // 2147483647
            Console.WriteLine("longNumber = " + longNumber); // 4294967294 Дұрыс шықты


            // Мысал 3 - Енді String араластырып көрейік

            //string stringNumber = intNumber1 + intNumber2 + longNumber;  // Мыналардын бәрінең шығатын мән null
            // Басталмай жатып қате шықты себебі бұл жерде біреуі string болуы қажет 


            // Реттеу үшін біреуін ашық түрде ToString() әдісін пайдаланып String-қа айналдырып жіберсек болды
            // Мысал 4
            String stringNumber4 = intNumber1.ToString() + intNumber2 + longNumber;
            Console.WriteLine();
            Console.WriteLine("Мысал 4 - Реттеу үшін біреуін ашық түрде ToString() әдісін пайдаланып String-қа айналдырып жіберсек болды");
            Console.WriteLine("Мысал 4 - intNumber1.ToString() + intNumber2 + longNumber;");
            Console.WriteLine("stringNumber4 = " + stringNumber4); // 214748364721474836474294967294 - Неге бұлай шықты?
            /* Неге нәтижесі бұлай шығады 214748364721474836474294967294 => 2147483647 2147483647 4294967294
             Себебі бәрі String болып кетті 
            String араласқан жерде бәрі String болып кетеді 
            Алды String болса артындағы бәрі String болып кетеді
            */


            // Мысал 5 - ал артында болса олай болмайды
            String stringNumber5 = intNumber1 + intNumber2 + longNumber.ToString();
            Console.WriteLine();
            Console.WriteLine("Мысал 5 - ал артында болса олай болмайды");
            Console.WriteLine("Мысал 5 - intNumber1 + intNumber2 + longNumber.ToString();");
            Console.WriteLine("stringNumber5 = " + stringNumber5); //-24294967294 - Неге бұлай шықты?

            /* Неге нәтижесі бұлай шығады -24294967294 => -2 4294967294
             неге -2 шықты себебін айттып кеткенбіз екі int қосылғанда мөршеріннең асып кетсе солай болады деп
            
             
             
             оны реттейік:
            */

            // Мысал 6 - оны реттейік:
            String stringNumber6 = (long)intNumber1 + intNumber2 + longNumber.ToString();
            Console.WriteLine();
            Console.WriteLine("Мысал 6 - оны реттейік:");
            Console.WriteLine("Мысал 6 - (long)intNumber1 + intNumber2 + longNumber.ToString();");
            Console.WriteLine(stringNumber6); //42949672944294967294 - Дұрыс шықты 
            // Енді дұрыс шықты 4294967294 4294967294
            // алдындағы екі сан түріндегі сандарды бір-біріне қосты ал артындағы мәтін түріндегі санды жабыстырып қойды
            // Ал алдында String болса артындағы бәрі String болып кетеді себебі жасырын түрлендіру болып отыр



            /*Неліктен айырбастау керек?
            Көптеген жағдайда түрлендірудің қажеті жоқ. Бірақ кейде сізге тура келеді. Бұған мысал келтіру үшін келесі тарауға, 
            пайдаланушы енгізулерімен жұмыс жасаңыз. Мысал 7 -де*/


            //Мысал 7 - Осындай жағдайлар көп кезігеді

            /*
             Жасын алу үшін Console.ReadLine(); әдісін пайдаланамыз
            Алайда
              Сырттан келген мәнді тек String түрімен ғана қабылдап алуға болады
             */

            Console.WriteLine("Жасы: ");
            //Мысал 7
            string ageStr = Console.ReadLine();

            // Сырттан келген жасқа 1 жас қосып бергім келеді

            //int age = ageStr + 1; // Алайда қате шықты

            /*
            Енді
              Сырттан келген мәнді қалай түрлендіреміз?

                int age = (int)ageStr + 1; //осы әдіс жарамайды 

                (int) бұл әдіс тек саңдық түрдегілерге ғана жарамыды

            Енді басқа қаңдай түрлендіру әдісі бар?
            */

            //#2.2 int.Parse(); осы әдіс тек String-ты ғана қабылдайды

            /*
             *  int.Parse(); деген әдіс бар
                int.Parse(); осы әдіс тек String-ты ғана қабылдайды
                Тағы басқа осындай саңдық түрдегілердін бәрінде бар
                long.Parse(); т.б.....
            */

            //Мысал 8 - int.Parse(); деген әдіс бар
            int intAge = int.Parse(ageStr) + 1; // Енді дұрыс болды
            Console.WriteLine();
            Console.WriteLine("Мысал 8 - int.Parse(); деген әдіс бар");
            Console.WriteLine(intAge);



        }








        //#3 Қорапқа салу мен Қораптан шығару --- Қорап деген object


        public static void DataTypeObject()
        {

            //Қорапқа салу мен Қораптан шығару деген осындай болады


            //#3.1 Қорапқа салу 


            //object Бәрлық түрдегі мәндерді қабылдай береді
            Console.WriteLine();
            Console.WriteLine("#3 Қорапқа салу мен Қораптан шығару --- Қорап деген object");
            Console.WriteLine();
            Console.WriteLine("#3.1 Қорапқа салу");
            Console.WriteLine("Мысал 1");
            //Мысал 1
            int intAge = 100;
            object obj1 = intAge;
            string strName = "Еламан";
            object obj2 = strName;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            //#3.2 Қораптан шығару

            /* Енді Object түріндегін түрлендіру қалай болады?
             Convert class-сындағы әдістерді пайдалану қажет
            Convert class-дағы әдістердін бірі .ToInt32() әдісі -ол int-ке түрлендіреді
            Convert class-да тағы басқа көптеген әдістері бар
             */

            Console.WriteLine();
            Console.WriteLine("#3.2 Қораптан шығару");
            Console.WriteLine("Мысал 1 - object-ты int-қа түрлендіру");

            object obj = 60;
            //Мысал 1 - int-қа түрлендіру
            int number = Convert.ToInt32(obj); // .ToInt32 - 32 деген int
            Console.WriteLine(number);


            //Мысал 2 - long-қа түрлендіру
            long numberLong = Convert.ToInt64(obj); // 64 деген long - Қораптан шығару
            Console.WriteLine("Мысал 2 - object-ты long-қа түрлендіру");
            Console.WriteLine(numberLong);


            //Мысал 3 - float-ты түрлендіру
            float numberFloat = Convert.ToSingle(obj); // .ToFloat() деген жоқ оның орнына .ToSingle()
            Console.WriteLine("Мысал 3 - object-ты float-қа түрлендіру");
            Console.WriteLine(numberFloat);

            //Қорапқа салу мен Қораптан шығару деген осындай болады
        }








        //#4 "var" мен "?" белгісінің қолданылуы

        public static void VarAnd_()
        {


            //#4.1 "var" қолданылуы

            /* var дегеніміз автоматты дерек түрін аңықтап береді
             Егер сіз var-ға мәтің жазсаңыз онда ол дерек түрін string жасап береді
            

            ол Build жасағанда яғни компьютер түсінетін тілге айналдырғанда var жойылып орнына string болады болмаса басқасы оны аңықтап өзі істейді

            var не үшін қажет?

            Біз кей уақытта int мөршерін білмей асырып жіберсек, болмаса int болатын түрді long жасап қоюмыз мүмкін, соңдай жағдайларда қолданылады

            Мысал1
             */

            var strName = "Elaman"; // Түрі автоматты string болып өзгерді ол тек компьютер түсінетін тілге құйғанда ғана var-дын орнына string болады
            var intAge = 18; // Түрі автоматты int болып өзгерді ол тек компьютер түсінетін тілге құйғанда ғана var-дын орнына int болады





            //#4.2 "?" қолданылуы

            /* Деректер базасыннаң ақпараттарды оқығанда(алғанда) кейде null болады
             
             Ал айнымалының мәні null болса қате шығады
            
             сол қатені алдын алу үшін "?" белгісі көмектеседі
            
             егер адамның Ер - Әйел екенің аңықтағымыз келсе Ер => 1 Әйел => 0 деп алсақ 

             Мысал 1*/
            // Егер 1 Ер болса

            int gender1 = 1;

            // Егер 0 Әйел болса

            int gender0 = 0;

            /* Егер Ер де емес Әйелде емес null болса  онда бізге сол null-ды айнамалыға жазып беру қажет болады 
             ал айнымалы мәні null болса қате шығарады

            енді сол мәселені шешу үшін жай ғана "?" белгісін қою керек сонда айнымалы null-ды қабылдайды
            null деген жоқ деген 

            "?" Белгісі тек null-ды айнымалы қабылдау үшін ғана қолданылады басқа мәні жоқ
            Мысал 2
             */
            byte? gender = null;
            int? number = null;


        }




        //#5 "is" пен "as" тұралы қысқаша түсінік
        public static void IsAndAs()
        {
            //Object түрленбейтін кездері болады
            //Object - деген Нысан 
            /* C# оғанда амыл тауып қойған
             
             Object-ты түрлендіру үшін as қолданылады әйтседе as тек шартпен ғана істейді 
            шартқа is деп талдау арқылы ғана Object-ты түрлендіруге болады 
            яғни Object-тен керек, дерек түрін таңдап қаңа сондай дерек түріне беруге болады 
            Object-тен сізге мәтінді таңдап алу керек болса шартқа if (objName is string) осылай талдау жасау керек
            ал сан керек болса if (objName is int) осылай талдау жасау керек
             */



            object objName3 = new DateTime(); // 1/1/0001 12:00:00 AM


            if (objName3 is string)
            {
                string strName3 = objName3 as string;
            }
        }


    }
}
