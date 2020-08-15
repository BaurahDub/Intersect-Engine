namespace Intersect.Config
{

    public class ChatOptions
    {

        //Chat
        public int MaxChatLength = 120; //120 characters

        public int MinIntervalBetweenChats = 400; //400 ms

        public bool MuteForProfanity = true;  // Do we mute players for using profanity?

        public int ProfanityCountBeforeMute = 5;  // 5 lines containing profanity before the user is muted.

        public int ProfanityMuteDays = 1;   // How long for do we mute people when they exceed the profanity count?

    }

}
