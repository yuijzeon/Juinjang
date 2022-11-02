using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPrice
{
    static class DataGridViewExtention
    {
        public static void ExportDatagridToCsv(this DataGridView dataGridView, string FileName, string[] ColumnName, bool HasColumnName)
        {
            string strValue = string.Empty;
            //CSV 匯出的標題 要先塞一樣的格式字串 充當標題
            if (HasColumnName == true)
                strValue = string.Join(",", ColumnName);
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dataGridView[j, i].Value.ToString()))
                    {
                        if (j > 0)
                            strValue = strValue + "," + dataGridView[j, i].Value.ToString();
                        else
                        {
                            if (string.IsNullOrEmpty(strValue))
                                strValue = dataGridView[j, i].Value.ToString();
                            else
                                strValue = strValue + Environment.NewLine + dataGridView[j, i].Value.ToString();
                        }
                    }
                    else
                    {
                        if (j > 0)
                            strValue = strValue + ",";
                        else
                            strValue = strValue + Environment.NewLine;
                    }
                }

            }
            //存成檔案
            string strFile = FileName;
            if (!string.IsNullOrEmpty(strValue))
            {
                File.WriteAllText(strFile, strValue, Encoding.Default);
            }
        }
    }
}
