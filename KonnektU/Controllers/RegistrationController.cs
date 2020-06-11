using KonnektU.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace KonnektU.Controllers
{
    public class RegistrationController : ApiController
    {
        UserContext UsersDB = new UserContext();
        public IEnumerable<User> Get()
        {
            return UsersDB.Users;
        }


        public User Get(int id)
        {
            User user = UsersDB.Users.Find(id);
            return user;
        }

        [HttpPost]
        public IHttpActionResult CreateUser([FromBody]User user)
        {
            //тут нужна проверка на ошибки при вводе данных пользователя.
            //если всё в порядке, добавляем в базу данных и отправляем ОК
            User createdUser = UsersDB.Users.Add(user);
            UsersDB.SaveChanges();
            RegisterResponseBuilder builder = new RegisterResponseBuilder();
            RegisterResponseDirector director = new RegisterResponseDirector(builder);

            var responce = director.CreateRegisterResponseCode200(createdUser);

            return Ok(responce);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}