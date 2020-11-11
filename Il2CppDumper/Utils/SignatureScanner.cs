using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Il2CppDumper.Utils
{
    class SignatureScanner
    {
        public SignatureScanner(string p_Signature)
        {
            ParseSignature(p_Signature);
        }


        protected List<ushort> m_Signature = new List<ushort>();
        protected int m_RelativeBegin = -1;
        protected int m_RelativeSize = -1;

        private byte HexCharToValue(char p_Char)
        {
            if (p_Char >= 'A' && p_Char <= 'F')
                return (byte)((byte)p_Char - 'A' + 0xA);

            if (p_Char >= 'a' && p_Char <= 'f')
                return (byte)((byte)p_Char - 'a' + 0xA);

            if (p_Char >= '0' && p_Char <= '9')
                return (byte)((byte)p_Char - '0');

            return 0;
        }

        private void ParseSignature(string p_Signature)
        {

            var s_ByteIndex = 0;
            for (var i = 0; i < p_Signature.Length;)
            {
                if (p_Signature[i] == ' ' ||
                    p_Signature[i] == '\r' ||
                    p_Signature[i] == '\n' ||
                    p_Signature[i] == '\t')
                {
                    i++;
                    continue;
                }

                if (p_Signature[i] == ')' ||
                    p_Signature[i] == ']')
                {
                    m_RelativeSize = s_ByteIndex - m_RelativeBegin;
                    i++;
                    continue;
                }

                if (p_Signature[i] == '(' ||
                    p_Signature[i] == '[')
                {
                    m_RelativeBegin = s_ByteIndex;
                    i++;
                    continue;
                }

                if (p_Signature[i] == '?')
                {
                    // Set upper short
                    m_Signature.Add(1 << 8);

                    s_ByteIndex++;

                    if (p_Signature[i + 1] == '?')
                        i += 2;
                    else
                        i++;
                    continue;
                }

                m_Signature.Add((ushort)((HexCharToValue(p_Signature[i]) << 4) | HexCharToValue(p_Signature[i + 1])));
                // Increment with 2 bytes
                i += 2;
                s_ByteIndex++;
            }
        }


        private int FindInBuffer(byte[] p_Buffer)
        {

            var s_Length = p_Buffer.Length - m_Signature.Count;

            for (var s_Index = 0; s_Index < s_Length; s_Index++)
            {

                if (p_Buffer[s_Index] != (byte)m_Signature[0])
                    continue;

                var s_SigIndex = 0;
                for (; s_SigIndex < m_Signature.Count; s_SigIndex++)
                {
                    if (m_Signature[s_SigIndex] >> 8 != 0)
                        continue;

                    if (p_Buffer[s_Index + s_SigIndex] != (byte)m_Signature[s_SigIndex])
                        break;
                }

                if (s_SigIndex != m_Signature.Count)
                    continue;


                return s_Index;
            }

            return -1;
        }


        public bool ResolveInBuffer(byte[] p_Buffer, out long p_Index, out long p_RelativeLocation)
        {
            p_RelativeLocation = -1;
            p_Index = FindInBuffer(p_Buffer);

            if (p_Index == -1)
                return false;


            if (m_RelativeSize == 4)
            {
                var s_Relative = BitConverter.ToInt32(p_Buffer, (int)p_Index + m_RelativeBegin);

                p_RelativeLocation = p_Index + m_RelativeBegin + m_RelativeSize + s_Relative;
            }
            else if (m_RelativeSize == 2)
            {
                var s_Relative = BitConverter.ToInt16(p_Buffer, (int)p_Index + m_RelativeBegin);

                p_RelativeLocation = p_Index + m_RelativeBegin + m_RelativeSize + s_Relative;
            }
            else if (m_RelativeSize == 1)
            {
                // dont know how c# handles chars, might not work. oh well
                var s_Relative = BitConverter.ToChar(p_Buffer, (int)p_Index + m_RelativeBegin);

                p_RelativeLocation = p_Index + m_RelativeBegin + m_RelativeSize + s_Relative;
            }


            return true;
        }
    }
}
