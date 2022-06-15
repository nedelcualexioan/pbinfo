using System;
using System.Runtime.CompilerServices;

namespace pbinfo.classes
{
    public class Problem
    {
        private int varId;
        private String title;
        private String text;
        private String answer;

        public Problem(int varId, String title, String text, String answer)
        {
            this.varId = varId;
            this.title = title;
            this.text = text;
            this.answer = answer;
        }

        public int VarId
        {
            get => varId;
            set => varId = value;
        }

        public String Title
        {
            get => title;
            set => title = value;
        }

        public String Text
        {
            get => text;
            set => text = value;
        }

        public String Answer
        {
            get => answer;
            set => this.answer = value;
        }
    
    }
}