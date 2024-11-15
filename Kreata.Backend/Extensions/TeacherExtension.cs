using Kreata.Backend.Datas;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;
using Kreta.Shared.Dtos;

namespace Kreata.Backend.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthDay = teacher.BirthDay,
                MathersName = teacher.MathersName,
            };
        }
        public static Teacher ToTeacher(this TeacherDto teacherDto)
        {
            return new Teacher
            {
                Id = teacherDto.Id,
                FirstName = teacherDto.FirstName,
                LastName = teacherDto.LastName,
                BirthDay = teacherDto.BirthDay,
                MathersName = teacherDto.MathersName,
            };
        }
    }
}
