using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chronicle.Managers
{
    internal interface ISagaInitializer
    {
        Task<(bool isInitialized, ISagaState state)> TryInitializeAsync<TMessage>(ISaga saga, SagaId id, TMessage _);

        Task<(ISaga saga, ISagaState state)> GetInitializedSagaAsync<TMessage>(SagaId id, IEnumerable<ISagaAction<TMessage>> actions);
    }
}
