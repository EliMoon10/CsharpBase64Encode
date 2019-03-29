using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase64Encode
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Moon!"; //문자열
            byte[] newData = Encoding.Unicode.GetBytes(s);//바이트 타입으로 변환

            string newDataEncoded = Convert.ToBase64String(newData);//Base64로 인코딩

            Console.WriteLine(newDataEncoded);//출력 : SABlAGwAbABvACAATQBvAG8AbgAhAA==

            Console.WriteLine("디인코딩 중......");
            //----------------------------------디인코딩----------------------------------------
            byte[] reNewData = Convert.FromBase64String(newDataEncoded); //다시 바이트로 변환

            string result = Encoding.Unicode.GetString(reNewData); //바이트를 다시 유니코드 타입으로 변환

            Console.WriteLine(result); //최종 출력 : Hello Moon!

        }
    }
}
