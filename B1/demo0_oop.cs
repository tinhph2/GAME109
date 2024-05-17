using System;

// Định nghĩa lớp HinhChuNhat
public class HinhChuNhat
{
    // Trạng thái của đối tượng (dữ liệu)
    private double chieuDai;
    private double chieuRong;

    // Hàm tạo của lớp HinhChuNhat
    public HinhChuNhat(double dai, double rong)
    {
        chieuDai = dai;
        chieuRong = rong;
    }

    // Phương thức tính diện tích
    public double TinhDienTich()
    {
        return chieuDai * chieuRong;
    }
}

public class Program
{
    public static void Main()
    {
        // Tạo một đối tượng HinhChuNhat với chiều dài và chiều rộng cụ thể
        HinhChuNhat hinh = new HinhChuNhat(4.5, 3.2);

        // Gọi phương thức TinhDienTich để tính diện tích hình chữ nhật
        double dienTich = hinh.TinhDienTich();

        // In kết quả ra màn hình
        Console.WriteLine("Diện tích hình chữ nhật là: " + dienTich);
    }
}