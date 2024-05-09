// See https://aka.ms/new-console-template for more information
using DesignPattern;
using DesignPatterns;

Car car = new CarBuiler()
                .SetName("BMW")
                .SetColor("Black")
                .SetYear(2016)            
                .Build();

Console.WriteLine("Hello, World !");

/*var htvc = new DuongBo();
htvc.ThucHien();*/

/*var trangTri = new KieuCoDien();
trangTri.ThucHien();*/