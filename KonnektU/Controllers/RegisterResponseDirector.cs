using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class RegisterResponseDirector
    {
        private RegisterResponseBuilder builder;

        public RegisterResponseDirector(RegisterResponseBuilder builder)
        {
            this.builder = builder;
        }
        public RegisterResponse CreateRegisterResponseCode200(User user)
        {
            builder.CreateUserDataResponce(200, user);
            builder.CreateSourceId(user.SourceId);
            builder.CreateSuccess(true);
            builder.CreateMessage("Something good");
            builder.CreateErrorCode(0);
            builder.CreateWarnings(0);
            return builder.GetRegisterResponce();
        }
        public RegisterResponse CreateRegisterResponseCode300(User user)
        {
            builder.CreateUserDataResponce(300, user);
            builder.CreateSourceId(user.SourceId);
            builder.CreateSuccess(true);
            builder.CreateMessage(null);
            builder.CreateErrorCode(300);
            builder.CreateWarnings(503);
            return builder.GetRegisterResponce();
        }
    }
}