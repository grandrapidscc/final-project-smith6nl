namespace CIS129FinalProject;

public class BaseNames
{

    private int _location;
    
        public BaseNames(int aLocation) {        
            _location = aLocation;
            }

        public int Location 
        {
            get => _location;
            set => _location = value;
        }
}
    