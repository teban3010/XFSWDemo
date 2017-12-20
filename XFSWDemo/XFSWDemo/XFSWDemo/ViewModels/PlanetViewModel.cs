namespace XFSWDemo.ViewModels
{
    public class PlanetViewModel : BaseViewModel
    {
        private string name;
        private string rotation_period;
        private string orbital_period;
        private string diameter;
        private string climate;
        private string gravity;
        private string terrain;
        private string surface_water;
        private string population;

        public string Name
        {
            get { return name; }
            set { if (name == value) return; name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Rotation_period
        {
            get { return rotation_period; }
            set { if (rotation_period == value) return; rotation_period = value; OnPropertyChanged(nameof(Rotation_period)); }
        }
        public string Orbital_period
        {
            get { return orbital_period; }
            set { if (orbital_period == value) return; orbital_period = value; OnPropertyChanged(nameof(Orbital_period)); }
        }
        public string Diameter
        {
            get { return diameter; }
            set { if (diameter == value) return; diameter = value; OnPropertyChanged(nameof(Diameter)); }
        }
        public string Climate
        {
            get { return climate; }
            set { if (climate == value) return; climate = value; OnPropertyChanged(nameof(Climate)); }
        }
        public string Gravity
        {
            get { return gravity; }
            set { if (gravity == value) return; gravity = value; OnPropertyChanged(nameof(Gravity)); }
        }
        public string Terrain
        {
            get { return terrain; }
            set { if (terrain == value) return; terrain = value; OnPropertyChanged(nameof(Terrain)); }
        }
        public string Surface_water
        {
            get { return surface_water; }
            set { if (surface_water == value) return; surface_water = value; OnPropertyChanged(nameof(Surface_water)); }
        }
        public string Population
        {
            get { return population; }
            set { if (population == value) return; population = value; OnPropertyChanged(nameof(Population)); }
        }
    }
}
