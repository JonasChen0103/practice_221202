namespace practice_221202
{
    public class MobileApp : IMailModule
    {
        public string Name { get; init; }

        public string Description { get; set; }

        public string ReadMail()
        {
            return $"{nameof(MobileApp)} 閱讀信件中";
        }

        public string WriteMail()
        {
            return $"{nameof(MobileApp)} 撰寫信件中";
        }
    }
}