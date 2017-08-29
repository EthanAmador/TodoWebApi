using System;
using Newtonsoft.Json; 
using System.ComponentModel.DataAnnotations; 

namespace TodoWebApi.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class VMUsers
    {
        [JsonIgnore]
        public Guid UserId { get; }

        [JsonProperty("NombreUsuario")]
        public string UserName { get; set; }

        [JsonProperty("Nombre")]
        public string FirstName { get; set; }

        [JsonProperty("Apellido")]
        public string LastName { get; set; }

        [JsonProperty("Estado")]
        public bool State { get; set; }

        public VMUsers()
        {
            this.UserId = Guid.NewGuid();
        }

    }
}
 