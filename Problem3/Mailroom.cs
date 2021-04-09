using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Adonis Mendoza
 * 000789894
 * I, Adonis Mendoza, student number 000789894, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem3
{
    /// <summary>
    /// Represents a reactor pattern.
    /// </summary>
    public class Mailroom
    {
        // Used to create one instance
        private static Mailroom mainMailRoom;

        // holds a list of handlers we want to use to "handle" incoming requests/information
        private List<Handler> handlers = new List<Handler>();


        // List of mail (requests)
        private static List<Mail> mail = new List<Mail>();

        // Non-flagged Mail goes to the main queue
        private static Queue<Mail> mainQueue = new Queue<Mail>();


        // Flagged Mail goes to review Queue
        private static Queue<Mail> reviewQueue = new Queue<Mail>();

 
        private Mailroom(List<Mail> mails)
        {
            // use reflection to load all the handlers in the assembly
            // then use the select method to invoke the constructor on each handler
            // return the invoked handlers to the add range method
            // and add all the handler to the list
            this.handlers.AddRange(typeof(Mailroom).Assembly.DefinedTypes.Where(c => c == typeof(Handler)
                                                                    && c.IsAbstract
                                                                    && c.IsClass)
                                          .Select(t => (Handler)Activator.CreateInstance(t)));


        }


        // Only create one Mailroom instance
        public static Mailroom MainMailRoom => mainMailRoom ?? (mainMailRoom = new Mailroom(mail));


        public void Handle(Mail mailItem)
        {

            var handler = this.handlers.FirstOrDefault(m => m.);
        }
    }
}
