using System;

namespace Restaurant
{
    public class BaseClass {

        public BaseClass() {
            Id = Guid.NewGuid().ToString();
            Created = DateTime.UtcNow;
        }

        public String Id { get; private set;}
        public DateTime Created { get; private set;}

        // We only want to work with universal time objects so that we do not have to worry about our
        // data being stored in different time zones.  This is for practicality, and what most software
        // systems do when storing time. Timezones should _only_ be used for display.
        private DateTime updated;
        public DateTime Updated {
            get { return updated; }
            set {
                updated = value.ToUniversalTime();
            }
        }
    }
}