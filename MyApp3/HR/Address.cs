namespace HRapp.HR
{
  public class Address
  {
    private string street;
    private string houseNumber;
    private string postCode;
    private string city;

    public Address(string street, string houseNumber, string postCode, string city)
    {
      Street = street;
      HouseNumber = houseNumber;
      PostCode = postCode;
      City = city;
    }

    public string Street
    {
      get { return street; }
      set
      {
        street = value;
      }
    }
    public string HouseNumber
    {
      get { return houseNumber; }
      set
      {
        houseNumber = value;
      }
    }
    public string PostCode
    {
      get { return postCode; }
      set
      {
        postCode = value;
      }
    }
    public string City
    {
      get
      {
        return city;
      }
      set
      {
        city = value;
      }
    }
  }
}
