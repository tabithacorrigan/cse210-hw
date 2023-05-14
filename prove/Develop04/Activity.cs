public class Activity {

    private int _duration = 0;
    private string _activityName = "";

    public int Duration { get => _duration; set => _duration = value; }

    public string ActivityName { get => _activityName; set => _activityName = value; }



    public Activity(string name, int duration) {

        _duration = duration;
        _activityName = name;
    }

    
    public static int GetDuration(string seconds) {

        int secondsInt = int.Parse(seconds);

        int duration = secondsInt * 1000;

        return duration;
    }

}