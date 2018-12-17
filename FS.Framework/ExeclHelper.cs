using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Framework
{

    public class ExeclHelper
    {
        public Microsoft.Office.Interop.Excel.Application m_xlApp = null;
        /// <summary>
        /// 将DataTable数据导出到Excel表
        /// </summary>
        /// <param name="tmpDataTable">要导出的DataTable</param>
        /// <param name="strFileName">Excel的保存路径及名称</param>
        public void DataTabletoExcel(System.Data.DataTable tmpDataTable, string strFileName)
        {
            if (tmpDataTable == null)
            {
                return;
            }
            long rowNum = tmpDataTable.Rows.Count;//行数
            int columnNum = tmpDataTable.Columns.Count;//列数
            Microsoft.Office.Interop.Excel.Application m_xlApp = new Microsoft.Office.Interop.Excel.Application();
            m_xlApp.DisplayAlerts = false;//不显示更改提示
            m_xlApp.Visible = false;

            Microsoft.Office.Interop.Excel.Workbooks workbooks = m_xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1

            try
            {
                if (rowNum > 65536)//单张Excel表格最大行数
                {
                    long pageRows = 65535;//定义每页显示的行数,行数必须小于65536
                    int scount = (int)(rowNum / pageRows);//导出数据生成的表单数
                    if (scount * pageRows < rowNum)//当总行数不被pageRows整除时，经过四舍五入可能页数不准
                    {
                        scount = scount + 1;
                    }
                    for (int sc = 1; sc <= scount; sc++)
                    {
                        if (sc > 1)
                        {
                            object missing = System.Reflection.Missing.Value;
                            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add(
                                        missing, missing, missing, missing);//添加一个sheet
                        }
                        else
                        {
                            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[sc];//取得sheet1
                        }
                        string[,] datas = new string[pageRows + 1, columnNum];

                        for (int i = 0; i < columnNum; i++) //写入字段
                        {
                            datas[0, i] = tmpDataTable.Columns[i].Caption;//表头信息
                        }
                        Microsoft.Office.Interop.Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]]; //worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]);
                        range.Interior.ColorIndex = 15;//15代表灰色
                        range.Font.Bold = true;
                        range.Font.Size = 9;

                        int init = int.Parse(((sc - 1) * pageRows).ToString());
                        int r = 0;
                        int index = 0;
                        int result;
                        if (pageRows * sc >= rowNum)
                        {
                            result = (int)rowNum;
                        }
                        else
                        {
                            result = int.Parse((pageRows * sc).ToString());
                        }

                        for (r = init; r < result; r++)
                        {
                            index = index + 1;
                            for (int i = 0; i < columnNum; i++)
                            {
                                object obj = tmpDataTable.Rows[r][tmpDataTable.Columns[i].ToString()];
                                datas[index, i] = obj == null ? "" : "" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                            }
                        }

                        Microsoft.Office.Interop.Excel.Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 1, columnNum]]; // worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[index + 1, columnNum]);
                        fchR.Value2 = datas;
                        worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                        m_xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;//Sheet表最大化
                        range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 1, columnNum]]; //worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[index + 1, columnNum]);
                        //range.Interior.ColorIndex = 15;//15代表灰色
                        range.Font.Size = 9;
                        range.RowHeight = 14.25;
                        range.Borders.LineStyle = 1;
                        range.HorizontalAlignment = 1;
                    }
                }
                else
                {
                    string[,] datas = new string[rowNum + 1, columnNum];
                    for (int i = 0; i < columnNum; i++) //写入字段
                    {
                        datas[0, i] = tmpDataTable.Columns[i].Caption;
                    }
                    Microsoft.Office.Interop.Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]]; //worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]);
                    range.Interior.ColorIndex = 15;//15代表灰色
                    range.Font.Bold = true;
                    range.Font.Size = 9;

                    int r = 0;
                    for (r = 0; r < rowNum; r++)
                    {
                        for (int i = 0; i < columnNum; i++)
                        {
                            object obj = tmpDataTable.Rows[r][tmpDataTable.Columns[i].ToString()];
                            datas[r + 1, i] = obj == null ? "" : "" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]]; // worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]);
                    fchR.Value2 = datas;

                    worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                    m_xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;

                    range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]]; //worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]);
                    //range.Interior.ColorIndex = 15;//15代表灰色
                    range.Font.Size = 9;
                    range.RowHeight = 14.25;
                    range.Borders.LineStyle = 1;
                    range.HorizontalAlignment = 1;
                }
                workbook.Saved = true;
                workbook.SaveCopyAs(strFileName);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                EndReport();
            }
        }


        /// <summary>
        /// 退出报表时关闭Excel和清理垃圾Excel进程
        /// </summary>
        private void EndReport()
        {
            object missing = System.Reflection.Missing.Value;
            try
            {
                m_xlApp.Workbooks.Close();
                m_xlApp.Workbooks.Application.Quit();
                m_xlApp.Application.Quit();
                m_xlApp.Quit();
            }
            catch { }
            finally
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp.Workbooks);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp.Application);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp);
                    m_xlApp = null;
                }
                catch { }
                try
                {
                    //清理垃圾进程
                    this.killProcessThread();
                }
                catch { }
                GC.Collect();
            }
        }
        /// <summary>
        /// 杀掉不死进程
        /// </summary>
        private void killProcessThread()
        {
            ArrayList myProcess = new ArrayList();
            for (int i = 0; i < myProcess.Count; i++)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(int.Parse((string)myProcess[i])).Kill();
                }
                catch { }
            }
        }
    }
}
