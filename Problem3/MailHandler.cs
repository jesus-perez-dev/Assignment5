using System;
/*
 * Adonis Mendoza
 * 000789894
 * I, Adonis Mendoza, student number 000789894, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem3
{
    // Mail handler, specific to handling mails
    public class MailHandler: Handler
    {
        public MailHandler()
        {
        }

        public override bool IsFlagged => false;

        public override string Mail => "Mail";

        public override void Handle(Mail mailItem)
        {
            throw new NotImplementedException();
        }
    }
}
