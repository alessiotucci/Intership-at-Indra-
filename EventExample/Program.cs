using System;

namespace EventExample
{
    public class Program
    {
        // Define a delegate that represents the event.
        public delegate void MyEventHandler(object source, EventArgs args);

        // Define the event to be called when the designated action occurs.
        public static event MyEventHandler MyEvent;

        static void Main(string[] args)
        {
            // Attach an event handler.
            MyEvent += RespondToEvent;

            // Invoke the event.
            OnMyEvent();
        }

        protected static void OnMyEvent()
        {
            MyEvent?.Invoke(null, EventArgs.Empty);
        }

        private static void RespondToEvent(object source, EventArgs e)
        {
            Console.WriteLine("Event occurred!");
        }
    }
}
