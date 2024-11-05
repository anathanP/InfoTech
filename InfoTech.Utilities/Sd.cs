namespace InfoTech.Utilities
{
    public static class Sd
    {
        public enum Status
        {
            Inactive,
            Active
        }

        public enum PageStatus
        {
            
        }

        public enum ProjectStatus
        {
            
        }

        public enum Theme
        {
            Light,
            Dark
        }

        public enum DayOfWeek
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public enum IndexSections
        {
            About,
            Achivement,
            Brand,
            HeroBanner,
            Marque,
            News,
            Project,
            Service,
            Team,
            Testimonial,
            WorkProcess
        }

        public static string DayOfWeekTranslate(DayOfWeek? dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Friday => "جمعه",
                DayOfWeek.Sunday => "یک شنبه",
                DayOfWeek.Monday => "دوشنبه",
                DayOfWeek.Tuesday => "سه شنبه",
                DayOfWeek.Wednesday => "چهارشنبه",
                DayOfWeek.Thursday => "پنج شنبه",
                DayOfWeek.Saturday => "شنبه",
                _ => throw new Exception(message: "ورودی غیر قابل قبول")
            };
        }

    }
}
