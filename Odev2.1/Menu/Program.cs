using excel = Microsoft.Office.Interop.Excel;
namespace Benzinlik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            excel.Application uygulama = new excel.Application();
            excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            excel.Worksheet sayfa1 = (excel.Worksheet)kitap.Sheets[1];
            ((excel.Range)sayfa1.Cells[1, 1]).Value2 = "Urun Adi";
            ((excel.Range)sayfa1.Cells[1, 2]).Value2 = "Fiyat";
            ((excel.Range)sayfa1.Cells[1, 3]).Value2 = "Adet";
            ((excel.Range)sayfa1.Cells[1, 4]).Value2 = "Toplam";
            int satırNo = 2;
            int sutunNo = 1;
            excel.Range alan = (excel.Range)sayfa1.Cells[satırNo, sutunNo];
            
            Urun Cikolata = new Urun("Çikolata",5,1000);
            Urun Gazoz = new Urun("Gazoz",25,1000);
            Urun Biskuvi = new Urun("Biskuvi", 10, 1000);
            Urun Benzin = new Urun ("Benzin",35,1000);

            bool AnaMenuDurum = true;

            while (AnaMenuDurum) 
            {
                Console.WriteLine("\n1-Satış Yap");
                Console.WriteLine("2-Rapor Görüntüle");
                Console.WriteLine("3-Çıkış");
                Console.Write("Sayı Girin:");

                int AnaMenuInput;
                bool AnaMenusonuc = int.TryParse(Console.ReadLine(), out AnaMenuInput);

                if (AnaMenusonuc) 
                {
                    switch (AnaMenuInput) 
                    {
                        case 1:
                            bool UrunMenusu = true;
                            while(UrunMenusu)
                            {
                                Console.WriteLine("\n1-Çikolata(5TL)");
                                Console.WriteLine("2-Gazoz(25TL)");
                                Console.WriteLine("3-Bisküvi(10TL)");
                                Console.WriteLine("4-Benzin(35TL)");
                                Console.WriteLine("5-Çıkış");
                                Console.Write("Sayı Girin:");
                                int SatisMenuInput;
                                bool SatisMenuSonuc = int.TryParse(Console.ReadLine(), out SatisMenuInput);
                                if (SatisMenuSonuc)
                                {
                                    switch (SatisMenuInput) 
                                    {
                                        case 1:
                                            Console.WriteLine("Ürün adedi girin:");
                                            int CikolataInput;
                                            bool CikolataInputSonuc=int.TryParse(Console.ReadLine(),out CikolataInput);
                                            if(CikolataInputSonuc && Cikolata.Adet-CikolataInput>=0)
                                            {
                                                satırNo = SatisYap(Cikolata,sayfa1,satırNo,CikolataInput);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nHatalı Giriş\n");
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Ürün adedi girin:");
                                            int GazozInput;
                                            bool GazozInputSonuc = int.TryParse(Console.ReadLine(), out GazozInput);
                                            if (GazozInputSonuc && Gazoz.Adet-GazozInput>0)
                                            {
                                                satırNo = SatisYap(Gazoz, sayfa1, satırNo, GazozInput);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nHatalı Giriş\n");
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Ürün adedi girin:");
                                            int BiskuviInput;
                                            bool BiskuviInputSonuc = int.TryParse(Console.ReadLine(), out BiskuviInput);
                                            if (BiskuviInputSonuc && Biskuvi.Adet - BiskuviInput > 0)
                                            {
                                                satırNo = SatisYap(Biskuvi, sayfa1, satırNo, BiskuviInput);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nHatalı Giriş\n");
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine("Ürün adedi girin:");
                                            int BenzinInput;
                                            bool BenzinInputSonuc = int.TryParse(Console.ReadLine(), out BenzinInput);
                                            if (BenzinInputSonuc && Benzin.Adet - BenzinInput > 0)
                                            {
                                                satırNo = SatisYap(Benzin, sayfa1, satırNo, BenzinInput);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nHatalı Giriş\n");
                                            }
                                            break;
                                        case 5:
                                            UrunMenusu = false;
                                            break;
                                        default: 
                                            Console.WriteLine("\nHatalı Giriş\n");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nHatalı Giriş\n");
                                }
                            }
                            break;
                        case 2:
                            uygulama.Visible = true;
                            break;
                        case 3:
                            uygulama.Quit();
                            AnaMenuDurum = false;
                            break;
                        default:
                            Console.WriteLine("\nHatalı Giriş\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nHatalı Giriş\n");
                }

            }


        }

        static int SatisYap(Urun urun, excel.Worksheet sayfa, int satirNo, int urunInput)
        {
            ((excel.Range)sayfa.Cells[satirNo, 1]).Value2 = urun.UrunAdı;
            ((excel.Range)sayfa.Cells[satirNo, 2]).Value2 = urun.Fiyat;
            ((excel.Range)sayfa.Cells[satirNo, 3]).Value2 = urunInput;
            ((excel.Range)sayfa.Cells[satirNo, 4]).Value2 = (urunInput * urun.Fiyat);
            urun.Adet -= urunInput;
            Console.WriteLine("Satış Başarılı. Tutar: {0}", (urunInput * urun.Fiyat));
            return ++satirNo;
        }
    }
}