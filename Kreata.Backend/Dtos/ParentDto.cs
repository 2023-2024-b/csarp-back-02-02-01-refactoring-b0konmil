using Kreata.Backend.Datas;
namespace Kreata.Backend.Dtos
{
    public class ParentDto
    {
        public ParentDto()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            IsWoman = false;
            BirthDay = DateTime.MinValue;
            PlaceOfBirth = string.Empty;
            MathersName = string.Empty;
        }
        public ParentDto(Guid id, string firstName, string lastName, bool isWoman, DateTime birthDay, string placeOfBirth, string mathersName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            MathersName = mathersName;
        }

        public ParentDto(string firstName, string lastName, bool isWoman, DateTime birthDay, string placeOfBirth, string mathersName)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            MathersName = mathersName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsWoman { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public string MathersName { get; set; }
        public string HungarianName => $"{LastName} {FirstName}";
        public bool HasId => Id != Guid.Empty;
        public bool IsMan => !IsWoman;
    }
}
