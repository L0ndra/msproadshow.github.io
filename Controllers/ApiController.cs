using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using msproadshow.DAL;
using msproadshow.Models;

namespace msproadshow.Controllers
{
    public class ApiController : Controller
    {
        private IConfiguration _configuration;
        private ParticipantDal _dal;
        public ApiController(IConfiguration configuration){
            _configuration = configuration;
            _dal = new ParticipantDal(configuration);
        }

        public async Task<string> Registration(ParticipantModel participant)
        {
            try
            {
                await _dal.AddNewParticipantAsync(participant);
                return "success";
            }
            catch(Exception ex){
                return "failed";
            }
        }

    }
}
