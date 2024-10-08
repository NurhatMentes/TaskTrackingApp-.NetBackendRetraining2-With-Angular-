﻿using Core.Entities.Concrete;
using Core.Entities.DTOs;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        public IResult Logout();
    }
}
