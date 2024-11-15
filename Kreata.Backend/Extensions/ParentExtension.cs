using Kreata.Backend.Datas;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;
using Kreta.Shared.Dtos;

namespace Kreata.Backend.Extensions
{
    public static class ParentExtension
    {
        public static ParentDto ToParentDto(this Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                BirthDay = parent.BirthDay,
                MathersName = parent.MathersName,
            };
        }
        public static Parent ToParent(this ParentDto parentDto)
        {
            return new Parent
            {
                Id = parentDto.Id,
                FirstName = parentDto.FirstName,
                LastName = parentDto.LastName,
                BirthDay = parentDto.BirthDay,
                MathersName = parentDto.MathersName,
            };
        }
    }
}
