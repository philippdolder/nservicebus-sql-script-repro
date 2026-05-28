namespace Service;

using NServiceBus;

public class DummySaga : Saga<DummySaga.SagaData>
{
    public class SagaData : ContainSagaData
    {
    }

    protected override void ConfigureHowToFindSaga(SagaPropertyMapper<SagaData> mapper)
    {
    }
}