namespace CryptoMiningSystem.Factories
{
    using Components;
    using Interfaces;

    public class VideoCardFactory
    {
        public VideoCardFactory()
        {

        }
        public IVideoCard CreateVideoCard(string videoType, string videoModel, int videoGeneration, int videoRam, double videoPrice)
        {
            if (videoType == "Game")
            {
                return new GameVideoCard(videoModel, videoGeneration, videoRam, videoPrice);
            }
            else if (videoType == "Mine")
            {
                return new MineVideoCard(videoModel, videoGeneration, videoRam, videoPrice);
            }

            return null;
        }
    }
}