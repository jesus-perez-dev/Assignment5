using NUnit.Framework;
using Problem3;
/*
 * Adonis Mendoza
 * 000789894
 * I, Adonis Mendoza, student number 000789894, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace TestProblem3
{
    public class Tests
    {

        Sender sender;
        Receiver receiver;
        Mail mail;
        Mailroom mailroom;


        [SetUp]
        public void Setup()
        {
            sender = new Sender("Test", "Hamilton");
            receiver = new Receiver("Test2", "Toronto");
            mail = new Mail(sender, receiver, 24.0, 10);

           
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}