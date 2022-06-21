using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentize.Models
{

    class HouseModel
    {
        [Key]
        public int HouseId { get; set; }

        [Required]
        public string HouseOwner { get; set; }
        public List<string> HouseTennants { get; set; }
        public HouseTypes HouseType { get; set; }
        public HouseStyles HouseStyle { get; set; }

        [Timestamp]
        public string CreatedAt { get => createdAt; set => createdAt = value; }

        private string createdAt = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");

        public HouseModel()
        {
            HouseOwner = "None";
            HouseTennants = new List<string> { "None" };
            HouseType = HouseTypes.APPARTMENT;
            HouseStyle = HouseStyles.DEFAULT;
        }
    }
}
