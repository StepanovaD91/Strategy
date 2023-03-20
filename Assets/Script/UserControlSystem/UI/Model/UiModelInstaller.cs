using UnityEngine;
using Zenject;
public class UiModelInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CommandButtonsModel>().AsTransient();
        Container.Bind<CommandCreatorBase<IProduceUnitCommand>>()
        .To<ProduceUnitCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>()
        .To<AttackCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>()
        .To<MoveCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>()
        .To<PatrolCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>()
        .To<StopCommandCreator>().AsTransient();

    }
    
}