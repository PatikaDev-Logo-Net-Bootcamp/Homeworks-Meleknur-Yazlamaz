using HW4.App.Business.DTOs;

namespace HW4.App.Business.Abstract
{
    public interface IJWTService
    {
        TokenDto Authenticate(UserDto user);
    }
}