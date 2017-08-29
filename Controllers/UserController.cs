using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Models;
using System.Net.Http; 
using System.Net; 

namespace TodoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost,Route("UserRegister")]
        public string UserRegister([FromBody]VMUsers p_Usuario)
        {
            if(ModelState.IsValid)
            {
                return "Model valid"; 
            }else 
            {
                return "Model invalid"; 
            }
            
        }
    }
}