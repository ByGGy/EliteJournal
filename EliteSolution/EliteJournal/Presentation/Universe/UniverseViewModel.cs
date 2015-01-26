using EliteJournal.Domain;
using EliteJournal.Messaging;
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

        private StarSystem starSystemSelected;
        public StarSystem StarSystemSelected
        {
            get { return this.starSystemSelected; }
            set
            {
                if (this.starSystemSelected != value)
                {
                    this.starSystemSelected = value;
                    EasyLocator.Instance.News.Publish(new StarSystemSelection(this.starSystemSelected));
                    NotifyPropertyChanged("StarSystemSelected");
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

            EasyLocator.Instance.News.Subscribe<StarSystemChange>(msg =>
            {
                this.StarSystemCollection = EasyLocator.Instance.Universe.StarSystems.OrderBy(system => system.Name).ToList();
            });

            this.AddSystemCommand = new SimpleCommand(() =>
            {
                EasyLocator.Instance.Universe.CreateStarSystem(this.newName);
                this.StarSystemCollection = EasyLocator.Instance.Universe.StarSystems.OrderBy(system => system.Name).ToList();
                this.NewName = string.Empty;
            });
        }
    }
}
