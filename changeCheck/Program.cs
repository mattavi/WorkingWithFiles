using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Excel= Microsoft.Office.Interop.Excel;

namespace changeCheck
{
    class Program
    {
        private static Excel.Application App = null;
        private static Excel.Workbook Book = null;
        private static Excel.Worksheet Sheet = null;
        static void Main(string[] args)
        {
            //string[] oldCount = File.ReadAllLines(@"D:\new.txt");
            //string[] newCount = File.ReadAllLines(@"D:\old.txt");

            //DataTable dtRecords = new DataTable();
            //DataRow row = dtRecords.NewRow();
            //double rentedLOS;
            //StreamReader obj = new StreamReader(@"D:\old.txt", Encoding.Default, false);
            //string outputLine = obj.ReadLine();
            //string[] columnSplit = outputLine.Split(new string[1] { "\t" }, StringSplitOptions.None);
            //string memCont;

            //memCont = columnSplit[21].Replace("\"", "").Trim();
            //row = dtRecords.NewRow();
            //row["MemberContract"] = memCont;
            //row["Record"] = outputLine;
            //if (columnSplit[22].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim() == "")
            //    row["SumNet"] = 0;
            //else
            //    row["SumNet"] = columnSplit[22].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim();

            //if (columnSplit[17].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim() == "")
            //    row["SumNet2"] = 0;
            //else
            //    row["SumNet2"] = columnSplit[17].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim();

            //if (columnSplit[10].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim() == "")
            //    rentedLOS = 0;
            //else
            //    rentedLOS = double.Parse(columnSplit[10].ToString().Replace(",", "").Replace("$", "").Replace("\"", "").Trim());

            //row["RentedLOS"] = rentedLOS;
            //row["LosGroup"] = rentedLOS == 0 ? "0" : "1";

            //Console.WriteLine(obj.ReadLine());


            //StreamReader obj = new StreamReader(@"D:\14ps.txt");
            //string[] data = File.ReadAllLines(@"D:\14ps.txt");
            //while(obj.ReadLine()!=null)
            //{
            //    string line = obj.ReadLine();
            //}

            //      File For Writing Data

            //string path = @"D:\data.txt";
            //if (File.Exists(path))
            //{
            //    File.Delete(path);

            //    File.Create(path).Close();


            //}

            //TextWriter write = new StreamWriter(@"D:\data.txt");
            //string[] lines = File.ReadAllLines(@"D:\dummy.txt");
            //int no = 1;
            //for (int i=0; i<lines.Length; i++)
            //{
            //    if(lines[i].Trim().StartsWith("string commandText") || lines[i].Trim().StartsWith("string queryString"))
            //    {
            //        string[] commandSplit = lines[i].Split('"');
            //        string command = commandSplit[1];

            //        for(int j=i; j>=0; j--)
            //        {
            //            if(lines[j].Trim().StartsWith("public "))
            //            {
            //                string[] lineSplit = lines[j].Split('(');

            //                string[] namePublic = lineSplit[0].Split(' ');

            //                string method = namePublic.Last();


            //                write.WriteLine("{2}){0} -------{1}", command, method,no);

            //                no++;
            //                break;
            //            }
            //        }
            //    }
            //}
            //write.Close();


            // Console.ReadLine();
            //string path = @"D:\method.xls";
            ////File.Create(path).Close();

            //if (File.Exists(path))
            //{
            //    File.Delete(path);

            //    File.Create(path).Close();


            //}

            //App = new Excel.Application();
            //App.Visible = true;

            //Book = App.Workbooks.Open(path);

            //Sheet = (Excel.Worksheet)Book.Sheets[1];

            //Sheet.Cells[1, 4] = "Method";
            //Sheet.Cells[1, 5] = "Stored Procedure";
            //Sheet.Cells[1, 6] = "Table";

            //string[] lines = File.ReadAllLines(@"D:\dummy.txt");
            //int no = 3;
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (lines[i].Trim().StartsWith("string commandText") || lines[i].Trim().StartsWith("string queryString"))
            //    {
            //        string[] commandSplit = lines[i].Split('"');
            //        string command = commandSplit[1];

            //        for (int j = i; j >= 0; j--)
            //        {
            //            if (lines[j].Trim().StartsWith("public "))
            //            {
            //                string[] lineSplit = lines[j].Split('(');

            //                string[] namePublic = lineSplit[0].Split(' ');

            //                string method = namePublic.Last();


            //                Sheet.Cells[no,4] = method;
            //                Sheet.Cells[no, 5] = command;

            //                no++;
            //                break;
            //            }
            //        }
            //    }
            //}
            //Book.Save();

            Occurences obj = new Occurences();
            obj.Occur();
            Console.ReadLine();
        }


    }


}
