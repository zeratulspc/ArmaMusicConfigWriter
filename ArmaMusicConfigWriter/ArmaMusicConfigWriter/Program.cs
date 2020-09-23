using System;
using ArmaMusicConfigWriter.fnc;

namespace ArmaMusicConfigWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //new MasterFnc().ChangeFileNames("D:\\Works\\아르마\\wv_music\\tennet", new string[] { "TENET Official Soundtrack _ ", " - Ludwig Göransson _ WaterTower" });
            Console.WriteLine(new ConfigMaker().makeConfig("\\tennet", "747", "t"));
            new MasterFnc().ConfigMaker("D:\\Works\\아르마\\wv_music\\tennet", "zeratulspc", "wv_music", "\\tennet");
            // 기능 리스트
            /*
                1. 이름 변환
                2. mp3 -> ogg
                3. config 내용 제작기
             */
        }
    }
}
