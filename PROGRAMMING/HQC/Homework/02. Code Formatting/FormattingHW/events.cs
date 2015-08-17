namespace FormattingHW
{
    using System;
    using System.Text;

    public class Program
    {
        private static StringBuilder output = new StringBuilder();
        private static EventHolder events = new EventHolder();
        
        public static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        private static bool ExecuteNextCommand()
        {
            var command = Console.ReadLine();

            switch (command[0])
            {
                case 'A':
                    AddEvent(command);
                    return true;
                case 'D':
                    DeleteEvents(command);
                    return true;
                case 'L':
                    ListEvents(command);
                    return true;
                case 'E':
                    return false;
            }

            return false;
        }

        private static void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf('|');
            var date = GetDate(command, "ListEvents");
            var countString = command.Substring(pipeIndex + 1);
            var count = int.Parse(countString);

            events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            var title = command.Substring("DeleteEvents".Length + 1);

            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title, location;

            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        private static void GetParameters(string commandForExecution,
            string commandType,
            out DateTime dateAndTime,
            out string eventTitle,
            out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            var firstPipeIndex = commandForExecution.IndexOf('|');
            var lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }

        public static class Messages
        {
            public static void EventAdded()
            {
                output.Append("Event added\n");
            }

            public static void EventDeleted(int x)
            {
                if (x == 0)
                {
                    NoEventsFound();
                }
                else
                {
                    output.AppendFormat("{0} events deleted\n", x);
                }
            }

            public static void NoEventsFound()
            {
                output.Append("No events found\n");
            }

            public static void PrintEvent(Event eventToPrint)
            {
                if (eventToPrint != null)
                {
                    output.Append(eventToPrint + "\n");
                }
            }
        }

        public class EventHolder
        {
            private MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
            private OrderedBag<Event> byDate = new OrderedBag<Event>();

            public void AddEvent(DateTime date,
                string title,
                string location)
            {
                var newEvent = new Event(date, title, location);

                this.byTitle.Add(title.ToLower(), newEvent);
                this.byDate.Add(newEvent);
                FormattingHW.Messages.EventAdded();
            }

            public void DeleteEvents(string titleToDelete)
            {
                var title = titleToDelete.ToLower();
                var removed = 0;

                foreach (var eventToRemove in this.byTitle[title])
                {
                    removed++;
                    this.byDate.Remove(eventToRemove);
                }

                this.byTitle.Remove(title);
                FormattingHW.Messages.EventDeleted(removed);
            }

            public void ListEvents(DateTime date, int count)
            {
                OrderedBag<Event>.View eventsToShow = this.byDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
                var showed = 0;

                foreach (var eventToShow in eventsToShow)
                {
                    if (showed == count)
                    {
                        break;
                    }

                    FormattingHW.Messages.PrintEvent(eventToShow);
                    showed++;
                }

                if (showed == 0)
                {
                    FormattingHW.Messages.NoEventsFound();
                }
            }
        }
    }
}