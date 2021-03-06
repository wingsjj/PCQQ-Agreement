namespace QQ.Framework.Packets.Send.Data
{
    public class Send_0X001D : SendPacket
    {
        public Send_0X001D(QQUser user)
            : base(user)
        {
            Sequence = GetNextSeq();
            SecretKey = user.TXProtocol.SessionKey;
            Command = QQCommand.Data0X001D;
        }

        protected override void PutHeader()
        {
            base.PutHeader();
            SendPACKET_FIX();
        }

        /// <summary>
        ///     初始化包体
        /// </summary>
        protected override void PutBody()
        {
            BodyWriter.Write(new byte[]
            {
                0x33, 0x00, 0x05, 0x00, 0x08, 0x74, 0x2E, 0x71, 0x71, 0x2E, 0x63, 0x6F, 0x6D, 0x00, 0x0A,
                0x71, 0x75, 0x6E, 0x2E, 0x71, 0x71, 0x2E, 0x63, 0x6F, 0x6D, 0x00, 0x0C, 0x71, 0x7A, 0x6F, 0x6E, 0x65,
                0x2E,
                0x71, 0x71, 0x2E, 0x63, 0x6F, 0x6D, 0x00, 0x0C, 0x6A, 0x75, 0x62, 0x61, 0x6F, 0x2E, 0x71, 0x71, 0x2E,
                0x63,
                0x6F, 0x6D, 0x00, 0x09, 0x6B, 0x65, 0x2E, 0x71, 0x71, 0x2E, 0x63, 0x6F, 0x6D
            });
        }
    }
}