using System;

namespace Restaurant
{
    public class BaseClass {

        public BaseClass() {
            Id = Guid.NewGuid().ToString();
            Created = DateTime.UtcNow;
        }

        public string Id { get; private set; }
        public DateTime Created { get; private set; }
        public string Identity { get {
                return $"{this.GetType().Namespace}.{this.GetType().Name} -- ({Id}) (Created: {Created:yyyy-MM-dd HH:mm:ss-fffffff}) (Updated:{Updated:yyyy-MM-dd HH:mm:ss-fffffff})";
         } private set {} }

        // We only want to work with universal time objects so that we do not have to worry about our
        // data being stored in different time zones.  This is for practicality, and what most software
        // systems do when storing time. Timezones should _only_ be used for display.
        private DateTime updated;
        public DateTime Updated {
            get { return updated.ToUniversalTime(); }
            set {}
        }

        public void UpdateMade() {
            updated = DateTime.UtcNow;
        }
    }
}