using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class CongTyTrangTriNoiThat
    {
    }
    public abstract class PhongCachTrangTri
    {
        public void ThucHien()
        {
            var ghe = TaoGhe();
            var ban = TaoBan();
        }
        public abstract Ghe TaoGhe();
        public abstract Ban TaoBan();
    }
    public class KieuCoDien : PhongCachTrangTri
    {
        public override Ban TaoBan()
        {
            return new BanCoDien();
        }
        public override Ghe TaoGhe()
        {
            return new GheCoDien();
        }
    }
    public class KieuHienDai : PhongCachTrangTri
    {
        public override Ban TaoBan()
        {
            return new BanHienDai();
        }
        public override Ghe TaoGhe()
        {
            return new GheHienDai();
        }
    }
    public interface Ban
    {
    }
    public class BanHienDai : Ban
    {
    }
    public class BanCoDien : Ban
    {
    }
    public interface Ghe
    {

    }
    public class GheHienDai : Ghe 
    {
    }
    public class GheCoDien : Ghe
    {
    }

}
