using EliteJournal.Domain;
using Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace EliteJournal.Presentation
{
    public class UniverseViewModel : ViewModel
    {
        private List<StarSystem> starSystemCollection;
        public List<StarSystem> StarSystemCollection
        {
            get { return this.starSystemCollection; }
            set
            {
                if (this.starSystemCollection != value)
                {
                    this.starSystemCollection = value;
                    NotifyPropertyChanged("StarSystemCollection");
                }
            }
        }

        private string newName;
        public string NewName
        {
            get { return this.newName; }
            set
            {
                if (this.newName != value)
                {
                    this.newName = value;
                    NotifyPropertyChanged("NewName");
                }
            }
        }

        public ICommand AddSystemCommand { get; set; }

        public UniverseViewModel()
        {
            this.StarSystemCollection = EasyLocator.Instance.Universe.StarSystems.ToList();

            this.AddSystemCommand = new SimpleCommand(() =>
            {
                EasyLocator.Instance.Universe.CreateStarSystem(this.newName);
                this.StarSystemCollection = EasyLocator.Instance.Universe.StarSystems.ToList();
                this.NewName = string.Empty;
            });
        }
    }
}
