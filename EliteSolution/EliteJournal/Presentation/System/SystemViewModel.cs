using EliteJournal.Domain;
using EliteJournal.Messaging;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace EliteJournal.Presentation
{
    public class SystemViewModel : ViewModel
    {
        private StarSystem system;
        public StarSystem System
        {
            get { return this.system; }
            set
            {
                if (this.system != value)
                {
                    this.system = value;
                    NotifyPropertyChanged("System");
                }
            }
        }

        private string newSystemName;
        public string NewSystemName
        {
            get { return this.newSystemName; }
            set
            {
                if (this.newSystemName != value)
                {
                    this.newSystemName = value;
                    NotifyPropertyChanged("NewSystemName");
                }
            }
        }

        private List<SpaceBase> spaceBaseCollection;
        public List<SpaceBase> SpaceBaseCollection
        {
            get { return this.spaceBaseCollection; }
            set
            {
                if (this.spaceBaseCollection != value)
                {
                    this.spaceBaseCollection = value;
                    NotifyPropertyChanged("SpaceBaseCollection");
                }
            }
        }

        private SpaceBase spaceBaseSelected;
        public SpaceBase SpaceBaseSelected
        {
            get { return this.spaceBaseSelected; }
            set
            {
                if (this.spaceBaseSelected != value)
                {
                    this.spaceBaseSelected = value;
                    NotifyPropertyChanged("SpaceBaseSelected");
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

        public List<SpaceBase.BaseType> SpaceBaseTypeCollection
        {
            get { return Enum.GetValues(typeof(SpaceBase.BaseType)).Cast<SpaceBase.BaseType>().ToList(); }
        }

        private SpaceBase.BaseType spaceBaseTypeSelected;
        public SpaceBase.BaseType SpaceBaseTypeSelected
        {
            get { return this.spaceBaseTypeSelected; }
            set
            {
                if (this.spaceBaseTypeSelected != value)
                {
                    this.spaceBaseTypeSelected = value;
                    NotifyPropertyChanged("SpaceBaseTypeSelected");
                }
            }
        }

        private uint newDistance;
        public uint NewDistance
        {
            get { return this.newDistance; }
            set
            {
                if (this.newDistance != value)
                {
                    this.newDistance = value;
                    NotifyPropertyChanged("NewDistance");
                }
            }
        }

        public ICommand RenameSystemCommand { get; set; }
        public ICommand AddBaseCommand { get; set; }

        public SystemViewModel()
        {
            EasyLocator.Instance.News.Subscribe<StarSystemSelection>(msg =>
            {
                this.System = msg.SystemSelected;
                this.NewSystemName = this.system.Name;
                this.SpaceBaseCollection = this.system.Bases.OrderBy(spaceBase => spaceBase.DistanceFromStar).ToList();
                this.NewName = string.Empty;
            });

            EasyLocator.Instance.News.Subscribe<StarSystemChange>(msg =>
            {
                if (this.system.Id == msg.System.Id)
                {
                    NotifyPropertyChanged("System");
                    this.NewSystemName = this.system.Name;
                }
            });

            this.RenameSystemCommand = new SimpleCommand(() => EasyLocator.Instance.Universe.RenameStarSystem(this.system, this.newSystemName));

            this.AddBaseCommand = new SimpleCommand(() =>
            {
                this.system.CreateBase(this.newName, this.spaceBaseTypeSelected, this.newDistance, EasyLocator.Instance.Universe.TradingCatalog);
                this.SpaceBaseCollection = this.system.Bases.OrderBy(spaceBase => spaceBase.DistanceFromStar).ToList();
                this.NewName = string.Empty;
            });
        }
    }
}
