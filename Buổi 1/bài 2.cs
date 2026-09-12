using System;
using System.Collections.Generic;

interface Hinh
{
    double GetDienTich();
    double GetChuVi();
    void Nhap();
    void HienThi();
}

class HinhTron : Hinh
{
    public double R { get; private set; }

    public HinhTron() { R = 1; }
    public HinhTron(double r)
    {
        if (r <= 0) throw new ArgumentException("Ban kinh phai > 0");
        R = r;
    }

    public void Nhap()
    {
        while (true)
        {
            Console.Write("Nhap ban kinh R: ");
            if (double.TryParse(Console.ReadLine(), out double r) && r > 0) { R = r; break; }
            Console.WriteLine("Ban kinh phai la mot so > 0. Thu lai.");
        }
    }

    public double GetDienTich() => Math.PI * R * R;
    public double GetChuVi() => 2 * Math.PI * R;

    public void HienThi()
    {
        Console.WriteLine("Hinh Tron: R = {0:F2}, Dien tich = {1:F2}, Chu vi = {2:F2}", R, GetDienTich(), GetChuVi());
    }
}

class HinhChuNhat : Hinh
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public HinhChuNhat() { Width = Height = 1; }
    public HinhChuNhat(double w, double h)
    {
        if (w <= 0 || h <= 0) throw new ArgumentException("Chieu dai va chieu rong phai > 0");
        Width = w; Height = h;
    }

    public void Nhap()
    {
        while (true)
        {
            Console.Write("Nhap chieu dai: ");
            if (!double.TryParse(Console.ReadLine(), out double w) || w <= 0) { Console.WriteLine("Phai la so > 0."); continue; }
            Console.Write("Nhap chieu rong: ");
            if (!double.TryParse(Console.ReadLine(), out double h) || h <= 0) { Console.WriteLine("Phai la so > 0."); continue; }
            Width = w; Height = h; break;
        }
    }

    public double GetDienTich() => Width * Height;
    public double GetChuVi() => 2 * (Width + Height);

    public void HienThi()
    {
        Console.WriteLine("Hinh Chu Nhat: {0:F2} x {1:F2}, Dien tich = {2:F2}, Chu vi = {3:F2}", Width, Height, GetDienTich(), GetChuVi());
    }
}

class HinhTamGiac : Hinh
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    public HinhTamGiac() { A = B = C = 1; }
    public HinhTamGiac(double a, double b, double c)
    {
        if (!IsTamGiac(a, b, c)) throw new ArgumentException("Ba canh khong tao thanh tam giac hop le");
        A = a; B = b; C = c;
    }

    public bool IsTamGiac(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0) return false;
        return a + b > c && a + c > b && b + c > a;
    }

    public void Nhap()
    {
        while (true)
        {
            Console.Write("Nhap canh a: ");
            if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0) { Console.WriteLine("Phai la so > 0."); continue; }
            Console.Write("Nhap canh b: ");
            if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0) { Console.WriteLine("Phai la so > 0."); continue; }
            Console.Write("Nhap canh c: ");
            if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0) { Console.WriteLine("Phai la so > 0."); continue; }

            if (!IsTamGiac(a, b, c)) { Console.WriteLine("Ba canh khong thoa man de la tam giac. Thu lai."); continue; }

            A = a; B = b; C = c; break;
        }
    }

    public double GetChuVi() => A + B + C;
    public double GetDienTich()
    {
        double s = GetChuVi() / 2.0;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Heron
    }

    public void HienThi()
    {
        Console.WriteLine("Hinh Tam Giac: a={0:F2}, b={1:F2}, c={2:F2}, Dien tich={3:F2}, Chu vi={4:F2}", A, B, C, GetDienTich(), GetChuVi());
    }
}

class Program
{
    static void Main()
    {
        var shapes = new List<Hinh>();
        Console.Write("Ban muon nhap bao nhieu hinh? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) n = 3;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nChon hinh thu {0}: 1=Tron, 2=ChuNhat, 3=TamGiac", i + 1);
            string choice = Console.ReadLine();
            Hinh h = null;
            if (choice == "1")
                h = new HinhTron();
            else if (choice == "2")
                h = new HinhChuNhat();
            else
                h = new HinhTamGiac();

            h.Nhap();
            shapes.Add(h);
        }

        Console.WriteLine("\nDanh sach hinh da nhap:");
        foreach (var sh in shapes)
            sh.HienThi();

        Console.WriteLine("\nNhan Enter de thoat...");
        Console.ReadLine();
    }
}