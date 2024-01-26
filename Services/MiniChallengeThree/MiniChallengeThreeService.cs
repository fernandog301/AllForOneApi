
namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeOne;

    public class MiniChallengeThreeService : IMiniChallengeThreeServices
    {
        public string Sentence(string Name, string WakeUpTime)
        {

            string result = $"{Name} woke up at {WakeUpTime}.";
            return result;
        }
        }