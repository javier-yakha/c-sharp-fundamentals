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
        /*
        Type: ushort, bytes: 2, signed: no, prefix byte: 2
        TelemetryBuffer.ToBuffer(5) => {0x2, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

        // Type: int, bytes: 4, signed: yes, prefix byte: 256 - 4
        TelemetryBuffer.ToBuffer(Int32.MaxValue) => {0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 };
        */
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
        /*
        TelemetryBuffer.FromBuffer(new byte[] {0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 }) => 2147483647
        If the prefix byte is of unexpected value then 0 should be returned.
         */
        public static long FromBuffer(byte[] buffer)
        {
            switch (buffer[0])
            {

            }
        }
    }
}
