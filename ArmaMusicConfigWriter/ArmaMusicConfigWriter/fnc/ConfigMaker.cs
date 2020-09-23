using System;
using System.Collections.Generic;
using System.Text;

namespace ArmaMusicConfigWriter.fnc
{
    class ConfigMaker
    {
        public string makeConfig(string path, string name, string author)
        {
            string result = "";
            result+= "    class "+author+name.Split(".")[0]+"\n";
            result += "    {\n";
            result += "        name = \"" + name.Split(".")[0] + "\";\n";
            result += "        sound[] = { \"" + path+"\\"+ name+"\""+", db + 0, 1.0 };\n";
            result += "    }\n";
            return result;
        }
    }
}
