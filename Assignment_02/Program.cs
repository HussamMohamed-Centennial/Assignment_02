using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public enum Audience
    {
        World,
        Group,
        Special
    }

    public class TikTok
    {
        private static int _ID;

        public string Originator
        {
            get;
        }

        public int Length
        {
            get;
        }

        public string HashTag
        {
            get;
        }

        public Audience Audience
        {
            get;
        }

        public string ID
        {
            get;
        }

        public TikTok(string orginator, int length, string hashTag, Audience audience)
        {
            _ID++;
            Originator = orginator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }

        private TikTok(string id, string originator, string length, string hashTAg, string audiance)
        {
            _ID = int.Parse(id);
            Originator = originator;
            Length = Convert.ToInt32(length);
            HashTag = hashTAg;
            Audience = (Audience)Enum.Parse(typeof(Audience), audiance);
        }

        public override string ToString()
        {
            return
                $"#{HashTag} is a TikTok made by: {Originator} with length of: {Length} second, and  the audiance is {Audience}";
        }

        public static TikTok Prase(string line)
        {
            string[] words = line.Split('\t');
            string org = words[0];
            int len = Convert.ToInt32(words[1]);
            string hash = words[2];
            Audience aud = (Audience)Enum.Parse(typeof(Audience), words[3]);
            TikTok tikTok = new TikTok(org, len, hash, aud);
            return tikTok;
        }
    }
}
