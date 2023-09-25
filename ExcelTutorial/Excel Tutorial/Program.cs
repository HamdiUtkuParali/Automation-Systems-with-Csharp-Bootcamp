using excel = Microsoft.Office.Interop.Excel;

namespace Excel_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            excel.Application uygulama = new excel.Application();
            uygulama.Visible = true;
            excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            excel.Worksheet sayfa1 = (excel.Worksheet)kitap.Sheets[1];
            excel.Range alan;
            int Toplam = 0;
            int Deger = 10;
            int SatırNo = 1;
            while (SatırNo<10)
            {
                //System.Threading.Thread.Sleep(1000);
                alan = (excel.Range)sayfa1.Cells[SatırNo, 1];
                alan.Value2 = Deger;
                Toplam += Deger;

                Deger += 10;

                SatırNo++;

            }
            ((excel.Range)sayfa1.Cells[SatırNo, 1]).Value2 = Toplam ;
            //uygulama.Quit();
        }
    }
}