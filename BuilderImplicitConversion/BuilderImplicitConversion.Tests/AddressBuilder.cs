namespace BuilderImplicitConversion.Tests
{
    public class AddressBuilder
    {
        public static AddressBuilder anAddress()
        {
            return new AddressBuilder();
        }

        private AddressBuilder()
        {
            HouseName = "";
            Number = "";
            BuildingName = "";
            Street = "";
            Town = "";
        }

        public string Town { get; set; }
        public string Street { get; set; }
        public string BuildingName { get; set; }
        public string Number { get; set; }
        public string HouseName { get; set; }

        public AddressBuilder WithHouseName(string houseName)
        {
            HouseName = houseName;
            return this;
        }

        public AddressBuilder WithNumber(string number)
        {
            Number = number;
            return this;
        }

        public AddressBuilder WithBuildingName(string buildingName)
        {
            BuildingName = buildingName;
            return this;
        }

        public AddressBuilder WithStreet(string street)
        {
            Street = street;
            return this;
        }

        public AddressBuilder WithTown(string town)
        {
            Town = town;
            return this;
        }

        public Address Build()
        {
            return new Address(HouseName, Number, BuildingName, Street, Town);
        }

        public static implicit operator Address(AddressBuilder builder)
        {
            return new Address(builder.HouseName, builder.Number, builder.BuildingName,
                builder.Street, builder.Town);
        }
    }
}
