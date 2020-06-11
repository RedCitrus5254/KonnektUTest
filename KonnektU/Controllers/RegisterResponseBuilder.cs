using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class RegisterResponseBuilder
    {
        private RegisterResponse registerResponce;

        public RegisterResponse GetRegisterResponce()
        {
            return registerResponce;
        }
        public void CreateUserDataResponce(int code, User user)
        {
            if (code == 200)
            {
                registerResponce.UserData = CreateUserDataCode200(user);
            }
            else if(code == 300)
            {
                registerResponce.UserData = null;
            }
        }
        private UserDataResponce CreateUserDataCode200(User user)
        {
            UserDataResponce userDataResponce = new UserDataResponce();
            userDataResponce.UserId = user.UserId;
            userDataResponce.SecretKey = user.SourceSecretKey;
            userDataResponce.Parameters = GetParameters(user.UserId);
            return userDataResponce;
        }
        private IList<Parameter> GetParameters(string userId)
        {
            IList<Parameter> parameter;
            using (ParameterContext pc = new ParameterContext())
            {
                parameter = (IList<Parameter>)pc.Parameters.Where(p => p.UserId == userId);
            }
            return parameter;
        }
        public void CreateSourceId(string id)
        {
            registerResponce.SourceId = id;
        }
        public void CreateSuccess(bool success)
        {
            registerResponce.Success = success;
        }
        public void CreateMessage(string message)
        {
            registerResponce.Message = message;
        }
        public void CreateErrorCode(int code)
        {
            registerResponce.ErrorCode = code;
        }
        public void CreateWarnings(int code)
        {
            Warning warning;
            using(WarningContext wc = new WarningContext())
            {
                warning = wc.Warnings.Where(w => w.Code == code).FirstOrDefault();
            }
            registerResponce.Warnings = warning;
        }
        
    }
}