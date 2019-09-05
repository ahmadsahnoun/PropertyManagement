namespace PropertyManagementSystem.Models
{
    internal class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CoveredArea { get; set; }
        public double NotCoveredArea { get; set; }
        public double BuiltArea { get; set; }
        public double NotBuiltArea { get; set; }
        public double TotalArea { get; set; }
        public BuildingType BuildingType { get; set; }
        public MeasureUnits MeasureUnit { get; set; }
        public string Location { get; set; }
        public string LocationUrl { get; set; }
        public PropertyStatus Status { get; set; }
        public int NoOfFloors { get; set; }
    }

    internal enum BuildingType
    {
        Residential = 1,
        Commercial = 2,
        Farm = 3,
        Warehouse = 4
    }

    internal enum PropertyStatus
    {
        Rented = 1,
        Free = 2
    }

    internal enum MeasureUnits
    {
        Meter = 1,
        Hectare = 2
    }
}
