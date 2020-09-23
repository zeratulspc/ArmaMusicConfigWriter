using System;
using System.Collections.Generic;
using System.Text;

namespace ArmaMusicConfigWriter.fnc
{
    class MasterFnc
    {
        public void ChangeFileNames(string path, string[] content)
        {
            if (System.IO.Directory.Exists(path))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);

                foreach (var item in di.GetFiles())
                {
                    if (System.IO.File.Exists(path + "\\" + item.Name))
                    {
                        System.IO.File.Move(path + "\\" + item.Name, path + "\\" + new NameChanger().ChangeFileName(item.Name, content));
                    }
                    else
                    { 
                        //예외처리
                    }
                }
            }
            else
            { 
                //예외처리
            }
        }

        /*
         class CfgPatches
        {
	        class TAG_MyMusicAddon
	        {
		        name = "MyAddon";
		        author = "Me";
		        url = "http://xkcd.com";
		        requiredVersion = 1.80; 
		        requiredAddons[] = {};
		        units[] = {};
		        weapons[] = {};
	        };
        };
         */

        public void ConfigMaker(string path, string author, string addonName, string musicPath)
        {
            string result = "";

            result += "class CfgPatches\n{\nclass " + addonName + "\n{\n name = \"MyAddon\";\nauthor = \""+author+"\";\nurl = \"\";\nrequiredVersion = 1.80; \nrequiredAddons[] = {};\nunits[] = {};\nweapons[] = {};\n};\n};\n";
            result += "class CfgMusic\n{\n";

            if (System.IO.Directory.Exists(path))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);

                foreach (var item in di.GetFiles())
                {
                    result += new ConfigMaker().makeConfig(musicPath, item.Name, "t");
                }
            }
            else
            {
                //예외처리
            }

            result += "}\n";
            System.IO.File.WriteAllText(path+"\\config.txt", result, Encoding.Default);
        }
    }
}
