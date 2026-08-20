using StudySessionCore;

namespace StudyStatistics
{
    public class Statistics
    {
        public static void ViewStats(List<StudySession> sessions)
        {
            Console.WriteLine("\nSTATISTICS");

            if (sessions.Count == 0)
            {
                Console.WriteLine("No study sessions recorded.");
                return;
            }

            int totalMinutes = 0;
            int totalFocus = 0;
            int longestSession = 0;

            foreach (StudySession session in sessions)
            {
                totalMinutes += session.DurationMinutes;
                totalFocus += session.FocusRating;

                if (session.DurationMinutes > longestSession)
                {
                    longestSession = session.DurationMinutes;
                }
            }

            double avgDuration = (double)totalMinutes / sessions.Count;
            double avgFocus = (double)totalFocus / sessions.Count;

            Console.WriteLine($"Number of sessions: {sessions.Count}");
            Console.WriteLine($"Total study time: {totalMinutes} minutes");
            Console.WriteLine($"Average session: {avgDuration:F1} minutes");
            Console.WriteLine($"Longest session: {longestSession} minutes");
            Console.WriteLine($"Average focus rating: {avgFocus:f1}/5");
        }
    }
}
