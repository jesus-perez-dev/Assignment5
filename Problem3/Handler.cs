using System;
/*
 * Adonis Mendoza
 * 000789894
 * I, Adonis Mendoza, student number 000789894, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem3
{
    // represents the abstract handler, must be implemented by all handlers
    public abstract class Handler
    {
        protected Handler()
        {

        }

        // we defined our resource as abstract
        // so that all derived handler will define the resource they handle
        // In this case our resource will always be of type Mail
        public abstract string Mail { get; }

        // Specifies whether or not the mail is flagged
        public abstract bool IsFlagged { get; }


        // define an abstract handle method
        // to be implemented by all derived handlers
        // the parameter, is the resource to handle	
        public abstract void Handle(Mail mailItem);

      
    }
}
