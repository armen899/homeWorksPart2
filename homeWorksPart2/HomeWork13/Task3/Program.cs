namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MediaPlayer m = new MediaPlayer();

            m.Play();
            m.Pause();

           
            m.Record();
            m.StopRecording();


        }
    }

    public interface IPlayable
    {
        void Play();

        void Pause();
    }

    public interface IRecordable
    {
        void Record();

        void StopRecording();
    }


    public class MediaPlayer : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        public void StopRecording()
        {
            Console.WriteLine("StopRecording");
        }
    }

}
