using System;
using System.Collections.Generic;
using System.Text;

namespace practice_221202
{
    class App
    {
        private string Name;
        public string Description;

        public App(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetDescription(string Description)
        {
            this.Description = Description;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public string ReadMail()
        {
            return (Name + " reading mails");
        }

        public string WriteMail()
        {
            return (Name + " writing mails");
        }
    }
}
