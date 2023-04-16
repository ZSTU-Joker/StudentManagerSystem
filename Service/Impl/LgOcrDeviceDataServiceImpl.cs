using StudentManagerSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerSystem.Service.Impl
{
    class LgOcrDeviceDataServiceImpl : LgOcrDeviceDataInterface
    {
        public void Insert(LgOcrDeviceData data)
        {
            try
            {
                Database database = new Database();
                database.Operation("INSERT INTO lg_ocr_device_data(device_id, device_name, device_code, device_model, create_by, data1, data2)VALUES(123, 'name-for-test', 'aaa-111', 'ocr_model', 'controller-test1', 11, 22); ");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
