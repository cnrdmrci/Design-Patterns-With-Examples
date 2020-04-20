using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class UsageOfFactoryMethod
    {
        public static void Run()
        {
            Message message = MessageSender
                .InitializeFactories(MessageSendType.Sms)
                .CreateProduct("0553-00","Bu bir test mesajıdır.");

            message.GetMessageInfo();

            message.Send();
        }
    }
}
