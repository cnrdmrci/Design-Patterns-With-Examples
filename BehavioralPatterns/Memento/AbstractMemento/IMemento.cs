namespace DesignPatterns.BehavioralPatterns.Memento.AbstractMemento
{
    public interface IMemento
    {
        int GetLevel();
        string GetSectionName();
        void Restore();
    }
}
