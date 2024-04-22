using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Integrals
{
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            byte size;
            byte[] bytes = new byte[9];
            switch (reading)
            {
                // reading variable must be cast from <long> to corresponding integral
                case > uint.MaxValue:
                    size = 0xf8;
                    BitConverter.GetBytes(reading).CopyTo(bytes, 1);
                    break;
                case > int.MaxValue:
                    size = 0x4;
                    BitConverter.GetBytes((uint)reading).CopyTo(bytes, 1);
                    break;
                case > ushort.MaxValue:
                    size = 0xfc;
                    BitConverter.GetBytes((int)reading).CopyTo(bytes, 1);
                    break;
                case >= 0:
                    size = 0x2;
                    BitConverter.GetBytes((ushort)reading).CopyTo(bytes, 1);
                    break;
                case >= short.MinValue:
                    size = 0xfe;
                    BitConverter.GetBytes((short)reading).CopyTo(bytes, 1);
                    break;
                case >= int.MinValue:
                    size = 0xfc;
                    BitConverter.GetBytes((int)reading).CopyTo(bytes, 1);
                    break;
                default:
                    size = 0xf8;
                    BitConverter.GetBytes(reading).CopyTo(bytes, 1);
                    break;
            };
            bytes[0] = size;
            return bytes;
        }
        public static long FromBuffer(byte[] buffer)
        {
            return buffer[0] switch
            {
                0x2  => BitConverter.ToUInt16(buffer, 1),
                0xfe => BitConverter.ToInt16(buffer, 1),
                0x4  => BitConverter.ToUInt32(buffer, 1),
                0xfc => BitConverter.ToInt32(buffer, 1),
                0xf8 => BitConverter.ToInt64(buffer, 1),
                _    => 0
            };
        }
    }
}
