public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int pts, int target, int bonus) : base(name, desc, pts)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent() { _amountCompleted++; }
    public override bool IsComplete() => _amountCompleted >= _target;
    public int GetBonus() => IsComplete() && _amountCompleted == _target ? _bonus : 0;
    public override string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Progress: {_amountCompleted}/{_target}";
    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}