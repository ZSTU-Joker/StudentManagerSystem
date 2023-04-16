using StudentManagerSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerSystem.Service.Impl
{
    class LgOcrDeviceImageServiceImpl : LgOcrDeviceImageInterface
    {
        public void Insert(LgOcrDeviceImage image)
        {
            try
            {
                Database database = new Database();
                p.Operation("INSERT INTO lg_ocr_device_image(device_id, device_name, device_code, device_model, create_by, image_path)VALUES(123, 'equipment-111', 'code-123', 'haidebao', 'ocr-baidu', 'E:/zstu/Baidu_OCR/Baidu_OCR_C#'); ");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
