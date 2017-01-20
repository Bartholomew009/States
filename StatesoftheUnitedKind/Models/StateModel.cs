using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatesoftheUnitedKind.Models
{
    public class StateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearFounded { get; set; }
        // TODO add picture of state
        public string stateMotto { get; set; }
        public long population { get; set; }
    }
}