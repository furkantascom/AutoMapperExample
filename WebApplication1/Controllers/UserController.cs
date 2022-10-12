using AutoMapper;
using AutoMapperExampleApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExampleApi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public UserInfoDto Get()
        {
            var user = new User()
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "TAŞ",
                Status = 1
            };

            var userInfo = _mapper.Map<UserInfoDto>(user);
            return userInfo;

        }
    }
}
