using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace SkinSwapper
{
    public static class Researcher
    {
        // Token: 0x0600015B RID: 347 RVA: 0x0001480C File Offset: 0x00012A0C
        public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
        {
            List<long> list = new List<long>();
            stream.Position = startIndex;
            for (; ; )
            {
                bool flag = stream.Position == 5000000000L;
                if (flag)
                {
                    break;
                }
                int num = stream.ReadByte();
                bool flag2 = num == -1;
                if (flag2)
                {
                    goto Block_2;
                }
                bool flag3 = num == (int)searchPattern[searchPosition];
                if (flag3)
                {
                    searchPosition++;
                    bool flag4 = searchPosition == searchPattern.Length;
                    if (flag4)
                    {
                        goto Block_4;
                    }
                }
                else
                {
                    searchPosition = 0;
                }
            }
            return list;
        Block_2:
            return list;
        Block_4:
            list.Add(stream.Position - (long)searchPattern.Length);
            return list;
        }
    }
}
