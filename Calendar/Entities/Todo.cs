using System;
using Calendar.Abstract;
using Calendar.Common;

namespace Entities
{
    internal class Todo : Event , INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}

