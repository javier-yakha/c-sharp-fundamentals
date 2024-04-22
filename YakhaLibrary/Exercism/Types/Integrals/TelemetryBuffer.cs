using System;
using System.Collections.Generic;
using System.Linq;
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

            return new byte[9];
            
        }
        /*
        TelemetryBuffer.FromBuffer(new byte[] {0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 }) => 2147483647
        If the prefix byte is of unexpected value then 0 should be returned.
         */
        public static long FromBuffer(byte[] buffer)
        {
            throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
        }
    }
}
