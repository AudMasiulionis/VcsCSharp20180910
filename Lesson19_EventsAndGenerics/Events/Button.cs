using System;

namespace Lesson19_EventsAndGenerics.Events
{
    public class Button
    {
        public EventHandler<BtnClickArgs> OnButtonClick;

        public void Click(object sender, BtnClickArgs e)
        {
            Console.WriteLine("Button click");
            Console.WriteLine(e.Location);
            if (OnButtonClick != null)
            {
                OnButtonClick.Invoke(sender, e);
            }
        }
    }
}












