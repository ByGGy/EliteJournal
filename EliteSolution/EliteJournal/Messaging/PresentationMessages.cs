using EliteJournal.Domain;

namespace EliteJournal.Messaging
{
    public class StarSystemSelection
    {
        public readonly StarSystem SystemSelected;

        public StarSystemSelection(StarSystem systemSelected)
        {
            this.SystemSelected = systemSelected;
        }
    }
}
