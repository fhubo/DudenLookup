using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace DudenLookup
{
    public static class Duden
    {
        public static List<string> GetSentences(string input)
        {
            List<string> sentences = new List<string>();
            string splitChars = ".!?;";
            int lastSentenceStop = 0;
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    bool addSentence = false;
                    if (input.Length - i < 2)
                    {
                        addSentence = true;
                    }
                    else if (splitChars.Contains(input[i]) && (char.IsUpper(input[i + 1]) || char.IsUpper(input[i + 2]) || char.IsUpper(input[i + 3])))
                    {
                        addSentence = true;
                    }
                    if (addSentence)
                    {
                        sentences.Add(input.Substring(lastSentenceStop, i + 1 - lastSentenceStop));
                        lastSentenceStop = i + 1;
                        i++;
                    }
                }
                catch { }
            }

            return sentences;
        }

        public static List<string> SplitString(string input)
        {
            var sentences = GetSentences(input);

            List<string> parts = new List<string>();
            parts.Add("");
            var cInd = 0;
            foreach (var s in sentences)
            {
                if (800 > parts[cInd].Length + s.Length)
                {
                    parts[cInd] += s;
                }
                else
                {
                    parts.Add(s);
                    cInd++;
                }
            }

            return parts;
        }
        public static List<DudenError> GetPart(string input, int sentenceOffset)
        {
            List<DudenError> eList = new List<DudenError>();

            if (input.Length > 800)
            {
                return eList;
            }

            var req = (HttpWebRequest)WebRequest.Create("https://mentor.duden.de/api/grammarcheck?_format=json");
            req.ContentType = "application/json";
            req.Method = "POST";

            using (var sw = new StreamWriter(req.GetRequestStream()))
            {
                string json = "{\"text\":" + JsonConvert.SerializeObject(input) + ",\"userInteraction\":null,\"documentID\":\"lite - 1602275523689 - yVzwbZprsg\",\"maxProposals\":7}";
                sw.Write(json);
            }

            var response = (HttpWebResponse)req.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();

                var jsonObj = JObject.Parse(result);
                var dataObj = (JObject)jsonObj.Properties().FirstOrDefault().Value;
                var spellAdvicesArr = (JArray)dataObj.Properties().FirstOrDefault().Value;

                foreach (var spellAdv in spellAdvicesArr)
                {
                    var spellAdvObj = (JObject)spellAdv;

                    var errorCode = spellAdvObj.GetValue("errorCode").ToString();
                    var shortMessage = spellAdvObj.GetValue("shortMessage").ToString();
                    var original = spellAdvObj.GetValue("originalError").ToString();
                    var proposals = "";
                    try
                    {
                        proposals = spellAdvObj.GetValue("proposals").ToList().FirstOrDefault().ToString();
                    }
                    catch { }

                    var offset = sentenceOffset + int.Parse(spellAdvObj.GetValue("offset").ToString());
                    var length = int.Parse(spellAdvObj.GetValue("length").ToString());

                    eList.Add(new DudenError(errorCode, shortMessage, original, proposals, offset, length));
                }
            }

            return eList;
        }

        public static List<DudenError> GetFull(string input)
        {
            List<DudenError> eList = new List<DudenError>();
            List<string> parts = SplitString(input);
            for (int i = 0; i < parts.Count; i++)
            {
                int offset = 0;
                for (int j = 0; j < i; j++)
                {
                    offset += parts[j].Length;
                }
                eList.AddRange(GetPart(parts[i], offset));
            }
            return eList;
        }
    }
}
