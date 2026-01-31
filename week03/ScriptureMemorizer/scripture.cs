public class Scripture
{
    private ScriptureReference _reference;
    private Word[] _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToArray();
    }

    public void HideRandomWord()
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToArray();
        if (visibleWords.Length > 0)
        {
            var randomWord = visibleWords[new Random().Next(visibleWords.Length)];
            randomWord.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public ScriptureReference GetReference()
    {
        return _reference;
    }

    public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
