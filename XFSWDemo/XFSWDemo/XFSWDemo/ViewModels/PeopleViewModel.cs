namespace XFSWDemo.ViewModels
{
    public class PeopleViewModel : BaseViewModel
    {
        private string name;
        private string height;
        private string mass;
        private string hair_color;
        private string skin_color;
        private string eye_color;
        private string birth_year;
        private string gender;

        public string Name
        {
            get { return name; }
            set { if (name == value) return; name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Height
        {
            get { return height; }
            set { if (height == value) return; height = value; OnPropertyChanged(nameof(Height)); }
        }
        public string Mass
        {
            get { return mass; }
            set { if (mass == value) return; mass = value; OnPropertyChanged(nameof(Mass)); }
        }
        public string Hair_color
        {
            get { return hair_color; }
            set { if (hair_color == value) return; hair_color = value; OnPropertyChanged(nameof(Hair_color)); }
        }
        public string Skin_color
        {
            get { return skin_color; }
            set { if (skin_color == value) return; skin_color = value; OnPropertyChanged(nameof(Skin_color)); }
        }
        public string Eye_color
        {
            get { return eye_color; }
            set { if (eye_color == value) return; eye_color = value; OnPropertyChanged(nameof(Eye_color)); }
        }
        public string Birth_year
        {
            get { return birth_year; }
            set { if (birth_year == value) return; birth_year = value; OnPropertyChanged(nameof(Birth_year)); }
        }
        public string Gender
        {
            get { return gender; }
            set { if (gender == value) return; gender = value; OnPropertyChanged(nameof(Gender)); }
        }
    }
}
