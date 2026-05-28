using NServiceBus.Persistence.Sql;

[assembly: SqlPersistenceSettings(
    MsSqlServerScripts = true,
    ScriptPromotionPath = "$(ProjectDir)nsb_scripts",
    ProduceSagaScripts = true,
    ProduceOutboxScripts = true,
    ProduceTimeoutScripts = false,
    ProduceSubscriptionScripts = false)]