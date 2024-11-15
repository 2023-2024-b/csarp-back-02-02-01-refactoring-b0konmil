using Kreata.Backend.Datas;
namespace Kreata.Backend.Dtos
{
    public class TeacherDto
    {
        public TeacherDto()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDay = DateTime.MinValue;
            PlaceOfBirth = string.Empty;
            IsWoman = false;
            IsHeadTeacher = false;
            MathersName = string.Empty;
        }
        public TeacherDto(Guid id, string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
            MathersName = mathersName;
        }
        public TeacherDto(string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
            MathersName = mathersName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public string MathersName { get; set; }
        public string HungarianName => $"{LastName} {FirstName}";
        public bool HasId => Id != Guid.Empty;
        public bool IsMan => !IsWoman;
        public bool IsNotHeadTeacher => !IsHeadTeacher;
    }
}
