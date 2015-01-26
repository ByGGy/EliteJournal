using EliteJournal.Domain;

namespace EliteJournal.Messaging
{
    public class StarSystemChange
    {
        public readonly StarSystem System;

        public StarSystemChange(StarSystem system)
        {
            this.System = system;
        }
    }
}
