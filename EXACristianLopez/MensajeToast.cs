using System;
using System.Collections.Generic;
using System.Text;

namespace EXACristianLopez
{
    public interface  MensajeToast
    {
        void LongAlert(string mensaje);  //5seg
        
        void ShortAlert(string mensaje);  //3seg

    }
}
