namespace PLPT.Models
{
    public class BestLifts
    {
        // Model for holding best lifts options
        public BestLifts(int _squat, int _bench, int _deadlift, int _total, int _wilks)
        {
            Squat = _squat;
            Bench = _bench;
            Deadlift = _deadlift;
            Total = _total;
            Wilks = _wilks;
        }
        public int Squat { get; set; }
        public int Bench { get; set; }
        public int Deadlift { get; set; }
        public int Total { get; set; }
        public int Wilks { get; set; }
    }
}
