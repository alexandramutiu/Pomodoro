using System;
using System.Windows.Forms;

public class PomodoroTimer
{
    public int TotalSeconds { get; private set; }
    public int RemainingSeconds { get; private set; }

    private Timer timer;

    public event Action OnTick;
    public event Action OnFinished;

    public PomodoroTimer()
    {
        timer = new Timer();
        timer.Interval = 1000;
        timer.Tick += TimerTick;
    }

    public void Start(int minutes)
    {
        TotalSeconds = minutes * 60;
        RemainingSeconds = TotalSeconds;
        timer.Start();
    }

    public void Stop() => timer.Stop();

    public void Reset()
    {
        timer.Stop();
        RemainingSeconds = TotalSeconds;
        OnTick?.Invoke();
    }

    private void TimerTick(object sender, System.EventArgs e)
    {
        RemainingSeconds--;

        OnTick?.Invoke();

        if (RemainingSeconds <= 0)
        {
            timer.Stop();
            OnFinished?.Invoke();
        }
    }
}
