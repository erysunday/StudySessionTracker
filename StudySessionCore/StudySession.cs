using System;
using System.Collections.Generic;
using System.Text;

namespace StudySessionCore
{
    public class StudySession
    {
        public string Subject { get; set; }
        public int DurationMinutes { get; set; }
        public int FocusRating { get; set; }

        public StudySession(string subject, int durationMinutes, int focusRating)
        {
            Subject = subject;
            DurationMinutes = durationMinutes;
            FocusRating = focusRating;
        }
    }
}
