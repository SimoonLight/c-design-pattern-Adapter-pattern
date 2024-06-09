using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__design_pattern_Adapter_pattern
{

    public class USE_FOTO
    {
        public USE_FOTO(IFoto foto)
        {
            foto.Show();
        }
    }
    public interface IFoto
    {
        public void Show();
    }
    public class PNG_ : IFoto
    {
        public void Show()
        {
            Console.WriteLine(" PNG class Show method ");
        }
    } 
    public class JPEG_ : IFoto
    {
        public void Show()
        {
            Console.WriteLine(" JPEG class Show method ");
        }
    }
    public class RAW_ : IFoto
    {
        public void Show()
        {
            Console.WriteLine(" RAW class Show method ");
        }
    }

}
