using System;
using System.Text;

namespace Base_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            // Қазақ әріптерін дұрыс шығару үшін қажет
            Console.OutputEncoding = Encoding.UTF8;



            // Деректерді түрлендіру - Data conversion ------------------------------------------------------------------------------------

            //#1.1 Жасырын түрлендіру(автоматты түрде) - Implicit Casting (automatically)
            //Turlendriu.ImplicitCasting();

            //#1.2 Ашық түрлендіру(қолмен) - Explicit Casting (manually)
            //Turlendriu.ExplicitCasting();





            //#2 Түрлендіру әдістері - Type Conversion Methods


            //#2.1 Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
            // AND
            //#2.2 int.Parse(), bool.Parse(), double.Parse() т.б сандық түрдегілер
            //Turlendriu.TypeConversionMethods();


            //#3 Қорапқа салу мен Қораптан шығару --- Қорап деген object
            //Turlendriu.DataTypeObject();


            // Деректерді түрлендіру соңы - Data conversion end. ------------------------------------------------------------------------------------






            //#1 Try / Catch / Finally - Түсініктеме - Сабағы ------------------------------------------------------------------------------------
            //Try_Catch_Finally.TryCatchFinally();
            //#1 Try / Catch / Finally - Түсініктеме - Сабағы соңы. ------------------------------------------------------------------------------------






            //Тізбектер (arrays) ------------------------------------------------------------------------------------

            //#1 Бір өлшемді Тізбектер (Single-Dimensional Arrays)
            //Arrays.SingleDimensional_Arrays();


            //#2 Көп өлшемді Тізбектер(Multidimensional Arrays)
            //Arrays.Multidimensional_Arrays();

            //#3 Аралық тізбектер(Jagged arrays)
            //Arrays.Jagged_Arrays();

            //#4 foreach ілмегін пайдаланып тізбектердін мәнің оңай шығару
            //Arrays.Foreach_Array();

            //#5 Array - өзіндік әдістері бар Array class-сын пайдалану
            Arrays.SystemMethods_Array();

            //Тізбектер (arrays) соңы. --------------------------------------------------------------------------------

        }
    }
}
