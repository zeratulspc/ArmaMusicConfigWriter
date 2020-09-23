using System;
using System.Collections.Generic;
using System.Text;

namespace ArmaMusicConfigWriter.fnc
{
    public class NameChanger
    {
        //사용법 : changeFileName(원본 파일명, 삭제할 요소)
        public string ChangeFileName(string oldFile, string[] content) 
        {
            string result = oldFile.Split('.')[0];

            //oldFile에서 content 제거
            for (int i = 0; i < content.Length; i++) 
            {
                string[] box = result.Split(content[i]);
                result = "";
                foreach (string j in box)
                {
                    result += j;
                }

            }
            result.Replace(" ", "_");
            result += ".ogg";
            return result;
        }
    }
}
