using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerSystem.Entity
{
    class LgOcrDeviceImage
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceModel { get; set; }
        public string CreateBy { get; set; }
        public string ImagePath { get; set; }
    }
}
