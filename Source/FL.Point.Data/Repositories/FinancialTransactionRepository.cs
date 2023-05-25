using ExcelDataReader;
using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories.Base;
using FL.Model;
using System.Data;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FL.Point.Data.Repositories
{
    public class FinancialTransactionRepository : BaseRepository<FinancialTransaction>, IFinancialTransactionRepository
    {
        public async Task<FinancialTransaction> GetById(int id)
        {
            testeteste();

            var teste = new FinancialTransaction();
            teste.Description = "TESTE TESTE";
            return teste;

        }


        public void testeteste()
        {
            //FileStream fStream = File.Open(@"", FileMode.Open, FileAccess.Read);
            //IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fStream);
            //var resultDataSet = excelDataReader.Read();
            //excelDataReader.Close();

            //using (ExcelPackage package = new ExcelPackage(new FileInfo("C:\\Users\\Felipe\\Desktop\\Pasta1.xlsx")))
            //{
            //    // obter a primeira planilha do arquivo
            //    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
            //    // obter o número de linhas e colunas
            //    int rowCount = worksheet.Dimension.End.Row;
            //    int colCount = worksheet.Dimension.End.Column;
            //    // percorrer as células da planilha
            //    for (int row = 1; row <= rowCount; row++)
            //    {
            //        for (int col = 1; col <= colCount; col++)
            //        {
            //            // obter o valor da célula como string
            //            string value = worksheet.Cells[row, col].Value.ToString().Trim();
            //            // fazer algo com o valor
            //        }
            //    }
            //}
        }
    }       
}
