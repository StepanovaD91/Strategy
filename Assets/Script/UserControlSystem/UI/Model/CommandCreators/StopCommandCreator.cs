using System;
using Zenject;
public class StopCommandCreator : CommandCreatorBase<IStopCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IStopCommand> creationCallback)
    {
        creationCallback?.Invoke((IStopCommand)_context.Inject(new StopCommand()));
    }
}