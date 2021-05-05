using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChuongTrinhPhanLoaiVanban
{
    class XuLyDuLieu
    {
        public static String RAW_DIC_NAME = System.IO.Directory.GetCurrentDirectory() + "\\dic\\vietDic.txt";
        public static String NEW_DIC_NAME = System.IO.Directory.GetCurrentDirectory() + "\\dic\\newVietDic.txt";
        public static String KT_DIC_NAME = System.IO.Directory.GetCurrentDirectory() + "\\dic\\kinhte.txt";
        public static String TT_DIC_NAME = System.IO.Directory.GetCurrentDirectory() + "\\dic\\thethao.txt";
        public static String PL_DIC_NAME = System.IO.Directory.GetCurrentDirectory() + "\\dic\\phapluat.txt";
        public static String SVM_DATA_PATH = System.IO.Directory.GetCurrentDirectory() + "\\svmData\\";
        public static String RAW_DATA_PATH = System.IO.Directory.GetCurrentDirectory() + "\\rawData";
        public static String TEST_DATA_PATH = System.IO.Directory.GetCurrentDirectory() + "\\testData";


        public static int maxWordLength = 15;

        public static int TYPE_THETHAO = 1;
        public static int TYPE_KINHTE = 2;
        public static int TYPE_PHAPLUAT = 3;


        public static String[] stopWordArr = {     "\"",
                                                   "/", 
                                                   "?", 
                                                   "!", 
                                                   "+", 
                                                   "-", 
                                                   "&",
                                                   "@",
                                                   "(",
                                                   ")",
                                                   "/r/n",
                                                   ":",
                                                   "," 
                                                   };

        public static String[] noMeaningArr = {     " là ", 
                                                    " và ",   
                                                    " những ",
                                                    " cũng ",
                                                    " khi ",
                                                    " với ",
                                                    " sẽ ",
                                                    " được ",
                                                    " ở "
                                                };
    }
}
