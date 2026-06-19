
namespace DeligateWithDesignPattern
{
    internal class MyHandler
    {
        private Action sMSServices;

        public MyHandler(Action sMSServices)
        {
            this.sMSServices = sMSServices;
        }
    }
}