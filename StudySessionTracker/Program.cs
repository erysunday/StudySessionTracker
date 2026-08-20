using StudySessionCore;
using StudyStatistics;

namespace StudySessionTracker
{
    public class Program
    {
        static List<StudySession> sessions = new List<StudySession>();
        public static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("\nSTUDY SESSION TRACKER");
                Console.WriteLine("1. Add study session");
                Console.WriteLine("2. View study sessions");
                Console.WriteLine("3. View statistics");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSession();
                        break;
                    case "2":
                        ViewSessions();
                        break;
                    case "3":
                        Statistics.ViewStats(sessions);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        public static void AddSession()
        {
            Console.WriteLine("\nADD STUDY SESSION");
            Console.Write("Subject: ");
            string subject = Console.ReadLine()!;

            Console.Write("Duration in minutes: ");
            string? input = Console.ReadLine();
            int duration;
            while (!int.TryParse(input, out duration) || duration <= 0)
            {
                Console.Write("Enter a valid duration: ");
                input = Console.ReadLine();
            }

            Console.Write("Focus rating (1-5): ");
            string? input1 = Console.ReadLine();
            int focusRating;
            while (!int.TryParse(input1, out focusRating) || focusRating < 1 || focusRating > 5)
            {
                Console.Write("Enter a rating from 1 to 5: ");
                input1 = Console.ReadLine();
            }

            StudySession session = new StudySession(subject, duration, focusRating);

            sessions.Add(session);
            Console.WriteLine("Study session added.");
        }

        public static void ViewSessions()
        {
            Console.WriteLine("\nSTUDY SESSIONS");

            if (sessions.Count == 0)
            {
                Console.WriteLine("No study sessions recorded.");
                return;
            }

            for (int i = 0; i < sessions.Count; i++)
            {
                StudySession session = sessions[i];

                Console.WriteLine(
                    $"{i + 1}. {session.Subject} - {session.DurationMinutes} minutes - Focus: {session.FocusRating}/5");
            }
        }
    }
}
