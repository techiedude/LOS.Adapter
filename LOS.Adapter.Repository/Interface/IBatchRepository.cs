using LOS.Adapter.Data.Services.Query;

namespace LOS.Adapter.Data.Services.Interface
{
    /// <summary>
    /// IBatchRepository
    /// </summary>
    public interface IBatchRepository
    {
        /// <summary>
        /// Opens the batch.
        /// </summary>
        /// <param name="request">The request.</param>
        void OpenBatch(OpenBatchCommand request);

        /// <summary>
        /// Closes the batch.
        /// </summary>
        void CloseBatch();
    }
}
