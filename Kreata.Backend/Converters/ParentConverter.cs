using Kreata.Backend.Datas;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;
using Kreta.Shared.Dtos;
namespace Kreata.Backend.Converters
{
    public static class ParentConverter
    {
        public static ParentDto ToDto(Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                BirthDay = parent.BirthDay,
                PlaceOfBirth = parent.PlaceOfBirth,
                IsWoman = parent.IsWoman,
                MathersName = parent.MathersName,
            };
        }
        public static Parent ToModel(ParentDto parent)
        {
            return new Parent
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                BirthDay = parent.BirthDay,
                PlaceOfBirth = parent.PlaceOfBirth,
                IsWoman = parent.IsWoman,
                MathersName = parent.MathersName,
            };
        }

        public static List<ParentDto> GetParentsDtos(List<Parent> parents)
        {
            return parents.Select(parent => ToDto(parent)).ToList();
        }
        public static List<Parent> GetParents(List<ParentDto> parentDtos)
        {
            return parentDtos.Select(parentDto => ToModel(parentDto)).ToList();
        }
    }
}
