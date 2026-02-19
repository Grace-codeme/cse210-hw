public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string desc, int pts) : base(name, desc, pts) { _isComplete = false; }
    public override void RecordEvent() { _isComplete = true; }
    public override bool IsComplete() => _isComplete;
    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}