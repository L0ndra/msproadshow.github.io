using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace msproadshow.Models
{
    [DataContract]
    public class ParticipantModel
    {
        [DataMember]
        public string FirstName {get;set;}

        [DataMember]
        public string LastName{get;set;}

        [DataMember]
        public string Email {get;set;}

        [DataMember]
        public string City {get;set;}

        [DataMember]
        public string Company {get;set;}

        [DataMember]
        public string Position {get;set;}

        [DataMember]
        public string University{get;set;}

        [DataMember]
        public string Faculty {get;set;}

        [DataMember]
        public string StudyYear {get;set;}

        [DataMember]
        public string Specialty {get;set;}

        [DataMember]
        public bool IsMailSend{get;set;}

    }
}