using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.APPLICATION.DTOs.OtpRequest
{
    public class OtpRequestDto
    {
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
    }
}
