namespace XFSWDemo.ViewModels
{
    public class StarShipViewModel : BaseViewModel
    {
        private string name;
        private string model;
        private string manufacturer;
        private string cost_in_credits;
        private string length;
        private string max_atmosphering_speed;
        private string crew;
        private string passengers;
        private string cargo_capacity;
        private string consumables;
        private string hyperdrive_rating;
        private string _MGLT;
        private string starship_class;

        public string Name
        {
            get { return name; }
            set { if (name == value) return; name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Model
        {
            get { return model; }
            set { if (model == value) return; model = value; OnPropertyChanged(nameof(Model)); }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { if (manufacturer == value) return; manufacturer = value; OnPropertyChanged(nameof(Manufacturer)); }
        }
        public string Cost_in_credits
        {
            get { return cost_in_credits; }
            set { if (cost_in_credits == value) return; cost_in_credits = value; OnPropertyChanged(nameof(Cost_in_credits)); }
        }
        public string Length
        {
            get { return length; }
            set { if (length == value) return; length = value; OnPropertyChanged(nameof(Length)); }
        }
        public string Max_atmosphering_speed
        {
            get { return max_atmosphering_speed; }
            set { if (max_atmosphering_speed == value) return; max_atmosphering_speed = value; OnPropertyChanged(nameof(Max_atmosphering_speed)); }
        }
        public string Crew
        {
            get { return crew; }
            set { if (crew == value) return; crew = value; OnPropertyChanged(nameof(Crew)); }
        }
        public string Passengers
        {
            get { return passengers; }
            set { if (passengers == value) return; passengers = value; OnPropertyChanged(nameof(Passengers)); }
        }
        public string Cargo_capacity
        {
            get { return cargo_capacity; }
            set { if (cargo_capacity == value) return; cargo_capacity = value; OnPropertyChanged(nameof(Cargo_capacity)); }
        }
        public string Consumables
        {
            get { return consumables; }
            set { if (consumables == value) return; consumables = value; OnPropertyChanged(nameof(Consumables)); }
        }
        public string Hyperdrive_rating
        {
            get { return hyperdrive_rating; }
            set { if (hyperdrive_rating == value) return; hyperdrive_rating = value; OnPropertyChanged(nameof(Hyperdrive_rating)); }
        }
        public string MGLT
        {
            get { return _MGLT; }
            set { if (_MGLT == value) return; _MGLT = value; OnPropertyChanged(nameof(MGLT)); }
        }
        public string Starship_class
        {
            get { return starship_class; }
            set { if (starship_class == value) return; starship_class = value; OnPropertyChanged(nameof(Starship_class)); }
        }
    }
}
