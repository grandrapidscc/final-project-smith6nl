namespace CIS129FinalProject.gameclasses;

public class Room
{
    private Rm _n, _s, _w, _e; 
        private string _locname, _locdescription;

        public Room(string locName, string locDescription,
            Rm aN, Rm aS, Rm aW, Rm aE)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
            _locname = locName;
            _locdescription = locDescription;
        }

        public Rm N
        {
            get => _n;
            set => _n = value;
        }

        public Rm S
        {
            get => _s;
            set => _s = value;
        }

        public Rm W
        {
            get => _w;
            set => _w = value;
        }

        public Rm E
        {
            get => _e;
            set => _e = value;
        }
        public string LocationName
        {
            get => _locname;
            set => _locname = value;
        }

        public string LocationDescription
        {
            get => _locdescription;
            set => _locdescription = value;
        }

        public string LocationDescribe()
        {
            return $"[{LocationName}] This is {LocationDescription}";
        }
    }
}