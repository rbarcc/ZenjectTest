using Zenject;
using System.Collections;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ITickable>().ToSingleGameObject<TestRunner>("TestGO");
        Container.Bind<IInitializable>().ToSingleGameObject<TestRunner>("TestGO2");
        Container.Bind<IFoo>().ToSingleGameObject<TestRunner>("TestGO3");
    }
}