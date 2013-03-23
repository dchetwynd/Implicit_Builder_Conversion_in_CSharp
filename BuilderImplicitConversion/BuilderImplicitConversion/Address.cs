namespace BuilderImplicitConversion
{
    public class Address
    {
        private string _houseName;
        private string _number;
        private string _buildingName;
        private string _street;
        private string _town;

        public Address(string houseName, string number, string buildingName, string street, string town)
        {
            _houseName = houseName;
            _number = number;
            _buildingName = buildingName;
            _street = street;
            _town = town;
        }

        public override string ToString()
        {
            string addressDisplay = GetFirstLine() +
                (string.IsNullOrEmpty(_street) ? "" : _street + ", ") +
                (string.IsNullOrEmpty(_town) ? "" : _town + ", ");
            return addressDisplay.Trim(new char[] {',', ' '});
        }

        private string GetFirstLine()
        {
            return string.IsNullOrEmpty(_houseName)
                       ? _number + " " + _buildingName + ", "
                       : _houseName + ", ";
        }
    }
}
