using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Answers
    {
        string answer = "";

        string[] YesNoMaybe = {"Yeah, I guess.", "What do you think it is?", "Not a chance.", "I'm not feelin this one, boss.", 
            "What do you think I am, a fortune teller?", "No.", "I suppose.", "Yeah, no, I don't think so."};

        string[] OpenEnded = {"I sense many troubles ahead.", "You're gonna have a rough one, friendo.", "I don't know, I'm just an 8 ball.",
            "I asked the stars. They didn't know either, considering they're just balls of gas and chemical reactions in space.", 
            "I reached out to the heavens to see if they knew. They left me on read.", "Pack some comfort food.", "Are you okay? Do you need a hug?"};

        public string GetAnswer(int randomNumber, int questionType)
        {
            int i = 0;
            if (questionType == 0)
            {
                for (i = 0; i < YesNoMaybe.Length; i++) 
                { 
                    if (i == randomNumber)
                    {
                        answer = YesNoMaybe[i];
                        return answer;
                    }
                }
            }
            if (questionType == 1)
            {
                for (i = 0; i < OpenEnded.Length; i++)
                {
                    if (i == randomNumber)
                    {
                        answer = OpenEnded[i];
                        return answer;
                    }
                }
            }
            return "I haven't got a clue, actually.";
        }
    }
}
