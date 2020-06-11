using System;

namespace PLPT.Models
{
    public class Lifts
    {
        public Lifts(string _username, DateTime _date, int _squat,
            int _bench, int _deadlift, int _bodyweight, int _total,
            int _wilks)
        {
            Username = _username;
            Date = _date;
            Squat = _squat;
            Bench = _bench;
            Deadlift = _deadlift;
            Bodyweight = _bodyweight;
            Total = _total;
            Wilks = _wilks;
        }

        public string Username { get; set; }
        public DateTime Date { get; set; }
        public int Squat { get; set; }
        public int Bench { get; set; }
        public int Deadlift { get; set; }
        public int Bodyweight { get; set; }
        public int Total { get; set; }
        public int Wilks { get; set; }
    }
}
