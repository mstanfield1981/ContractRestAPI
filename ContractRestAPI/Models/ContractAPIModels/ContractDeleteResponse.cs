using System;
using System.Runtime.Serialization;

namespace ContractRestAPI.Models
{
    [DataContract]
    public class ContractDeleteResponse
    {
        [DataMember(Name = "Delete successful")]
        public Boolean deleteSuccessful { get; set; }
        [DataMember(Name = "Delete message")]
        public String deleteMessage { get; set; }
    }
}