using NUnit.Framework;

namespace BuilderImplicitConversion.Tests
{
    [TestFixture]
    class AddressTest
    {
        [Test]
        public void AddressWithHouseNameAndNoNumberDisplaysCorrectly()
        {
            Address address = AddressBuilder.anAddress()
                .WithHouseName("Dunroamin")
                .WithStreet("Golden Meadow Lane")
                .WithTown("Otley St Catchpole")
                .Build();

            Assert.That(address.ToString(), Is.EqualTo("Dunroamin, Golden Meadow Lane, Otley St Catchpole"));
        }

        [Test]
        public void AddressWithNumberAndBuildingNameDisplaysCorrectly()
        {
            Address address = AddressBuilder.anAddress()
                .WithNumber("5")
                .WithBuildingName("Hipster Flats")
                .WithStreet("Ironic Street")
                .WithTown("Hipsterville");
            Assert.That(address.ToString(), Is.EqualTo("5 Hipster Flats, Ironic Street, Hipsterville"));
        }
    }
}
