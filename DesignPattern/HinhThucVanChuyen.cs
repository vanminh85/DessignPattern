using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class HinhThucVanChuyen
    {
        public void ThucHien()
        {
            var pt = TaoPhuongTien();
            pt.DiChuyen();
        }
        public virtual PhuongTien TaoPhuongTien()
        {
            return null;
        }

    }
    public class DuongBo : HinhThucVanChuyen
    {
        public override PhuongTien TaoPhuongTien()
        {
            return new XeTai();
        }

    }
    public class DuongBien : HinhThucVanChuyen
    {
        public override PhuongTien TaoPhuongTien()
        {
            return new TauThuy();
        }
    }
    public class DuongBay : HinhThucVanChuyen
    {
        public override PhuongTien TaoPhuongTien()
        {
            return new MayBay();
        }
    }
    public interface PhuongTien
    {
        void DiChuyen();

    }

    public class XeTai: PhuongTien
    {
        public void DiChuyen()
        {
            Console.WriteLine("Xe tai di chuyen.");
        }
    }

    public class TauThuy: PhuongTien
    {
        public void DiChuyen()
        {
            Console.WriteLine("Tau thuy di chuyen.");
        }
    }
    public class MayBay : PhuongTien
    {
        public void DiChuyen()
        {
            Console.WriteLine("May bay di chuyen.");
        }
    }
}
