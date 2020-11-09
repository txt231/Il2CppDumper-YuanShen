using Il2CppDumper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Il2CppDumper
{
    public class MetadataStringDecryptor
    {
        public MetadataStringDecryptor(Il2CppGlobalMetadataHeader p_Header)
        {
            InitSeed(p_Header);
            InitKeys(p_Header);
        }

        private ulong m_Seed = 0;

        private uint m_StringsOffset;
        private uint m_StringsSize;

        private uint m_StringLiteralOffset;
        private uint m_StringLiteralSize;

        private uint m_StringLiteralDataOffset;
        private uint m_StringLiteralDataSize;

        private byte[] m_KeyData = new byte[0];

      
        public uint StringsOffset => m_StringsOffset;
        public uint StringsSize => m_StringsSize;

        public uint StringLiteralOffset => m_StringLiteralOffset;
        public uint StringLiteralSize => m_StringLiteralSize;

        public uint StringLiteralDataOffset => m_StringLiteralDataOffset;
        public uint StringLiteralDataSize => m_StringLiteralDataSize;

        public byte[] KeyData => m_KeyData;

        private void InitSeed(Il2CppGlobalMetadataHeader p_Header)
        {
            uint[] s_SeedParts = new uint[18]
            {
                p_Header.KeyPart1_1,
                p_Header.KeyPart1_2,
                p_Header.KeyPart1_3,
                p_Header.KeyPart1_4,

                p_Header.KeyPart2_1,
                p_Header.KeyPart2_2,
                p_Header.KeyPart2_3,
                p_Header.KeyPart2_4,

                p_Header.KeyPart3_1,
                p_Header.KeyPart3_2,
                p_Header.KeyPart3_3,
                p_Header.KeyPart3_4,

                p_Header.KeyPart4_1,
                p_Header.KeyPart4_2,


                p_Header.KeyPart5_1,
                p_Header.KeyPart5_2,
                p_Header.KeyPart5_3,
                p_Header.KeyPart5_4,
            };

            var s_FirstSeed = s_SeedParts[0];
            var s_LastSeed = s_SeedParts[s_SeedParts.Length-1];

            var s_LowerPart = (ulong)s_SeedParts[(s_LastSeed & 0xF) + 2];
            var s_UpperPart = (ulong)s_SeedParts[(s_FirstSeed & 0xF)];

            this.m_Seed = (s_UpperPart << 32) | s_LowerPart;
        }
        private void InitKeys(Il2CppGlobalMetadataHeader p_Header)
        {
            var s_Random = new mt19937_64_t();
            s_Random.init_genrand64(this.m_Seed);


            this.m_StringsSize = p_Header.stringsCount ^ (uint)s_Random.genrand64_int64();
            this.m_StringsOffset = p_Header.stringsOffset ^ (uint)s_Random.genrand64_int64();

            // String literal size isnt encrypted..
            s_Random.genrand64_int64();
            this.m_StringLiteralSize = p_Header.stringLiteralCount;// ^ (uint)s_Random.genrand64_int64();
            this.m_StringLiteralOffset = p_Header.stringLiteralOffset ^ (uint)s_Random.genrand64_int64();

            this.m_StringLiteralDataSize = p_Header.stringLiteralDataCount ^ (uint)s_Random.genrand64_int64();
            this.m_StringLiteralDataOffset = p_Header.stringLiteralDataOffset ^ (uint)s_Random.genrand64_int64();
           

            m_KeyData = new byte[0x5000];

            for( var s_Index = 0; s_Index < 2560; s_Index++)
            {
                var s_DataOffset = s_Index*8;

                var s_TempBuffer = BitConverter.GetBytes(s_Random.genrand64_int64());;

                Array.Copy(s_TempBuffer, 0, this.m_KeyData, s_DataOffset, s_TempBuffer.Length);
            }
        }
    }
}
