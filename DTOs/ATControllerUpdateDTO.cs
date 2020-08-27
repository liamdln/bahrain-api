using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bahrain_api.DTOs
{
    public class ATControllerUpdateDTO
    {

        // So we can try clean this up because this file is the EXACT same as ATControllerCreateDTO.cs. 

        //ID is supplied by the database.
        // //[Key]
        // public int id { get; set; }

        [Required(ErrorMessage="Controller name is required.")]
        public string fullName { get; set; }

        [Required(ErrorMessage="Rating is required.")]
        [MaxLength(2, ErrorMessage="Rating can only be 2 characters. For example, S1 or C3.")]
        public string rating { get; set; }

        [Required(ErrorMessage="VATSIM ID is required.")]
        public string networkID { get; set; }

        [Required(ErrorMessage="Sign off state is required.")]
        public bool hasSignOff { get; set; }

        [Required(ErrorMessage="Solo endorsement state is required.")]
        public bool onSolo { get; set; }

        [Required(ErrorMessage="Visiting status required.")]
        public bool visitor { get; set; }

        [Required(ErrorMessage="Home vACC required.")]
        public string homeVACC { get; set; }

        [Required(ErrorMessage="Approved positions required.")]
        public string approvedPositions { get; set; }



    }
}