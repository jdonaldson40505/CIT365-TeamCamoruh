using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Donaldson
{
    /* 
     * This class is responsible for reading and writing data 
     * to the txt and Json files in the data folder.
     */
    public class dataRW
    {
        private String filePath = @"..\..\data\";
        private String fileName;
        private String fileExtension;
        private String txtData;
        private List<DeskQuote> deskQuoteList = new List<DeskQuote>();
        public dataRW(String fileName)
        {
            filePath = $@"{filePath}{fileName}";
            if (File.Exists(filePath))
            {
                this.fileName = fileName;
            }
            this.fileExtension = getFileExtension();
            if (fileExtension == ".Json")
            {
                updateDeskQuoteList();
            }
        }

        public dataRW addJsonData(DeskQuote deskquote)
        {
            deskQuoteList.Add(deskquote);
            return this;
        }
        public dataRW addTxtData(String txt)
        {
            this.txtData = txt;
            return this;
        }

        /*
         * fileWrite will call the corresponding file writing 
         * method depending upon the extension set in the constructor.
         * It will return true if the write was successful or false if
         * unsuccessful.
         * 
         * Takes type 
         */
        public bool fileWrite()
        {
            switch (fileExtension)
            {
                case ".txt":
                    return txtFileWrite();
                case ".Json":
                    return jsonFileWrite();
                default: return false;
            }
        }

        private bool jsonFileWrite()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    var quote = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
                    File.WriteAllText(filePath, quote);
                    return true;
                }
                catch { }
            }
            return false;
        }

        private bool txtFileWrite()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.WriteAllText(filePath, txtData);
                    return true;
                }
                catch
                {}
            }
            return false;
        }

 
        public List<DeskQuote> readJsonData()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    var data = File.ReadAllText(filePath);
                    if(data.Length > 0)
                    {
                        deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(data);
                    }
                    return deskQuoteList;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public String[] readTxtData()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllLines(filePath);
                }
                catch{}
            }
            return null;
        }

        public void clearJson()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.WriteAllText(filePath, "");
                }
                catch
                {
                }
            }
        }
        private String getFileExtension()
        {
            try
            {
                return this.fileName.Substring(this.fileName.IndexOf("."));
            }
            catch(Exception e)
            {
                throw(e); 
            }
        }
        
        private void updateDeskQuoteList()
        {
            if(readJsonData() == null) 
            {
                Console.WriteLine("unable to read data from json");
            }
        }
    }
}
