namespace FirstWebApi.Logger
{
    public class MyLogger:IMyLogger

    {
        public void Log (string errormessage)

            Console.WriteLine(errormessage);
    }
}
