using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
namespace MinecraftClient.Crypto.Streams
{
    /// <summary>
    /// An encrypted stream using AES, used for encrypting network data on the fly using AES.
    /// This is a mono-compatible adaptation which uses AES engine from the BouncyCastle project.
    /// </summary>

    public class MonoAesStream : Stream, IAesStream
    {
        CipherStream cstream;
        public MonoAesStream(Stream stream, byte[] key)
        {
            BaseStream = stream;
            BufferedBlockCipher enc = GenerateAES(key, true);
            BufferedBlockCipher dec = GenerateAES(key, false);
            cstream = new CipherStream(stream, dec, enc);
        }
        public Stream BaseStream { get; set; }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override void Flush()
        {
            BaseStream.Flush();
        }

        public override long Length
        {
            get { throw new NotSupportedException(); }
        }

        public override long Position
        {
            get
            {
                throw new NotSupportedException();
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        public override int ReadByte()
        {
            var temp = new byte[1];
            Read(temp, 0, 1);
            return temp[0];
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return cstream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void WriteByte(byte b)
        {
            Write(new[] { b }, 0, 1);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            cstream.Write(buffer, offset, count);
        }

        private BufferedBlockCipher GenerateAES(byte[] key, bool forEncryption)
        {
            var cipher = new BufferedBlockCipher(new CfbBlockCipher(new AesFastEngine(), 8));
            cipher.Init(forEncryption, new ParametersWithIV(new KeyParameter(key), key));
            return cipher;
        }
    }
}
