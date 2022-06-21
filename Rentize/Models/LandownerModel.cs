using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentize.Models
{
    class LandownerModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        // [Association]  // TODO: Figure out how to set a foreign key constraint
        public List<HouseModel> OwnedHouses { get; set; }

        [Timestamp]
        public string CreatedAt { get => createdAt; set => createdAt = value; }

        private string createdAt = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
    }
}
