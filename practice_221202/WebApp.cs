namespace practice_221202
{
    public class WebApp : IMailModule
    {
        public string Name { get; init; }

        public string Description { get; set; }

        public string ReadMail()
        {
            return $"{nameof(WebApp)} 閱讀信件中";
        }

        public string WriteMail()
        {
            return $"{nameof(WebApp)} 撰寫信件中";
        }
    }
}