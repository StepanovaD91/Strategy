using System;
using Zenject;
public class ProduceUnitCommandCreator : CommandCreatorBase<IProduceUnitCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
    {
        creationCallback?.Invoke((IProduceUnitCommand)_context.Inject(new ProduceUnitCommandHeir()));
    }
}

